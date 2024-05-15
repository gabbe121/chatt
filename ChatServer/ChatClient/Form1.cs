using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ChatClient
{
    public partial class Server : Form
    {
        TcpClient klient;
        NetworkStream ns;
        Thread läsTråd;

        public Server()
        {
            InitializeComponent();
        }

        private void btnAnslut_Click(object sender, System.EventArgs e)
        {
            try
            {
                klient = new TcpClient("127.0.0.1", 12345);
                ns = klient.GetStream();
                string användarnamn = tbxAnvändarnamn.Text;
                byte[] buffert = Encoding.Unicode.GetBytes(användarnamn);
                ns.Write(buffert, 0, buffert.Length);

                läsTråd = new Thread(LäsMeddelanden);
                läsTråd.Start();

                btnAnslut.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
            }
        }

        private void btnSkicka_Click(object sender, System.EventArgs e)
        {
            try
            {
                string meddelande = tbxMeddelande.Text;
                byte[] buffert = Encoding.Unicode.GetBytes(meddelande);
                ns.Write(buffert, 0, buffert.Length);
                tbxMeddelande.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
            }
        }

        private void LäsMeddelanden()
        {
            byte[] buffert = new byte[1024];
            int n;

            try
            {
                while ((n = ns.Read(buffert, 0, buffert.Length)) > 0)
                {
                    string meddelande = Encoding.Unicode.GetString(buffert, 0, n);
                    VisaMeddelande(meddelande);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
            }
        }

        private void VisaMeddelande(string meddelande)
        {
            if (tbxInkorg.InvokeRequired)
            {
                tbxInkorg.Invoke(new MethodInvoker(delegate { tbxInkorg.AppendText(meddelande + Environment.NewLine); }));
            }
            else
            {
                tbxInkorg.AppendText(meddelande + Environment.NewLine);
            }
        }
    }
}
