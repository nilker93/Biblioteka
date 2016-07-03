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
    class Book
    {
        public string PobierzDaneDlaId(int id)
        {
            string[] names = new string[100];
            string[] tablicaloginow = new string[100];
            
            string tytul = "";
            
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "select * from books where idk like " + id + ";";
            int i = 0;
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, conDataBase1);
            MySqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                if (myReader1.Read())
                {
                    tytul = myReader1.GetString("tytul");
                }
               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tytul;
        }




        public int pobierzId(string tytul)
        {
            int id1 = 0;
            string id = "0";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query = "select * from books where tytul like '" + tytul + "' ;";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    id = myReader.GetString("idk");

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

          
            return id1;
        }


        public void usunKsiazke(string tytul)
        {
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "delete from books where tytul like '" + tytul + "' ;";

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

        public string[] zapelnijlistbox(string tytul)
        {
            string[] names = new string[100];
            string[] tablicaloginow = new string[100];
            string autor = "";
            string tytul1 = "";
            string DataWydania = "";
            string iloscStron = "";
            string wydawnictwo = "";
            string iloscEgzemblarzy = "";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "select * from books where tytul like '" + tytul + "';";
            int i = 0;
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, conDataBase1);
            MySqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
                    autor = myReader1.GetString("autor");
                    tytul1 = myReader1.GetString("tytul");
                    DataWydania = myReader1.GetString("dataWydania");
                    iloscStron = myReader1.GetString("iloscStron");
                    iloscEgzemblarzy = myReader1.GetString("iloscEgzemblarzy");
                    wydawnictwo = myReader1.GetString("Wydawnictwo");
                    names[0] = "Autor:" + autor;    
                    names[1] = " Tytuł:" + tytul1;
                    names[2] = " Data Wydania:" + DataWydania;
                    names[3] = " Ilość stron:" + iloscStron;
                    names[4] = " \nIlość Egzemblarzy:" + iloscEgzemblarzy;
                    names[5] = " Wydawnictwo:" + wydawnictwo;
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return names;
        }

        public string[] zapelnijcombobox()
        {
            string[] names = new string[100];
            string[] tablicaloginow = new string[100];
            string autor = "";
            string tytul = "";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "select * from books ;";
            int i = 0;
            MySqlConnection conDataBase1 = new MySqlConnection(constring);
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, conDataBase1);
            MySqlDataReader myReader1;
            try
            {
                conDataBase1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
                    autor = myReader1.GetString("autor");
                    tytul = myReader1.GetString("tytul");
                    names[i] = autor + ":" + tytul;
                    tablicaloginow[i] = tytul;
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return names;
        }

        public void edytujKsiazke(string JakaKsiazkeZmienic, string autor, string tytul, string dataWydania, string Wydawnictwo, string iloscStron, string iloscEgzemblarzy)
        {
        /*
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "insert into books values (" + autor + "','" + tytul + "','" + dataWydania + "','" + Wydawnictwo + "','" + iloscStron + "','" + iloscEgzemblarzy + "');";
        */
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "update books set autor='" + autor + "', tytul='" + tytul + "',dataWydania='" + dataWydania + "', Wydawnictwo='" + Wydawnictwo + "', iloscStron='" + iloscStron + "',iloscEgzemblarzy='" + iloscEgzemblarzy + "' where tytul like '" + JakaKsiazkeZmienic + "' ;";

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

        public void dodajKsiazke(int id, string autor, string tytul, string dataWydania, string Wydawnictwo, string iloscStron, string iloscEgzemblarzy)
        {
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "insert into books values (" + id + ",'" + autor + "','" + tytul + "','" + dataWydania + "','" + Wydawnictwo + "','" + iloscStron + "','" + iloscEgzemblarzy + "');";

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
                    id = myReader.GetString("idk");

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