using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_POiG
{
    public partial class rejestracja : UserControl
    {
        public rejestracja()
        {
            InitializeComponent();
        }

        DateTime data;

        private void button1_Click(object sender, EventArgs e)
        {
            string u = "user";
            string b = "Free slot";
            string d = "";
            string q = "insert users (ido, imie, nazwisko, login, haslo, adres, uprawnienia, dataUrodzenia, miasto, pesel) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','" + u + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox3.Text + "')";
            //Rejestruj(q);
            this.Hide();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
