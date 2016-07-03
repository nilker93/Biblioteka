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
    class User
    {


        public int pobierzId(string login)
        {
            int id1 = 0;
            string id = "0";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query = "select * from users where login like '" + login + "' ;";

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



        public string[] tableoflogin = new string[100];

        public User(string[] names)
        {
            this.tableoflogin = names;
        }
        public User()
        {
            
        }

        public void edytujuzytkownika(string jakiLoginZmienic, string imie, string nazwisko, string login, string haslo, int uprawnienia, DateTime date, string miasto, string adres, string pesel)
        {

            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "update users set imie='" + imie + "', nazwisko='" + nazwisko + "',login='" + login + "', haslo='" + haslo + "', uprawnienia='" + uprawnienia + "',dataUrodzenia='" + date + "',miasto='" + miasto + "',adres='" + adres + "',pesel='" + pesel + "' where login like '" + jakiLoginZmienic + "' ;";

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
        /*
        public void czyLoginIstnieje(string login)
        {
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "SELECT COUNT(*) FROM login WHERE username='" + login + "' ;";
            if (Query1.ToString != 0)
            {

            }
            
        }
         */
        

        public void usunuzytkownika(string login)
        {
           
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "delete from users where login like '" + login + "' ;";
           
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

        public string[] pobierzWszystkieLoginy()
        {
            
            string[] tablicaloginow = new string[100];
           
            string login = "";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "select * from users ;";
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
                  
                    login = myReader1.GetString("login");
            
                    tablicaloginow[i] = login;
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



            return tablicaloginow;
        }

        public string[] zapelnijcombobox()
        {
            string[] names = new string[100];
            string[] tablicaloginow = new string[100];
            string imie = "";
            string nazwisko = "";
            string login = "";
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "select * from users ;";
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
                    imie = myReader1.GetString("imie");
                    nazwisko = myReader1.GetString("nazwisko");
                    login = myReader1.GetString("login");
                    names[i] = imie + " " + nazwisko + ":" + login;
                    tablicaloginow[i] = login;
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            

            
            return names;
        }



        public void dodajUzytkownika(int id, string imie, string nazwisko, string login, string haslo, int uprawnienia, DateTime date, string miasto , string adres, string pesel)
        {
            string constring = "SERVER=localhost;DATABASE=biblioteka;UID=root;password=";
            string Query1 = "insert into users values (" + id + ",'" + imie + "','" + nazwisko + "','" + login + "','" + haslo + "','" + uprawnienia + "','" + date + "','" + miasto + "','" + adres + "','" + pesel + "');";

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
                int id1=0;
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
                        id = myReader.GetString("ido");
                        
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

                if(id1 == 0)
                {
                    id1=1;
                }

                else{
                    id1++;
                }
                return id1;
        }
    /*  
        void dodajcos()
        {

            try
            {
                openCon();
                mcd = new MySqlCommand(q, myconn);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Użutkownik został dodany");
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd. Nie dodano urzytkownika");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                closeCon();
            }

        }
      */
    }
}
