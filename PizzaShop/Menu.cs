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
    public partial class Menu : Form
    {        
        public Menu()
        {
            InitializeComponent();     
        }

        public Menu(String felhasznalo)
        {
            InitializeComponent();
            //ha vendégként jelentkezem be, elrejtem az adminisztrátori jogosultsághoz kötött gombokat
            if (felhasznalo == "vendeg")
            {
                btnTermHoz.Hide();
                btnTermMod.Hide();
                btnJelszMod.Hide();
                btnForgalom.Hide();
            }
        }

        //amikor betöltődik a menü:
        private void Menu_Load(object sender, EventArgs e)
        {
            rendeles1.Visible = false;//láthatatlanra állítjuk a rendelés felületet
            termekHozzaad1.Visible = false;
            termekModosit1.Visible = false;
            jelszoMod1.Visible = false;
            forgalom1.Visible = false;
        }

        //kilépés gomb kattintás:
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //kijelentkezés gomb kattintás:
        private void btnKijel_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            //bejelentkezés oldal mutatása:
            f1.Show();
        }

        //termék hozzáadása gomb kattintás:
        private void btnTermHoz_Click(object sender, EventArgs e)
        {
            termekHozzaad1.Visible = true;//láthatóvá teszi a felületet
            termekHozzaad1.BringToFront();
        }     

        //rendelés gombra kattintás:
        private void btnRendel_Click(object sender, EventArgs e)
        {
            udvozles1.SendToBack();
            rendeles1.Visible = true;//láthatóvá teszi a rendelés felületet
            rendeles1.BringToFront();
            //frissítem a termékeket, mert közben lehet, hogy adtam hozzá újat
            rendeles1.termekFrissit();
        }

        //termék módosítás gombra kattintás
        private void btnTermMod_Click(object sender, EventArgs e)
        {
            termekModosit1.Visible = true;
            termekModosit1.BringToFront();
            /*frissítem a módosító felület terméklistáját, arra az esetre, ha betöltődés óta 
            (belépés után betölt automatikusan, de nincs előre hozva amíg rá nem kattintok a módosítás gombbra)
            vittem fel új terméket, és hogy az is rajta legyen a listán.
            a módosító user control eljárását hívtam meg a frissítéshez*/
            termekModosit1.AdatBetoltes();
        }

        //jelszó módosítás gombra kattintás
        private void btnJelszMod_Click(object sender, EventArgs e)
        {
            jelszoMod1.Visible = true;
            jelszoMod1.BringToFront();
        }

        //forgalom gombra kattintás
        private void btnForgalom_Click(object sender, EventArgs e)
        {
            forgalom1.Visible = true;
            forgalom1.BringToFront();
            //meghívom a user control eljárását a forgalom időszakának visszaállításához
            forgalom1.IdoszakVisszaallit();
            //meghívom a user control eljárását a forgalom adatok betöltéséhez
            forgalom1.ForgalomBetoltes();
        }        
    }
}
