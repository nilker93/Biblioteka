﻿using System;
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
    public partial class PanelAdministratora : Form
    {
        public PanelAdministratora()
        {
            InitializeComponent();
            fill_comboBox1();
            fill_listBox1();
        }
        string wybranyuzytkownikdofillcombo5 = "";
        int idksiazki = 0;
        int idusera = 0;
        string[] ksiazkidolisty = new string[100];
        string[] info = new string[100];
        string ObecnieZalogowanyUzytkownik = "";
        string tytul = "";

        string CzyJestZarezerwowana = "";
        string wybranaksiazka = "";
        string uzytkownik = "";
        void PobierzUzytkownikaiKsiazkeZComboBox3()
        {
            CzyJestZarezerwowana = "";
            wybranaksiazka = "";
            string pobranyitemzlistbox = "";
            pobranyitemzlistbox = listBox3.SelectedItem.ToString();
            int index = pobranyitemzlistbox.IndexOf(":");
            string poszukiwanystring = pobranyitemzlistbox;
            wybranyuzytkownikdofillcombo5 = "";
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

            uzytkownik = "";
            string pobranycombobox = "";
            pobranycombobox = comboBox5.SelectedItem.ToString();
            int index1 = pobranycombobox.IndexOf(":");
            foreach (char s in pobranycombobox)
            {
                if (i > index1)
                {
                    uzytkownik += pobranycombobox[i];
                }
                i++;

            }
        }
        void OnClickFillcomboBox5()
        {
            listBox3.Items.Clear();
            int licznik = 0;
            int iduzytkownika = 0;
            User u1 = new User();
            iduzytkownika = u1.pobierzId(wybranyuzytkownikdofillcombo5);
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
        }
        string[] names = new string[100];
        string[] ksiazki = new string[100];

        void fill_comboBox1()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox5.Items.Clear();
            comboBox4.Items.Clear();
            int licznik = 0;

            User myClass = new User();
            Book myBook = new Book();
            names = myClass.zapelnijcombobox();
            ksiazki = myBook.zapelnijcombobox();
            while (names[licznik] != null)
            {
                comboBox1.Items.Add(names[licznik]);

                comboBox2.Items.Add(names[licznik]);
                comboBox5.Items.Add(names[licznik]);

                licznik++;

            }
            licznik = 0;
            while (ksiazki[licznik] != null)
            {
                comboBox3.Items.Add(ksiazki[licznik]);
                comboBox4.Items.Add(ksiazki[licznik]);

                licznik++;

            }
        }


        public void sesja(string uzytkownik)
        {
            ObecnieZalogowanyUzytkownik = uzytkownik;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            DodajUzytkownika add = new DodajUzytkownika();
            this.Hide();
            add.Show();





            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = comboBox1.SelectedIndex;
            if (id == -1)
            {
                MessageBox.Show("Proszę wybrać wpierw użytkownika którego chcesz usunąć!");
            }
            else
            {


                int index = names[id].IndexOf(":");
                string poszukiwanystring = names[id];
                string login = "";
                int i = 0;
                index++;
                foreach (char s in poszukiwanystring)
                {
                    if (i >= index)
                    {
                        login += poszukiwanystring[i];
                    }
                    i++;

                }
                EdytujUżytkownika add = new EdytujUżytkownika();
                add.przekaz(login);
                this.Hide();

                add.Show();

            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = comboBox2.SelectedIndex;
            if (id == -1)
            {
                MessageBox.Show("Proszę wybrać wpierw użytkownika którego chcesz usunąć!");
            }
            else
            {
               

                int index = names[id].IndexOf(":");
                string poszukiwanystring = names[id];
                string login = "";
                int i = 0;
                index++;
                foreach (char s in poszukiwanystring)
                {
                    if (i >= index)
                    {
                        login += poszukiwanystring[i];
                    }
                    i++;

                }
                if (ObecnieZalogowanyUzytkownik == login)
                {
                    MessageBox.Show("Nie możesz usunąć samego siebie! Poproś innego administratora o usunięcie twojego konta");
                }
                else
                {
                    int idusera = 0;
                    User myClass = new User();
                    Library UsunWyporzyczenieDlaUsunietegoUsera = new Library();
                    idusera = myClass.pobierzId(login);
                    UsunWyporzyczenieDlaUsunietegoUsera.UsunWyporzyczoneKsiazkiTamGdzieZostalUsunietyUzytkownik(idusera);
                    myClass.usunuzytkownika(login);
                    
                    fill_comboBox1();
                }

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DodajKsiazke add = new DodajKsiazke();
            this.Hide();
            add.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = comboBox3.SelectedIndex;
            if (id == -1)
            {
                MessageBox.Show("Proszę wybrać wpierw książkę którego chcesz usunąć!");
            }
            else
            {
                int index = ksiazki[id].IndexOf(":");
                string poszukiwanystring = ksiazki[id];
                string tytul = "";
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
                int idksiazki = 0;
                Book myClass = new Book();
                Library UsunWyporzyczenieDlaUsunietegoUsera = new Library();
                idksiazki = myClass.pobierzId(tytul);
                UsunWyporzyczenieDlaUsunietegoUsera.UsunWyporzyczoneKsiazkiTamGdzieZostalaUsunietaKsiazka(idksiazki);
                
                    



                

                myClass.usunKsiazke(tytul);
                fill_comboBox1();

            }
        }

        private void PanelAdministratora_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = comboBox4.SelectedIndex;
            if (id == -1)
            {
                MessageBox.Show("Proszę wybrać wpierw użytkownika którego chcesz usunąć!");
            }
            else
            {


                int index = ksiazki[id].IndexOf(":");
                string poszukiwanystring = ksiazki[id];
                string tytul = "";
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
                Edytuj_ksiazke add = new Edytuj_ksiazke();
                add.przekaz(tytul);
                this.Hide();
                add.Show();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int id = 0;

            id = listBox1.SelectedIndex;
            int index = ksiazkidolisty[id].IndexOf(":");
            string poszukiwanystring = ksiazkidolisty[id];
            tytul = "";
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
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
                CzyPodanaKsiazkaZostalaJuzWyporzyczona = Biblioteka.SprawdzCzyKsiazkaJestJuzWyporzyczonaPrzezDanegoUzytkownika(idksiazki, idusera);
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

        private void button4_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = listBox3.SelectedIndex;
            if (id == -1)
            {
                MessageBox.Show("Proszę wybrać książkę którą chcesz pożyczyć!");
            }
            else
            {
                int obecneIdKsiazkiZComboBox3 = 0;
                int obecneIdUseraZComboBox3 = 0;
                PobierzUzytkownikaiKsiazkeZComboBox3();
                if (CzyJestZarezerwowana == "Prośba O Rezerwację:")
                {
                    Book pobierztuId = new Book();
                    obecneIdKsiazkiZComboBox3 = pobierztuId.pobierzId(wybranaksiazka);
                    Library Pozycz = new Library();

                    User pobierztuIdusera = new User();
                    obecneIdUseraZComboBox3 = pobierztuIdusera.pobierzId(uzytkownik);

                    DateTime when = DateTime.Today;
                    DateTime miesiacpozniej;
                    miesiacpozniej = when.AddMonths(1);

                    Pozycz.ZmienDate(obecneIdKsiazkiZComboBox3, obecneIdUseraZComboBox3, miesiacpozniej);
                    int jk;

                    listBox3.Items.Clear();
                    comboBox5_SelectedIndexChanged(sender, e);
                }
                else
                    MessageBox.Show("Można pożyczyć tylko książki które zostały uprzednio zarezerwowane!");


            }

        }


        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            id = comboBox5.SelectedIndex;
            if (id == -1)
            {
                MessageBox.Show("Proszę wybrać wpierw użytkownika którego chcesz usunąć!");
            }
            else
            {


                int index = names[id].IndexOf(":");
                string poszukiwanystring = names[id];
                wybranyuzytkownikdofillcombo5 = "";
                int i = 0;
                index++;
                foreach (char s in poszukiwanystring)
                {
                    if (i >= index)
                    {
                        wybranyuzytkownikdofillcombo5 += poszukiwanystring[i];
                    }
                    i++;


                }
                OnClickFillcomboBox5();
            }

        }

        private void button9_Click(object sender, EventArgs e)
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
                    obecneIdUseraZComboBox3 = pobierztuIdusera.pobierzId(uzytkownik);


                    DateTime miesiacpozniej;

                    miesiacpozniej = Pozycz.ZwrocDate(obecneIdKsiazkiZComboBox3, obecneIdUseraZComboBox3);
                    Pozycz.ZmienDate(obecneIdKsiazkiZComboBox3, obecneIdUseraZComboBox3, miesiacpozniej);
                    int jk;
                }
                else
                    MessageBox.Show("Można przedłużać rezerwację tylko wypożyczonych książek!");


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = listBox3.SelectedIndex;
            if (id == -1)
            {
                MessageBox.Show("Proszę wybrać książkę którą chcesz oddać!");
            }
            else
            {
                int obecneIdKsiazkiZComboBox3 = 0;
                int obecneIdUseraZComboBox3 = 0;
                PobierzUzytkownikaiKsiazkeZComboBox3();

                Book pobierztuId = new Book();
                obecneIdKsiazkiZComboBox3 = pobierztuId.pobierzId(wybranaksiazka);
                Library Pozycz = new Library();

                User pobierztuIdusera = new User();
                obecneIdUseraZComboBox3 = pobierztuIdusera.pobierzId(uzytkownik);



                Pozycz.OddajKsiazke(obecneIdKsiazkiZComboBox3, obecneIdUseraZComboBox3);
                int jk;

                listBox3.Items.Clear();
                comboBox5_SelectedIndexChanged(sender, e);

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            this.Hide();
            add.Show();
        }

    }
}
