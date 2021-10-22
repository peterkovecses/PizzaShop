using System;
using System.Collections.Generic;
using System.Data;//be kellett emelni
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//be kellett emelni
//előtte még hozzá kellett adni a MySqlData bővítményt
//projektre kattintok, add reference, extensions, MySqlData
using MySql.Data.MySqlClient;

namespace PizzaShop
{
    class Connection
    {
        protected MySqlConnection GetMySqlConnection()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "data source=127.0.0.1;username=root;password=; database=pizza;";
            return con;
        }

        //olvasás az adatbázisból
        public DataSet getData(String lekerdezes)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection con = GetMySqlConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = lekerdezes;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);                
                da.Fill(ds);
                return ds;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Hiba az adatbázis kapcsolatban!  " + e.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ds;
            }
        }

        //írás az adatbázisba
        public void setData(String lekerdezes)
        {
            try
            {
                MySqlConnection con = GetMySqlConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = lekerdezes;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sikeres adatfeldolgozás!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Hiba az adatbázis kapcsolatban!  " + e.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ellenőrő függvény
        //azt ellenőrzi, hogy az adott kategórián belül már van-e ilyen nevű termék
        //új termék felvitelekor és módosításkor is használjuk
        public bool TermekEll(string kategoria, string termekNev)
        {
            //alapértelmezett, hogy nincs egyezés
            bool vane = false;
            List<string> termekLista = new List<string>();
            Connection cnt = new Connection();
            string lekerdezes = "select nev from termek where kategoria ='" + kategoria + "'";

            try
            {
                DataSet ds = cnt.getData(lekerdezes);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    termekLista.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (string item in termekLista)
            {
                if (item == termekNev)
                {
                    vane = true;
                }
            }    
            return vane;
        }
    }
}
