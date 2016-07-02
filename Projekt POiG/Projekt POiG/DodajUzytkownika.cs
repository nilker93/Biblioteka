using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_POiG
{
    public partial class DodajUzytkownika : Form
    {
        public DodajUzytkownika()
        {
            InitializeComponent();
            fill_comboBox1();
        }
        void fill_comboBox1()
        {

            Uprawnienia.Items.Add("Administrator");
            Uprawnienia.Items.Add("Użytkownik");
        }

        DateTime data;

        int UserMaxId = 0;
        int uprawnienie = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //////////
      
            string Query = "select ido from users WHERE ido=(SELECT max(ido) FROM users);";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            User myClass = new User();
            UserMaxId = myClass.pobierzMaksymalneId(constring, Query);
            if (Uprawnienia.SelectedText == "Administrator")
            {
                uprawnienie = 1;
            }
            else
            {
                uprawnienie = 0;

            }
            string a = Haslo.Text;
            string b = Powtorzhaslo.Text;
            if (a != b)
            {
                MessageBox.Show("Hasła są niezgodne!");
            }
            else
            {
                if (Pesel.Text.Length != 11)
                {
                    MessageBox.Show("Pesel jest za krótki!");
                }
                else
                {
                    myClass.dodajUzytkownika(UserMaxId, Imie.Text, Nazwisko.Text, Login.Text, Haslo.Text, uprawnienie, dateTimePicker1.Value.Date, Miasto.Text, Adres.Text, Pesel.Text);
                    //data = dateTimePicker1.Value.Date;
                    int i;
                    PanelAdministratora add = new PanelAdministratora();
                    this.Hide();
                    add.Show();
                }
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Pesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char nl = e.KeyChar;
            if (!Char.IsDigit(nl) && nl != 8)
            {
                e.Handled = true;
            }   
        }
    }
}

