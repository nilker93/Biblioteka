namespace Projekt_POiG
{
    partial class DodajKsiazke
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IloscEgzemplarzy = new System.Windows.Forms.TextBox();
            this.IloscStron = new System.Windows.Forms.TextBox();
            this.Wydawnictwo = new System.Windows.Forms.TextBox();
            this.DataWydania = new System.Windows.Forms.TextBox();
            this.Tytul = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ilość egzemplarzy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ilość stron";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Wydawnictwo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data wydania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tytuł";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Autor";
            // 
            // IloscEgzemplarzy
            // 
            this.IloscEgzemplarzy.Location = new System.Drawing.Point(173, 237);
            this.IloscEgzemplarzy.Name = "IloscEgzemplarzy";
            this.IloscEgzemplarzy.Size = new System.Drawing.Size(218, 22);
            this.IloscEgzemplarzy.TabIndex = 23;
            // 
            // IloscStron
            // 
            this.IloscStron.Location = new System.Drawing.Point(173, 194);
            this.IloscStron.Name = "IloscStron";
            this.IloscStron.Size = new System.Drawing.Size(218, 22);
            this.IloscStron.TabIndex = 22;
            // 
            // Wydawnictwo
            // 
            this.Wydawnictwo.Location = new System.Drawing.Point(173, 150);
            this.Wydawnictwo.Name = "Wydawnictwo";
            this.Wydawnictwo.Size = new System.Drawing.Size(218, 22);
            this.Wydawnictwo.TabIndex = 21;
            // 
            // DataWydania
            // 
            this.DataWydania.Location = new System.Drawing.Point(173, 108);
            this.DataWydania.Name = "DataWydania";
            this.DataWydania.Size = new System.Drawing.Size(218, 22);
            this.DataWydania.TabIndex = 20;
            // 
            // Tytul
            // 
            this.Tytul.Location = new System.Drawing.Point(173, 67);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(218, 22);
            this.Tytul.TabIndex = 19;
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(173, 25);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(218, 22);
            this.Autor.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 47);
            this.button1.TabIndex = 36;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajKsiazke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IloscEgzemplarzy);
            this.Controls.Add(this.IloscStron);
            this.Controls.Add(this.Wydawnictwo);
            this.Controls.Add(this.DataWydania);
            this.Controls.Add(this.Tytul);
            this.Controls.Add(this.Autor);
            this.Name = "DodajKsiazke";
            this.Text = "DodajKsiazke";
            this.Load += new System.EventHandler(this.DodajKsiazke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IloscEgzemplarzy;
        private System.Windows.Forms.TextBox IloscStron;
        private System.Windows.Forms.TextBox Wydawnictwo;
        private System.Windows.Forms.TextBox DataWydania;
        private System.Windows.Forms.TextBox Tytul;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.Button button1;
    }
}