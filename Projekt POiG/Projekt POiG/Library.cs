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
    class Library
    {
        public void WniosekORezerwacje(int idWniosku, int idKsiazki, int isOsoby)
        {
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "insert into wyporzyczanie values (" + idWniosku + ",'" + idKsiazki + "','" + isOsoby + "','');";

            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, conDataBase1);
            MySqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public int pobierzMaksymalneId(string constring, string Query)
        {
            int id1 = 0;
            string id = "0";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    id = myReader.GetString("idw");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                id1 = Int32.Parse(id);
            }

            catch (FormatException er)
            {
                Console.WriteLine(er.Message);
            }

            if (id1 == 0)
            {
                id1 = 1;
            }

            else
            {
                id1++;
            }
            return id1;
        }


    }
}
