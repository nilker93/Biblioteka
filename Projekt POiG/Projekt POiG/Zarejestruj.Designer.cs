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
            this.button1 = new System.Windows.Forms.Button();
            this.Pesel = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Miasto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Powtorzhaslo = new System.Windows.Forms.TextBox();
            this.Haslo = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Imie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zarejestruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(188, 228);
            this.Pesel.Margin = new System.Windows.Forms.Padding(4);
            this.Pesel.MaxLength = 11;
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(265, 22);
            this.Pesel.TabIndex = 39;
            this.Pesel.TextChanged += new System.EventHandler(this.Pesel_TextChanged);
            this.Pesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pesel_KeyPress);
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(188, 198);
            this.Adres.Margin = new System.Windows.Forms.Padding(4);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(265, 22);
            this.Adres.TabIndex = 38;
            // 
            // Miasto
            // 
            this.Miasto.Location = new System.Drawing.Point(188, 168);
            this.Miasto.Margin = new System.Windows.Forms.Padding(4);
            this.Miasto.Name = "Miasto";
            this.Miasto.Size = new System.Drawing.Size(265, 22);
            this.Miasto.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Pesel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Miasto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Data urodzenia";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 258);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // Powtorzhaslo
            // 
            this.Powtorzhaslo.Location = new System.Drawing.Point(188, 138);
            this.Powtorzhaslo.Margin = new System.Windows.Forms.Padding(4);
            this.Powtorzhaslo.Name = "Powtorzhaslo";
            this.Powtorzhaslo.Size = new System.Drawing.Size(265, 22);
            this.Powtorzhaslo.TabIndex = 30;
            // 
            // Haslo
            // 
            this.Haslo.Location = new System.Drawing.Point(188, 108);
            this.Haslo.Margin = new System.Windows.Forms.Padding(4);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(265, 22);
            this.Haslo.TabIndex = 29;
            this.Haslo.TextChanged += new System.EventHandler(this.Haslo_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(188, 78);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(265, 22);
            this.Login.TabIndex = 28;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(188, 48);
            this.Nazwisko.Margin = new System.Windows.Forms.Padding(4);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(265, 22);
            this.Nazwisko.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Powtórz hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nazwisko";
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(188, 18);
            this.Imie.Margin = new System.Windows.Forms.Padding(4);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(265, 22);
            this.Imie.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "imie";
            // 
            // Zarejestruj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 384);
            this.Controls.Add(this.Pesel);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Miasto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Powtorzhaslo);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Zarejestruj";
            this.Text = "Zarejestruj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Pesel;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox Miasto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Powtorzhaslo;
        private System.Windows.Forms.TextBox Haslo;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.Label label1;
    }
}