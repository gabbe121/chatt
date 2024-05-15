namespace ChatServer
{
    partial class Chatt
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
            this.btnStarta = new System.Windows.Forms.Button();
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStarta
            // 
            this.btnStarta.Location = new System.Drawing.Point(128, 50);
            this.btnStarta.Name = "btnStarta";
            this.btnStarta.Size = new System.Drawing.Size(146, 54);
            this.btnStarta.TabIndex = 0;
            this.btnStarta.Text = "starta server";
            this.btnStarta.UseVisualStyleBackColor = true;
            this.btnStarta.Click += new System.EventHandler(this.btnStarta_Click);
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Location = new System.Drawing.Point(128, 110);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.Size = new System.Drawing.Size(417, 296);
            this.tbxInkorg.TabIndex = 1;
            // 
            // Chatt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxInkorg);
            this.Controls.Add(this.btnStarta);
            this.Name = "Chatt";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStarta;
        private System.Windows.Forms.TextBox tbxInkorg;
    }
}

