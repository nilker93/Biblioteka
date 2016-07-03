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

        public string[] ZapelnijListboxPozycjami( int isOsoby)
        {
            Book zwroc = new Book();
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=;Convert Zero Datetime=True";
            string Query1 = "select * from wyporzyczanie where ido like " + isOsoby + ";";
            string[] names = new string[100];
            int[] tableid = new int[100];
            string[] tableids = new string[100];
            string id = "0";
            int id1 = 0;
            DateTime data ;
            int i = 0;
            DateTime value = new DateTime(0001, 01, 01);
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, conDataBase1);
            MySqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {


                    tableids[i] = myReader1.GetString("idk");
                        data = myReader1.GetDateTime("data1");
                        if (data == value)
                        {
                            names[i] = "Prośba O Rezerwację:";
                            // MessageBox.Show("Pusta data");
                        }
                        else
                        {
                            names[i] = "Wypożyczona:";
                        }
                    
                   
                    int ksksk;


                                try
                                {
                                    tableid[i] = Int32.Parse(tableids[i]);
                                }

                                catch (FormatException er)
                                {
                                    Console.WriteLine(er.Message);
                                }
                                
                                i++;
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase1.Close();
            int j=0;
            for (j = 0; j < i; j++)
            {
                int podajid = tableid[j];
                string pobierz = zwroc.PobierzDaneDlaId(podajid);
               names[j] += pobierz;

            }
                return names;
        }



        public bool SprawdzCzyKsiazkaJestJuzWyporzyczonaPrzezDanegoUzytkownika( int idKsiazki, int isOsoby)
        {
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "select * from wyporzyczanie where idk like " + idKsiazki + " and ido like " + isOsoby + ";";
            string id = "0";
            int id1 = 0;
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, conDataBase1);
            MySqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
                    id = myReader1.GetString("idw");

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
                return false;
            }

            else
            {
                return true;
            }

        }


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
