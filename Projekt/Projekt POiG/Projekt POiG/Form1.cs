using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projekt_POiG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
                bool sUprawnienia = false;
                string[] tab = new string[16];
                string Query = "select * from users WHERE haslo like'" + textBox2.Text + "' and login like '" + textBox1.Text + "' ;";
                MySqlConnection myConn = new MySqlConnection(constring);

                MySqlDataReader myReader;
                MySqlCommand cmdDataBase = new MySqlCommand(Query, myConn);
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                int licz = 0;
                while (myReader.Read())
                {
                    licz = licz + 1;
                    // sUprawnienia = myReader.GetString("uprawnienia");
                    sUprawnienia = myReader.GetBoolean("uprawnienia");
                    MessageBox.Show(tab[0]);
                    /*
                    for (int i = 8, j = 1; j < 16; i++, j++)
                    {
                        tab[j] = myReader.GetString(i);
                    }
                    */
                }
                if (licz == 1)
                {
                    if (sUprawnienia == true)
                    {
                        PanelAdministratora admin = new PanelAdministratora();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        PanelUzytkownika user = new PanelUzytkownika();
                        this.Hide();
                        user.Show();
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            użytkownicy form2 = new użytkownicy();
            this.Hide();
            form2.Show();
        }
    }
}
