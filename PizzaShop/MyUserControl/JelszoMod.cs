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
    public partial class JelszoMod : UserControl
    {
        public JelszoMod()
        {
            InitializeComponent();
        }

        Connection cnt = new Connection();
        string lekerdezes;
        private void btnModositJelsz_Click(object sender, EventArgs e)
        {
            try
            {
                lekerdezes = "select jelszo from felhasznalok where fnev = '" + textFelhaszNevJ.Text + "'";
                DataSet ds = cnt.getData(lekerdezes);
                if (ds.Tables[0].Rows.Count > 0)//ha van találat a lekérdezésre
                {
                    //összehasonlítom a felhasználó által adott letitkosított jelszót az adatbázisban szereplővel
                    if (Hash.SHA5Hash(textJelszoJ.Text) == ds.Tables[0].Rows[0][0].ToString()) 
                    {
                        if (textJelszoUj.Text == textJelszoUjI.Text)
                        {
                            lekerdezes = "UPDATE `felhasznalok` SET `jelszo` = '" + Hash.SHA5Hash(textJelszoUj.Text) + "' WHERE `felhasznalok`.`fnev` = 'admin';";
                            cnt.setData(lekerdezes);
                        }
                        else MessageBox.Show("A kétszer megadott új jelszó nem egyezik meg!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Hibás jelenlegi jelszó!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Hibás felhasználónév!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!  " + ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
