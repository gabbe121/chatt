namespace chattklient2
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.tbxMeddelande = new System.Windows.Forms.TextBox();
            this.tbxAnvändarnamn = new System.Windows.Forms.TextBox();
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "inkorg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "skriv ditt användar namn  och medelanden här:";
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(539, 360);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(185, 62);
            this.btnSkicka.TabIndex = 16;
            this.btnSkicka.Text = "Skicka";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(493, 28);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(75, 23);
            this.btnAnslut.TabIndex = 15;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // tbxMeddelande
            // 
            this.tbxMeddelande.Location = new System.Drawing.Point(464, 105);
            this.tbxMeddelande.Multiline = true;
            this.tbxMeddelande.Name = "tbxMeddelande";
            this.tbxMeddelande.Size = new System.Drawing.Size(283, 237);
            this.tbxMeddelande.TabIndex = 14;
            // 
            // tbxAnvändarnamn
            // 
            this.tbxAnvändarnamn.Location = new System.Drawing.Point(175, 28);
            this.tbxAnvändarnamn.Name = "tbxAnvändarnamn";
            this.tbxAnvändarnamn.Size = new System.Drawing.Size(100, 22);
            this.tbxAnvändarnamn.TabIndex = 13;
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Location = new System.Drawing.Point(57, 105);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxInkorg.Size = new System.Drawing.Size(323, 237);
            this.tbxInkorg.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.tbxMeddelande);
            this.Controls.Add(this.tbxAnvändarnamn);
            this.Controls.Add(this.tbxInkorg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.TextBox tbxMeddelande;
        private System.Windows.Forms.TextBox tbxAnvändarnamn;
        private System.Windows.Forms.TextBox tbxInkorg;
    }
}

