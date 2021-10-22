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
    public partial class Forgalom : UserControl
    {
        Connection cnt = new Connection();
        String lekerdezes;
        String rendelesAzon;
        public Forgalom()
        {            
            InitializeComponent();
            //a kiválasztás módja: egész sor
            dataGridViewF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewR.AllowUserToAddRows = false;//ezzel védem ki az üres sort a dataGridView végén
        }

        //az intervallumnak megfelelő rendelések betöltése
        public void ForgalomBetoltes()
        {
            try
            {
                lekerdezes = "select * from forgalom where ido between '" + dTPTol.Value.ToString("yyyy-MM-dd") + "' and '" + dTPIg.Value.AddDays(1).ToString("yyyy-MM-dd") + "'";//az -ighez azért adok hozzá egy napot, mert adott nap 0 óra 0 percig nézi
                DataSet ds = cnt.getData(lekerdezes);
                dataGridViewF.DataSource = ds.Tables[0];
                int forgalom = 0;
                for (int i = 0; i < dataGridViewF.Rows.Count; i++)
                {
                    forgalom = forgalom + int.Parse(dataGridViewF.Rows[i].Cells[2].Value.ToString());
                }                
                //időszak össz forgalmának kiíratása
                labelVegOsszF.Text = forgalom.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //amikor a főmenü forgalom menüpontjára kattintok visszaállít az alapértelmezett időintervallumra
        public void IdoszakVisszaallit()
        {
            dTPTol.ResetText();
            dTPIg.ResetText();
        }

        //ha változik a kiválasztott rendelés (itt töltöm be az adatokat a rendelés részletek mezőbe)
        private void dataGridViewF_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewF.SelectedCells.Count > 0)
            {
                //megszerzem a kiválasztott sor rendelésazonosítóját
                int selectedrowindex = dataGridViewF.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewF.Rows[selectedrowindex];
                rendelesAzon = Convert.ToString(selectedRow.Cells[0].Value);
                try
                {
                    lekerdezes = "select termek, egysegar, mennyiseg, osszeg  from rendelesek where rendeles_azon = '" + rendelesAzon + "'";
                    DataSet ds = cnt.getData(lekerdezes);
                    dataGridViewR.DataSource = ds.Tables[0];
                    dataGridViewR.ClearSelection();//szüntesse meg a sor kijelölést
                    int vegOsszeg = 0;
                    if (dataGridViewR.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridViewR.Rows.Count; i++)
                        {
                            //összeadom a sorok összeg értékét a végösszeghez
                            vegOsszeg = vegOsszeg + int.Parse(dataGridViewR.Rows[i].Cells[3].Value.ToString());
                        }
                    }                    
                    labelVegOsszR.Text = vegOsszeg.ToString();
                }                
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt!x  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }

        }

        //ha a mínusz gombra kattintok
        private void btnTorol_Click(object sender, EventArgs e)
        {
            //ha van kijelölt sor
            if (dataGridViewF.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Biztosan törli a rendelést?", "Figyelmeztetés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    lekerdezes = "delete from forgalom where rendeles_azon ='" + rendelesAzon + "'";
                    cnt.setData(lekerdezes);
                    //frissítem a dataGridView tartalmát
                    ForgalomBetoltes();
                    //Felülírom az XML fájlomat a friss adatokkal
                    //kiolvasom a forgalom tábla tartalmát az adatbázisból
                    DataSet ds = cnt.getData(lekerdezes);
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
                }                
            }
            else MessageBox.Show("Nincs törölhető kijelölt rendelés!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-tól beállítása
        private void dTPTol_ValueChanged(object sender, EventArgs e)
        {
            ForgalomBetoltes();
        }

        //-ig beállítása
        private void dTPIg_ValueChanged(object sender, EventArgs e)
        {
            ForgalomBetoltes();
        }

        //bizonylat újranyomtatása
        private void btnNyomtat_Click(object sender, EventArgs e)
        {
            //nyomtatás
            DGVPrinter nyomtat = new DGVPrinter();
            nyomtat.Title = "Bizonylat";

            //megszerzem a kiválasztott rendelés idejét
            int selectedrowindex = dataGridViewF.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewF.Rows[selectedrowindex];
            string rendelesIdeje = Convert.ToString(selectedRow.Cells[1].Value);

            nyomtat.SubTitle = string.Format("Rendelés azonosító: {0}  Rendelés ideje: {1}", rendelesAzon, rendelesIdeje);
            nyomtat.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            nyomtat.PageNumbers = true;//oldalszám kiíratása
            nyomtat.PageNumberInHeader = false;
            nyomtat.PorportionalColumns = true;
            nyomtat.HeaderCellAlignment = StringAlignment.Near;
            nyomtat.Footer = "Végösszeg: " + labelVegOsszR.Text;
            nyomtat.FooterSpacing = 20;
            nyomtat.PrintDataGridView(dataGridViewR);
        }
    }
}
