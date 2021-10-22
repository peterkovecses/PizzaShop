using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        Connection cnt = new Connection();
        String lekerdezes;

        //bejelentkezés gomb:
        private void btnBejelentk_Click(object sender, EventArgs e)
        {
            try
            {                
                lekerdezes = "select * from felhasznalok where fnev = '" + textFelhNev.Text + "' and jelszo = '" + Hash.SHA5Hash(textJelszo.Text) + "'"; 
                DataSet ds = cnt.getData(lekerdezes);
                if (ds.Tables[0].Rows.Count > 0)//ha van találat a lekérdezésre
                {
                    if (Hash.SHA5Hash(textJelszo.Text) == ds.Tables[0].Rows[0][2].ToString())//a rows-ból a 0 a sor indexe az 2 a cella indexe a soron belül
                    {
                        Menu mn = new Menu(textFelhNev.Text);
                        mn.Show();
                        this.Hide();
                    }
                }
                else MessageBox.Show("Hibás felhasználónév, vagy jelszó!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVendeg_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu("vendeg");
            mn.Show();
            this.Hide();
        }

        
        private void textJelszo_KeyDown(object sender, KeyEventArgs e)
        {
            //ha entert ütök
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    lekerdezes = "select * from felhasznalok where fnev = '" + textFelhNev.Text + "' and jelszo = '" + Hash.SHA5Hash(textJelszo.Text) + "'";
                    DataSet ds = cnt.getData(lekerdezes);
                    if (ds.Tables[0].Rows.Count > 0)//ha van találat a lekérdezésre
                    {
                        if (Hash.SHA5Hash(textJelszo.Text) == ds.Tables[0].Rows[0][2].ToString())//a rows-ból a 0 a sor indexe az 2 a cella indexe a soron belül
                        {
                            Menu mn = new Menu(textFelhNev.Text);
                            mn.Show();
                            this.Hide();
                        }
                    }
                    else MessageBox.Show("Hibás felhasználónév, vagy jelszó!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
