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
    public partial class EdytujKsiazke : Form
    {
        public EdytujKsiazke()
        {
            InitializeComponent();
        }

        int BookMaxId = 0;

        private void EdytujKsiazke_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "select idk from books WHERE idk=(SELECT max(idk) FROM books);";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            Book myClass = new Book();
            BookMaxId = myClass.pobierzMaksymalneId(constring, Query);
            myClass.edytujKsiazke( Autor.Text, Tytul.Text, DataWydania.Text, Wydawnictwo.Text, IloscStron.Text, IloscEgzemplarzy.Text);
            //data = dateTimePicker1.Value.Date;
            PanelAdministratora add = new PanelAdministratora();
            this.Hide();
            add.Show();
        }
    }
}
