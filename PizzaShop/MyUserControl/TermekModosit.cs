using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop.MyUserControl
{
    public partial class TermekModosit : UserControl
    {
        Connection cnt = new Connection();
        String lekerdezes;
        String nev;
        bool vane = false;
        public TermekModosit()
        {
            InitializeComponent();
        }

        //amikor betöltődik a termékmódosító felület
        private void TermekModosit_Load(object sender, EventArgs e)
        {            
            AdatBetoltes();
            //a kiválasztás módja: egész sor
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public void AdatBetoltes()
        {
            try
            {
                lekerdezes = "select * from termek order by nev";
                DataSet ds = cnt.getData(lekerdezes);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ha írok a keresőmezőbe
        private void textKeresesM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lekerdezes = "select * from termek where nev like '" + textKeresesM.Text + "%'";
                DataSet ds = cnt.getData(lekerdezes);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ClearSelection();//szüntesse meg a sor kijelölést
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ha belekattintok a keresés mezőbe
        private void textKeresesM_Click(object sender, EventArgs e)
        {
            textKeresesM.ResetText();//eltűnik a keresés felirat és el tudom kezdeni a keresést beleírással
            textKategM.ResetText();
            textTermekNevM.ResetText();
            textArM.ResetText();
            dataGridView1.ClearSelection();
        }

        int azon;
        //ha belekattintok egy cellába
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            azon = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            nev = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            String kategoria = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int ar = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            textKategM.Text = kategoria;
            textTermekNevM.Text = nev;
            textArM.Text = ar.ToString();
        }

        //ha a módosít gombra kattintok
        private void btnModosit_Click(object sender, EventArgs e)
        {
            //ha van kiválasztott termék
            if (textKategM.Text != "")
            {
                //ha a beírt új terméknév nem üres
                if (textTermekNevM.Text != "")
                {
                    //ha változott a termék neve
                    if (textTermekNevM.Text != nev)
                    {
                        //ellenőrzöm, hogy már van-e ilyen nevű termék
                        vane = cnt.TermekEll(textKategM.Text, textTermekNevM.Text);
                    }                    
                    if (vane == false)
                    {
                        //ellenőrzöm, hogy a megadott ár, az átalakítható-e int-re
                        int szam = -1;
                        bool arEll = int.TryParse(textArM.Text, out szam);
                        if (szam > 0)
                        {
                            try
                            {
                                lekerdezes = "update termek set nev = '" + textTermekNevM.Text + "', kategoria = '" 
                                    + textKategM.Text + "', ar = " + textArM.Text + " where azon = " + azon + "";
                                cnt.setData(lekerdezes);
                                AdatBetoltes();//hogy frissítse a táblázatot
                                textTermekNevM.Clear();
                                textKategM.Clear();
                                textArM.Clear();
                                textKeresesM.Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else MessageBox.Show("Nem megfelelő ár!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Már van ilyen nevű termék!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show("Nem írt be terméknevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Nincs kiválasztott termék!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ha a töröl gombra kattintok
        private void btnTorol_Click(object sender, EventArgs e)
        {
            //ha van kiválasztott termék
            if (textKategM.Text != "")
            {
                if (MessageBox.Show("Törli a terméket?", "Figyelmeztetés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
                    {
                        lekerdezes = "delete from termek where azon ='" + azon + "'";
                        cnt.setData(lekerdezes);
                        AdatBetoltes();
                        textKeresesM.Clear();
                        textTermekNevM.Clear();
                        textKategM.Clear();
                        textArM.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }                
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott termék!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
    }
}
