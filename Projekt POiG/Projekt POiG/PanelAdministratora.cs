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
        }
        string[] names = new string[100];
        
        void fill_comboBox1()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            int licznik = 0;
            
            User myClass = new User();
           
            names = myClass.zapelnijcombobox();
            
            while (names[licznik] != null)
            {
                comboBox1.Items.Add(names[licznik]);
                comboBox2.Items.Add(names[licznik]);
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
            DodajUzytkownika add = new DodajUzytkownika();
            this.Hide();
            add.Show();

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
    }
}
