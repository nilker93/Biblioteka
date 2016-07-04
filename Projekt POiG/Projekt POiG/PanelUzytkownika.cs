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

        string CzyJestZarezerwowana = "";
        string wybranaksiazka = "";
        void PobierzUzytkownikaiKsiazkeZComboBox3()
        {
            CzyJestZarezerwowana = "";
            wybranaksiazka = "";
            string pobranyitemzlistbox = "";
            pobranyitemzlistbox = listBox3.SelectedItem.ToString();
            int index = pobranyitemzlistbox.IndexOf(":");
            string poszukiwanystring = pobranyitemzlistbox;
            
            int i = 0;
            index++;
            foreach (char s in poszukiwanystring)
            {
                if (i < index)
                {
                    CzyJestZarezerwowana += poszukiwanystring[i];
                }


                if (i >= index)
                {
                    wybranaksiazka += poszukiwanystring[i];
                }
                i++;


            }
            i = 0;

            
        }

        public void SesjaUser(string uzytkownik)
        {
            ObecnieZalogowanyUzytkownik = uzytkownik;
            OnClickFillcomboBox5();

        }
        void OnClickFillcomboBox5()
        {
            listBox3.Items.Clear();
            int licznik = 0;
            int iduzytkownika = 0;
            User u1 = new User();
            iduzytkownika = u1.pobierzId(ObecnieZalogowanyUzytkownik);
            Library zwroc = new Library();
            string[] pobierzjakjest = new string[100];
            pobierzjakjest = zwroc.ZapelnijListboxPozycjami(iduzytkownika);
            while (pobierzjakjest[licznik] != null)
            {
                listBox3.Items.Add(pobierzjakjest[licznik]);
                licznik++;
            }
        }

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

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (tytul != "")
            {
                bool CzyPodanaKsiazkaZostalaJuzWyporzyczona = false;
                int maksymalneIDWyporzyczenia;
                Book pobierztuId = new Book();
                idksiazki = pobierztuId.pobierzId(tytul);

                User pobierztuIdusera = new User();
                idusera = pobierztuIdusera.pobierzId(ObecnieZalogowanyUzytkownik);

                string Query = "select idw from wyporzyczanie WHERE idw=(SELECT max(idw) FROM wyporzyczanie);";
                string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
                Library Biblioteka = new Library();
                CzyPodanaKsiazkaZostalaJuzWyporzyczona = Biblioteka.SprawdzCzyKsiazkaJestJuzWyporzyczonaPrzezDanegoUzytkownika(idksiazki,idusera);
                if (CzyPodanaKsiazkaZostalaJuzWyporzyczona == false)
                {
                    maksymalneIDWyporzyczenia = Biblioteka.pobierzMaksymalneId(constring, Query);
                    Biblioteka.WniosekORezerwacje(maksymalneIDWyporzyczenia, idksiazki, idusera);
                }
                else
                    MessageBox.Show("Nie możesz wyporzyczyc kolejny raz tej samej ksiazki!");
                int k;
            }
            else
                MessageBox.Show("Proszę wybrać książkę którą chcesz pożyczyć!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = listBox3.SelectedIndex;
            if (id == -1)
            {
                MessageBox.Show("Proszę wybrać książkę której chcesz przedłużyć termin!");
            }
            else
            {
                int obecneIdKsiazkiZComboBox3 = 0;
                int obecneIdUseraZComboBox3 = 0;
                PobierzUzytkownikaiKsiazkeZComboBox3();
                if (CzyJestZarezerwowana == "Wypożyczona:")
                {
                    Book pobierztuId = new Book();
                    obecneIdKsiazkiZComboBox3 = pobierztuId.pobierzId(wybranaksiazka);
                    Library Pozycz = new Library();

                    User pobierztuIdusera = new User();
                    obecneIdUseraZComboBox3 = pobierztuIdusera.pobierzId(ObecnieZalogowanyUzytkownik);

                    
                    DateTime miesiacpozniej;
                   
                    miesiacpozniej = Pozycz.ZwrocDate(obecneIdKsiazkiZComboBox3, obecneIdUseraZComboBox3);
                    Pozycz.ZmienDate(obecneIdKsiazkiZComboBox3, obecneIdUseraZComboBox3, miesiacpozniej);
                    int jk;
                }
                else
                    MessageBox.Show("Można przedłużać rezerwację tylko wypożyczonych książek!");


            }
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
