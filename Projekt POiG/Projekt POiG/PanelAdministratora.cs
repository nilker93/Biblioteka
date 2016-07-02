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
    public partial class PanelAdministratora : Form
    {
        public PanelAdministratora()
        {
            InitializeComponent();
            fill_comboBox1();
             fill_listBox1();
        }
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
        }
        string[] names = new string[100];
        string[] ksiazki = new string[100];
        
        void fill_comboBox1()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
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
                foreach(char s in poszukiwanystring)
                {
                    if (i >= index)
                    {
                        login += poszukiwanystring[i];
                    }
                    i++;

                }
                User myClass = new User();

                myClass.usunuzytkownika(login);
                fill_comboBox1();
                
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
                Book myClass = new Book();

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
    }
}
