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

        private void button1_Click(object sender, EventArgs e)
        {


            string Query = "select idk from books WHERE idk=(SELECT max(idk) FROM books);";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            Book myClass = new Book();
            BookMaxId = myClass.pobierzMaksymalneId(constring, Query);
            myClass.dodajKsiazke(BookMaxId, Autor.Text, Tytul.Text, DataWydania.Text, Wydawnictwo.Text, IloscStron.Text, IloscEgzemplarzy.Text);
            //data = dateTimePicker1.Value.Date;
            int i;
            PanelAdministratora add = new PanelAdministratora();
            this.Hide();
            add.Show();
        }
    }
}
