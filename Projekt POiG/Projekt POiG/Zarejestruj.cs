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
    public partial class Zarejestruj : Form
    {
        public Zarejestruj()
        {
            InitializeComponent();
        }
        
        DateTime data;

        int UserMaxId = 0;
        int uprawnienie = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //////////
            uprawnienie = 0;
            string Query = "select ido from users WHERE ido=(SELECT max(ido) FROM users);";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            User myClass = new User();
            UserMaxId = myClass.pobierzMaksymalneId(constring, Query);

            myClass.dodajUzytkownika(UserMaxId, Imie.Text, Nazwisko.Text, Login.Text, Haslo.Text, uprawnienie, dateTimePicker1.Value.Date, Miasto.Text, Adres.Text, Pesel.Text);
            //data = dateTimePicker1.Value.Date;
            int i;
            Form1 add = new Form1();
            this.Hide();
            add.Show();

        }
    }
}
