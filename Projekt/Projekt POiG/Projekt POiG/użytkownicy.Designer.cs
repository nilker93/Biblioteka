namespace Projekt_POiG
{
    partial class użytkownicy
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
            this.SuspendLayout();
            // 
            // rejestracja1
            // 
            this.rejestracja1.Location = new System.Drawing.Point(3, 12);
            this.rejestracja1.Name = "rejestracja1";
            this.rejestracja1.Size = new System.Drawing.Size(413, 480);
            this.rejestracja1.TabIndex = 0;
            // 
            // użytkownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 506);
            this.Controls.Add(this.rejestracja1);
            this.Name = "użytkownicy";
            this.Text = "użytkownicy";
            this.ResumeLayout(false);

        }

        #endregion

        private rejestracja rejestracja1;
    }
}