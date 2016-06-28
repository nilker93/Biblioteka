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
    public partial class Edytuj_ksiazke : Form
    {
        string jakKsiazkaMaBycEdytowana = "";
        public Edytuj_ksiazke()
        {
            InitializeComponent();
        }

        public void przekaz(string ksiazka)
        {
            jakKsiazkaMaBycEdytowana = ksiazka;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "select idk from books WHERE idk=(SELECT max(idk) FROM books);";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            Book myClass = new Book();
            //BookMaxId = myClass.pobierzMaksymalneId(constring, Query);

            myClass.edytujKsiazke(jakKsiazkaMaBycEdytowana, Autor.Text, Tytul.Text, DataWydania.Text, Wydawnictwo.Text, IloscStron.Text, IloscEgzemplarzy.Text);
            //data = dateTimePicker1.Value.Date;
            int i;
            PanelAdministratora add = new PanelAdministratora();
            this.Hide();
            add.Show();
        }
    }
}
/*
        string[] tablicaloginow = new string[100];
        string jakiUzytkownikMaBycEdytowany = "";



        int uprawnienie = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            User myClass = new User();

            if (comboBox1.SelectedText == "Administrator")
            {
                uprawnienie = 1;
            }
            else
            {
                uprawnienie = 0;

            }
            myClass.edytujuzytkownika(jakiUzytkownikMaBycEdytowany, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, uprawnienie, dateTimePicker1.Value.Date, textBox6.Text, textBox7.Text, textBox8.Text);
            //data = dateTimePicker1.Value.Date;
            int i;
            PanelAdministratora add = new PanelAdministratora();
            this.Hide();
            add.Show();
        }
    }
}
*/
