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
    public partial class PanelUzytkownika : Form
    {
        public PanelUzytkownika()
        {
            InitializeComponent();
            fill_listBox1();
        }
        string ObecnieZalogowanyUzytkownik = "";
        int idksiazki =0;
        int idusera = 0;
        string tytul= "";
        string[] ksiazkidolisty = new string[100];
        string[] info = new string[100];
        void fill_listBox1()
        {
           Book myClass = new Book();
           ksiazkidolisty = myClass.zapelnijcombobox();
           int licznik = 0;
           while (ksiazkidolisty[licznik] != null)
           {
               listBox1.Items.Add(ksiazkidolisty[licznik]);
               

               licznik++;

           }
           licznik = 0;
            //Uprawnienia.Items.Add("Administrator");
            
        }

        public void sesja(string uzytkownik)
        {
            ObecnieZalogowanyUzytkownik = uzytkownik;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tytul != "")
            {
                int maksymalneIDWyporzyczenia;
                Book pobierztuId = new Book();
                idksiazki = pobierztuId.pobierzId(tytul);

                User pobierztuIdusera = new User();
                idusera = pobierztuIdusera.pobierzId(ObecnieZalogowanyUzytkownik);

                string Query = "select idw from wyporzyczanie WHERE idw=(SELECT max(idw) FROM wyporzyczanie);";
                string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
                Library Biblioteka = new Library();

                maksymalneIDWyporzyczenia = Biblioteka.pobierzMaksymalneId(constring, Query);
                Biblioteka.WniosekORezerwacje(maksymalneIDWyporzyczenia,idksiazki,idusera);
                int k;
            }
            else
                MessageBox.Show("Proszę wybrać książkę którą chcesz pożyczyć!");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tytul = "";
            listBox2.Items.Clear();
            int id = 0;

            id = listBox1.SelectedIndex;
            int index = ksiazkidolisty[id].IndexOf(":");
            string poszukiwanystring = ksiazkidolisty[id];
            
            int i = 0;
            index++;
            foreach (char s in poszukiwanystring)
            {
                if (i >= index)
                {
                    tytul += poszukiwanystring[i];
                }
                i++;

            }
            Book b1 = new Book();
            info = b1.zapelnijlistbox(tytul);
            for (i = 0; i <= 5; i++)
            {
                listBox2.Items.Add(info[i]);
            }

        }
    }
}
