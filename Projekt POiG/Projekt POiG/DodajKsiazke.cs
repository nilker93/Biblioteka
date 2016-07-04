using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Projekt_POiG
{
    public partial class DodajKsiazke : Form
    {
        public DodajKsiazke()
        {
            InitializeComponent();
        }

        int BookMaxId = 0;

        private void DodajKsiazke_Load(object sender, EventArgs e)
        {

        }
        public string[] pobierzWszystkieTytuly()
        {

            string[] tablicatytulow = new string[100];

            string tytul = "";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "select * from books ;";
            int i = 0;
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, conDataBase1);
            MySqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {

                    tytul = myReader1.GetString("tytul");

                    tablicatytulow[i] = tytul;
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



            return tablicatytulow;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string Query = "select idk from books WHERE idk=(SELECT max(idk) FROM books);";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            Book myClass = new Book();
            BookMaxId = myClass.pobierzMaksymalneId(constring, Query);
            /*
            if (Uprawnienia.SelectedText == "Administrator")
            {
                uprawnienie = 1;
            }
            else
            {
                uprawnienie = 0;

            }
            */
            int j = 0;
            string[] wszystkieTytuly = new string[100];
            bool czyistniejedanytytul = false;
            wszystkieTytuly = pobierzWszystkieTytuly();
            while (wszystkieTytuly[j] != null)
                    {
                        if (Tytul.Text == wszystkieTytuly[j])
                        {
                            czyistniejedanytytul = true;
                        }
                        j++;

                    }
            if (czyistniejedanytytul == true)
                     {
                         MessageBox.Show("Podana książka o tytule już istnieję");
                     }
                     else
                     {


                         myClass.dodajKsiazke(BookMaxId, Autor.Text, Tytul.Text, DataWydania.Text, Wydawnictwo.Text, IloscStron.Text, IloscEgzemplarzy.Text);
                         //data = dateTimePicker1.Value.Date;
                         int i;
                         PanelAdministratora add = new PanelAdministratora();
                         this.Hide();
                         add.Show();
                     }
        }

        private void IloscStron_KeyPress(object sender, KeyPressEventArgs e)
        {
           char nl = e.KeyChar;
           if (!Char.IsDigit(nl) && nl != 8 )
           {
               e.Handled = true;
           }    
        }

        private void IloscEgzemplarzy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char nl = e.KeyChar;
            if (!Char.IsDigit(nl) && nl != 8)
            {
                e.Handled = true;
            }    
        }

        private void DataWydania_KeyPress(object sender, KeyPressEventArgs e)
        {
            char nl = e.KeyChar;
            if (!Char.IsDigit(nl) && nl != 8)
            {
                e.Handled = true;
            }    
        }

        private void IloscEgzemplarzy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

