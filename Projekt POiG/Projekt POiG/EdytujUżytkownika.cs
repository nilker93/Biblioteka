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
    public partial class EdytujUżytkownika : Form
    {
        public EdytujUżytkownika()
        {
            InitializeComponent();
             fill_comboBox1();
        }
        string[] tablicaloginow = new string[100];
        string jakiUzytkownikMaBycEdytowany = "";
        void fill_comboBox1()
        {

            comboBox1.Items.Add("Administrator");
            comboBox1.Items.Add("Użytkownik");
        }

        public void przekaz(string uzytkownik)
        {
            jakiUzytkownikMaBycEdytowany = uzytkownik;
           
            
        }
        DateTime data;

       
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
