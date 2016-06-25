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
        void fill_comboBox1()
        {
            int licznik = 0;
            string[] names = new string[100];
            User myClass = new User();
            names = myClass.zapelnijcombobox();
            while (names[licznik] != null)
            {
                comboBox1.Items.Add(names[licznik]);
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
    }
}
