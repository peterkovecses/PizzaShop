using DGVPrinterHelper;
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
    public partial class Rendeles : UserControl
    {
        Connection cnt = new Connection();
        String lekerdezes;
        public Rendeles()
        {
            InitializeComponent();
            comboBoxKategR.DropDownStyle = ComboBoxStyle.DropDownList;//ne lehessen beleírni a mezőbe, csak kiválasztani
        }

        //amikor betöltődik a rendelés felület
        private void Rendeles_Load(object sender, EventArgs e)
        {
            kategoriaBeallit();
        }

        public void kategoriaBeallit()
        {
            //úgy rakom össze a lekérdezést, hogy minden kategória csak egyszer szerepeljen
            lekerdezes = "select distinct kategoria from termek";
            DataSet ds = cnt.getData(lekerdezes);
            //kategória legördülő feltöltése
            comboBoxKategR.DataSource = ds.Tables[0];
            comboBoxKategR.DisplayMember = "kategoria";
            comboBoxKategR.ValueMember = "kategoria";
            //a kiválasztás módja: egész sor
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //a comboBoxKategR-ben kíválasztott kategória elemeinek megjelenítése a listBoxKateg dobozban
        private void comboBoxKategR_SelectedIndexChanged(object sender, EventArgs e)
        {            
            termekFrissit();
        }
        
        public void termekFrissit()
        {
        //visszaállítom a keresőt
        textKereses.Text = "Keresés...";
        lekerdezes = "select nev from termek where kategoria ='" + comboBoxKategR.Text + "' order by nev";
        TermekLista(lekerdezes);
        }

        //ha írok a keresőbe
        private void textKereses_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lekerdezes = "select nev from termek where kategoria ='" + comboBoxKategR.Text + "' and nev like '" + textKereses.Text + "%' order by nev";
                TermekLista(lekerdezes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TermekLista(string lekerdezes)
        {
            try
            {
                listBoxKateg.Items.Clear();
                DataSet ds = cnt.getData(lekerdezes);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBoxKateg.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ha belekattintok a keresés mezőbe
        private void textKereses_Click(object sender, EventArgs e)
        {
            textKereses.ResetText();//eltűnik a keresés felirat és el tudom kezdeni a keresést beleírással
        }

        //ha kiválasztom a terméket
        private void listBoxKateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            numUpDownMenny.Text = "1";
            String szoveg = listBoxKateg.GetItemText(listBoxKateg.SelectedItem);//a kiválasztott elem nevének mentése
            textTermekNevR.Text = szoveg;//megjelenítem a kiválasztott termék nevét
            lekerdezes = "select ar from termek where nev = '"+szoveg+"'";//lekérdezem a kiválasztott termék árát
            DataSet ds = cnt.getData(lekerdezes);
            try
            {
                if (textTermekNevR.Text != "")
                {
                    textArR.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!x  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //ha van kiválasztott termék (mert kosárba rakás után törlöm a kiválasztást és az is kiválasztott elem változás)
            if (textTermekNevR.Text != "")
            {
                textOsszeg.Text = (Int64.Parse(textArR.Text)).ToString();
            }
        }

        //ha változtatok a mennyiségen
        private void numUpDownMenny_ValueChanged(object sender, EventArgs e)
        {
            Int64 db = Int64.Parse(numUpDownMenny.Value.ToString());
            if (textArR.Text != "")
            {
                Int64 egysegar = Int64.Parse(textArR.Text);
                textOsszeg.Text = (db * egysegar).ToString();
            }
        }

        protected int a, vegosszeg = 0;    

        //kosárba gombra kattintás
        private void btnKosarba_Click(object sender, EventArgs e)
        {
            //ha van kiválasztott termék és a kosárba gombra kattintok
            if (textOsszeg.Text != "0" && textOsszeg.Text != "")
            {
                a = dataGridView1.Rows.Add();
                dataGridView1.Rows[a].Cells[0].Value = textTermekNevR.Text;
                dataGridView1.Rows[a].Cells[1].Value = textArR.Text;
                dataGridView1.Rows[a].Cells[2].Value = numUpDownMenny.Value;
                dataGridView1.Rows[a].Cells[3].Value = textOsszeg.Text;
                vegosszeg += int.Parse(textOsszeg.Text);
                labelVegOssz.Text = vegosszeg + " Ft";
                textTermekNevR.Clear();
                textArR.Clear();
                numUpDownMenny.Value = 1;
                textOsszeg.Clear();
                listBoxKateg.ClearSelected();
            }
            else 
            {
                MessageBox.Show("Nincs kiválasztott termék!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.ClearSelection();//szüntesse meg a sor kijelölést
        }        

        int osszeg;
        //ha a táblázat cellájára kattintok
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //amelyik sorra kattintunk, annak a tételnek az összeg értékét nyerjük ki
                osszeg = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ha az eltávolít gombra kattintok
        private void btnEltavolit_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);//sor törlése
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.ClearSelection();
            //alábbi kóddal ellenőriztem az összeget
            //MessageBox.Show("Összeg: " + osszeg, "Ellenőrzés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            vegosszeg -= osszeg;
            osszeg = 0;
            labelVegOssz.Text = vegosszeg + " Ft";
            dataGridView1.ClearSelection();//szüntesse meg a sor kijelölést
        }

        //nyomtat gombra kattintás
        private void btnNyomtat_Click(object sender, EventArgs e)
        {
            //ha van kiválasztott termék (nem 0 a sorainak száma)
            if (dataGridView1.RowCount != 0)
            {
                //Adatok mentése az Adatbázisba

                //megszerzem a következő rendelésazonosítót
                lekerdezes = "SELECT `auto_increment` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'pizza' AND table_name = 'forgalom'";
                DataSet ds = cnt.getData(lekerdezes);
                string rendelesAzon = ds.Tables[0].Rows[0][0].ToString();

                //listába teszem a dataGridView sorok adatmezőiből alkotott sql parancsot (ezek az adatsorok kerül majd bele a rendelések tábla soraiba)
                List<string> dgvL = new List<string>();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string egySor = "INSERT INTO rendelesek (`rendeles_azon`, `termek`, `egysegar`, `mennyiseg`, `osszeg`) VALUES ('" + rendelesAzon + "', '" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[1].Value + "', '" + dataGridView1.Rows[i].Cells[2].Value + "', '" + dataGridView1.Rows[i].Cells[3].Value + "');";
                    dgvL.Add(egySor);
                }

                //a lista tartalmát beleteszem egy string-be
                string dgvString = dgvL.Aggregate((i, j) => i + j).ToString();                

                //elmentem a rendelést az adatbázisba (a forgalom és a rendelesek táblába egyszerre)
                lekerdezes = "insert into forgalom (ido,osszeg) values ('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + labelVegOssz.Text + "');" + dgvString;
                cnt.setData(lekerdezes);

                //Fájlba írás

                //kiolvasom a forgalom tábla tartalmát az adatbázisból (a fájlbaíráshoz)
                lekerdezes = "select * from forgalom";
                ds = cnt.getData(lekerdezes);               
                //fájlba írom a tábla tartalmát
                if (ds.Tables.Count > 0)//ha van adat
                {
                    try
                    {                        
                        // fájlnév megadása
                        string filename = "forgalom.xml";
                        // FileStream létrehozása
                        System.IO.FileStream stream = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                        // XmlTextWriter létrehozása
                        System.Xml.XmlTextWriter xmlWriter = new System.Xml.XmlTextWriter(stream, System.Text.Encoding.UTF8);
                        //írás
                        ds.WriteXml(xmlWriter);
                        //bezárások
                        xmlWriter.Close();
                        stream.Close();

                        //Nyomtatás

                        DGVPrinter nyomtat = new DGVPrinter();
                        nyomtat.Title = "Bizonylat";
                        nyomtat.SubTitle = string.Format("Rendelés azonosító: {0}  Rendelés ideje: {1}", rendelesAzon, DateTime.Now);
                        nyomtat.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                        nyomtat.PageNumbers = true;//oldalszám kiíratása
                        nyomtat.PageNumberInHeader = false;
                        nyomtat.PorportionalColumns = true;
                        nyomtat.HeaderCellAlignment = StringAlignment.Near;
                        nyomtat.Footer = "Végösszeg: " + labelVegOssz.Text;
                        nyomtat.FooterSpacing = 20;
                        nyomtat.PrintDataGridView(dataGridView1);                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }  
                else
                {
                    MessageBox.Show("Nincs adat! A fájlbaírás nem sikerült!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                osszeg = 0;
                dataGridView1.Rows.Clear();
                vegosszeg = 0;
                labelVegOssz.Text = "0";
                listBoxKateg.ClearSelected();
                kategoriaBeallit();
            }
            else MessageBox.Show("Nincs termék a kosárban!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }
    }
}
