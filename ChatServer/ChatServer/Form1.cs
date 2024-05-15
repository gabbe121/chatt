using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Chatt : Form
    {
        TcpListener lyssnare;
        List<TcpClient> klienter = new List<TcpClient>();
        int port = 12345;

        public Chatt()
        {
            InitializeComponent();
        }

        private void btnStarta_Click(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }

            btnStarta.Enabled = false;
            Task.Run(() => StartaMottagning());
        }

        private async Task StartaMottagning()
        {
            while (true)
            {
                TcpClient klient = await lyssnare.AcceptTcpClientAsync();
                lock (klienter)
                {
                    klienter.Add(klient);
                }
                Task.Run(() => HanteraKlient(klient));
            }
        }

        private async void HanteraKlient(TcpClient klient)
        {
            byte[] buffert = new byte[1024];
            int n;
            string användarnamn = "";

            try
            {
                // Läs användarnamnet från klienten
                n = await klient.GetStream().ReadAsync(buffert, 0, buffert.Length);
                användarnamn = Encoding.Unicode.GetString(buffert, 0, n);
                LoggaMeddelande($"{användarnamn} har anslutit.");

                while ((n = await klient.GetStream().ReadAsync(buffert, 0, buffert.Length)) != 0)
                {
                    // Läs meddelandet från klienten
                    string meddelande = Encoding.Unicode.GetString(buffert, 0, n);
                    string fullMeddelande = $"{användarnamn}: {meddelande}";
                    LoggaMeddelande(fullMeddelande);

                    // Skicka meddelandet till alla andra klienter
                    SkickaTillAllaKlienter(fullMeddelande, klient);
                }
            }
            catch (Exception error)
            {
                LoggaMeddelande($"{användarnamn} har kopplats bort.");
                MessageBox.Show(error.Message, Text);
            }
            finally
            {
                // Ta bort klienten när den kopplar från
                lock (klienter)
                {
                    klienter.Remove(klient);
                }
                klient.Close();
            }
        }

        private void SkickaTillAllaKlienter(string meddelande, TcpClient avsändare)
        {
            byte[] buffert = Encoding.Unicode.GetBytes(meddelande);
            lock (klienter)
            {
                foreach (var klient in klienter)
                {
                    if (klient != avsändare)
                    {
                        try
                        {
                            klient.GetStream().Write(buffert, 0, buffert.Length);
                        }
                        catch (Exception)
                        {
                            klienter.Remove(klient);
                        }
                    }
                }
            }
        }

        private void LoggaMeddelande(string meddelande)
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
