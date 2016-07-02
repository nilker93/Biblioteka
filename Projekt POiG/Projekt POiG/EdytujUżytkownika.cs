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
            string a = textBox4.Text;
            string b = textBox5.Text;
            if (a != b)
            {
                MessageBox.Show("Hasła są niezgodne!");
            }
            else
            {
                if (textBox8.Text.Length != 11)
                {
                    MessageBox.Show("Pesel jest za krótki!");
                }
                else
                {
                    myClass.edytujuzytkownika(jakiUzytkownikMaBycEdytowany, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, uprawnienie, dateTimePicker1.Value.Date, textBox6.Text, textBox7.Text, textBox8.Text);
                    //data = dateTimePicker1.Value.Date;
                    int i;
                    PanelAdministratora add = new PanelAdministratora();
                    this.Hide();
                    add.Show();
                }
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char nl = e.KeyChar;
            if (!Char.IsDigit(nl) && nl != 8)
            {
                e.Handled = true;
            }   
        }

        private void EdytujUżytkownika_Load(object sender, EventArgs e)
        {

        }
    }
}
