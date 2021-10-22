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
    public partial class TermekHozzaad : UserControl
    {
        Connection cnt = new Connection();
        String lekerdezes;

        public TermekHozzaad()
        {
            InitializeComponent();
            comboBoxKateg.DropDownStyle = ComboBoxStyle.DropDownList;//ne lehessen beleírni a mezőbe, csak kiválasztani
        }

        //form betöltődésekor
        private void TermekHozzaad_Load(object sender, EventArgs e)
        {
            //úgy rakom össze a lekérdezést, hogy minden kategória csak egyszer szerepeljen
            lekerdezes = "select distinct kategoria from termek order by kategoria";
            DataSet ds = cnt.getData(lekerdezes);
            //kategória legördülő feltöltése
            comboBoxKateg.DataSource = ds.Tables[0];
            comboBoxKateg.DisplayMember = "kategoria";
            comboBoxKateg.ValueMember = "kategoria";
        }

        //kiürítő eljárás
        public void Kiurit()
        {
            comboBoxKateg.SelectedIndex = -1;
            textTermekNev.Clear();
            textAr.Clear();
        }

        private void TermekHozzaad_Leave(object sender, EventArgs e)
        {
            Kiurit();
        }

        //Hozzáad gombra kattintás:
        private void btnHozzaad_Click_1(object sender, EventArgs e)
        {
            //ellenőrzöm, hogy nem üres-e a kategória és a termék neve
            if (comboBoxKateg.Text != "" && textTermekNev.Text != "")
            {
                //ellenőrzöm, hogy már van-e ilyen termék
                bool vane = cnt.TermekEll(comboBoxKateg.Text, textTermekNev.Text);                
                if (vane == false)
                {
                    //ellenőrzöm, hogy a megadott ár, nagyobb-e 0-nál és átalakítható-e int-re
                    int szam = -1;
                    bool arEll = int.TryParse(textAr.Text, out szam);
                    if (szam > 0)
                    {
                        try
                        {
                            lekerdezes = "insert into termek (nev,kategoria,ar) values ('" + textTermekNev.Text + "','" + comboBoxKateg.Text + "','" + textAr.Text + "')";
                            cnt.setData(lekerdezes);
                            Kiurit();//Kiürítem a mezőket
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
            else MessageBox.Show("Nem töltött ki minden mezőt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }        
    }
}
