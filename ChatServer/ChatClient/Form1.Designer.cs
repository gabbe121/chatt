namespace ChatClient
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.tbxAnvändarnamn = new System.Windows.Forms.TextBox();
            this.tbxMeddelande = new System.Windows.Forms.TextBox();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Location = new System.Drawing.Point(52, 121);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxInkorg.Size = new System.Drawing.Size(323, 237);
            this.tbxInkorg.TabIndex = 0;
            // 
            // tbxAnvändarnamn
            // 
            this.tbxAnvändarnamn.Location = new System.Drawing.Point(133, 44);
            this.tbxAnvändarnamn.Name = "tbxAnvändarnamn";
            this.tbxAnvändarnamn.Size = new System.Drawing.Size(100, 22);
            this.tbxAnvändarnamn.TabIndex = 1;
            // 
            // tbxMeddelande
            // 
            this.tbxMeddelande.Location = new System.Drawing.Point(459, 121);
            this.tbxMeddelande.Multiline = true;
            this.tbxMeddelande.Name = "tbxMeddelande";
            this.tbxMeddelande.Size = new System.Drawing.Size(283, 237);
            this.tbxMeddelande.TabIndex = 2;
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(488, 44);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(75, 23);
            this.btnAnslut.TabIndex = 3;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(534, 376);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(185, 62);
            this.btnSkicka.TabIndex = 4;
            this.btnSkicka.Text = "Skicka";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.tbxMeddelande);
            this.Controls.Add(this.tbxAnvändarnamn);
            this.Controls.Add(this.tbxInkorg);
            this.Name = "Server";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInkorg;
        private System.Windows.Forms.TextBox tbxAnvändarnamn;
        private System.Windows.Forms.TextBox tbxMeddelande;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.Button btnSkicka;
    }
}

