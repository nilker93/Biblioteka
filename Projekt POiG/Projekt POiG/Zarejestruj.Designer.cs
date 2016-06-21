namespace Projekt_POiG
{
    partial class Zarejestruj
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
            this.rejestracja1 = new Projekt_POiG.rejestracja();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rejestracja1
            // 
            this.rejestracja1.Location = new System.Drawing.Point(12, 12);
            this.rejestracja1.Name = "rejestracja1";
            this.rejestracja1.Size = new System.Drawing.Size(413, 416);
            this.rejestracja1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zarejestruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zarejestruj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rejestracja1);
            this.Name = "Zarejestruj";
            this.Text = "Zarejestruj";
            this.ResumeLayout(false);

        }

        #endregion

        private rejestracja rejestracja1;
        private System.Windows.Forms.Button button1;
    }
}