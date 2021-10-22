
namespace PizzaShop
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnForgalom = new System.Windows.Forms.Button();
            this.btnJelszMod = new System.Windows.Forms.Button();
            this.btnKijel = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnTermMod = new System.Windows.Forms.Button();
            this.btnTermHoz = new System.Windows.Forms.Button();
            this.btnRendel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forgalom1 = new PizzaShop.MyUserControl.Forgalom();
            this.jelszoMod1 = new PizzaShop.MyUserControl.JelszoMod();
            this.rendeles1 = new PizzaShop.MyUserControl.Rendeles();
            this.termekModosit1 = new PizzaShop.MyUserControl.TermekModosit();
            this.udvozles1 = new PizzaShop.MyUserControl.Udvozles();
            this.termekHozzaad1 = new PizzaShop.MyUserControl.TermekHozzaad();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnForgalom);
            this.panel1.Controls.Add(this.btnJelszMod);
            this.panel1.Controls.Add(this.btnKijel);
            this.panel1.Controls.Add(this.btnKilep);
            this.panel1.Controls.Add(this.btnTermMod);
            this.panel1.Controls.Add(this.btnTermHoz);
            this.panel1.Controls.Add(this.btnRendel);
            this.panel1.Location = new System.Drawing.Point(1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 571);
            this.panel1.TabIndex = 0;
            // 
            // btnForgalom
            // 
            this.btnForgalom.BackColor = System.Drawing.Color.Red;
            this.btnForgalom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnForgalom.ForeColor = System.Drawing.Color.White;
            this.btnForgalom.Location = new System.Drawing.Point(11, 257);
            this.btnForgalom.Name = "btnForgalom";
            this.btnForgalom.Size = new System.Drawing.Size(180, 60);
            this.btnForgalom.TabIndex = 7;
            this.btnForgalom.Text = "Forgalom";
            this.btnForgalom.UseVisualStyleBackColor = false;
            this.btnForgalom.Click += new System.EventHandler(this.btnForgalom_Click);
            // 
            // btnJelszMod
            // 
            this.btnJelszMod.BackColor = System.Drawing.Color.Firebrick;
            this.btnJelszMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJelszMod.ForeColor = System.Drawing.Color.White;
            this.btnJelszMod.Location = new System.Drawing.Point(12, 333);
            this.btnJelszMod.Name = "btnJelszMod";
            this.btnJelszMod.Size = new System.Drawing.Size(180, 60);
            this.btnJelszMod.TabIndex = 6;
            this.btnJelszMod.Text = "Jelszó módosítása";
            this.btnJelszMod.UseVisualStyleBackColor = false;
            this.btnJelszMod.Click += new System.EventHandler(this.btnJelszMod_Click);
            // 
            // btnKijel
            // 
            this.btnKijel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnKijel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKijel.ForeColor = System.Drawing.Color.White;
            this.btnKijel.Location = new System.Drawing.Point(14, 410);
            this.btnKijel.Name = "btnKijel";
            this.btnKijel.Size = new System.Drawing.Size(180, 60);
            this.btnKijel.TabIndex = 5;
            this.btnKijel.Text = "Kijelentkezés";
            this.btnKijel.UseVisualStyleBackColor = false;
            this.btnKijel.Click += new System.EventHandler(this.btnKijel_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilep.ForeColor = System.Drawing.Color.White;
            this.btnKilep.Location = new System.Drawing.Point(11, 488);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(180, 60);
            this.btnKilep.TabIndex = 4;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = false;
            this.btnKilep.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnTermMod
            // 
            this.btnTermMod.BackColor = System.Drawing.Color.Red;
            this.btnTermMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTermMod.ForeColor = System.Drawing.Color.White;
            this.btnTermMod.Location = new System.Drawing.Point(11, 179);
            this.btnTermMod.Name = "btnTermMod";
            this.btnTermMod.Size = new System.Drawing.Size(180, 60);
            this.btnTermMod.TabIndex = 2;
            this.btnTermMod.Text = "Termék módosítása";
            this.btnTermMod.UseVisualStyleBackColor = false;
            this.btnTermMod.Click += new System.EventHandler(this.btnTermMod_Click);
            // 
            // btnTermHoz
            // 
            this.btnTermHoz.BackColor = System.Drawing.Color.Red;
            this.btnTermHoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTermHoz.ForeColor = System.Drawing.Color.White;
            this.btnTermHoz.Location = new System.Drawing.Point(11, 102);
            this.btnTermHoz.Name = "btnTermHoz";
            this.btnTermHoz.Size = new System.Drawing.Size(180, 60);
            this.btnTermHoz.TabIndex = 1;
            this.btnTermHoz.Text = "Termék hozzáadása";
            this.btnTermHoz.UseVisualStyleBackColor = false;
            this.btnTermHoz.Click += new System.EventHandler(this.btnTermHoz_Click);
            // 
            // btnRendel
            // 
            this.btnRendel.BackColor = System.Drawing.Color.Red;
            this.btnRendel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRendel.ForeColor = System.Drawing.Color.White;
            this.btnRendel.Location = new System.Drawing.Point(11, 24);
            this.btnRendel.Name = "btnRendel";
            this.btnRendel.Size = new System.Drawing.Size(180, 60);
            this.btnRendel.TabIndex = 0;
            this.btnRendel.Text = "Rendelés";
            this.btnRendel.UseVisualStyleBackColor = false;
            this.btnRendel.Click += new System.EventHandler(this.btnRendel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.forgalom1);
            this.panel2.Controls.Add(this.jelszoMod1);
            this.panel2.Controls.Add(this.rendeles1);
            this.panel2.Controls.Add(this.termekModosit1);
            this.panel2.Controls.Add(this.udvozles1);
            this.panel2.Controls.Add(this.termekHozzaad1);
            this.panel2.Location = new System.Drawing.Point(198, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 571);
            this.panel2.TabIndex = 1;
            // 
            // forgalom1
            // 
            this.forgalom1.BackColor = System.Drawing.Color.White;
            this.forgalom1.Location = new System.Drawing.Point(0, 0);
            this.forgalom1.Name = "forgalom1";
            this.forgalom1.Size = new System.Drawing.Size(800, 571);
            this.forgalom1.TabIndex = 5;
            // 
            // jelszoMod1
            // 
            this.jelszoMod1.BackColor = System.Drawing.Color.White;
            this.jelszoMod1.Location = new System.Drawing.Point(0, 0);
            this.jelszoMod1.Name = "jelszoMod1";
            this.jelszoMod1.Size = new System.Drawing.Size(800, 571);
            this.jelszoMod1.TabIndex = 4;
            // 
            // rendeles1
            // 
            this.rendeles1.BackColor = System.Drawing.Color.White;
            this.rendeles1.Location = new System.Drawing.Point(3, 0);
            this.rendeles1.Name = "rendeles1";
            this.rendeles1.Size = new System.Drawing.Size(800, 571);
            this.rendeles1.TabIndex = 2;
            // 
            // termekModosit1
            // 
            this.termekModosit1.BackColor = System.Drawing.Color.White;
            this.termekModosit1.Location = new System.Drawing.Point(0, 0);
            this.termekModosit1.Name = "termekModosit1";
            this.termekModosit1.Size = new System.Drawing.Size(800, 571);
            this.termekModosit1.TabIndex = 3;
            // 
            // udvozles1
            // 
            this.udvozles1.BackColor = System.Drawing.Color.White;
            this.udvozles1.Location = new System.Drawing.Point(3, 0);
            this.udvozles1.Name = "udvozles1";
            this.udvozles1.Size = new System.Drawing.Size(800, 571);
            this.udvozles1.TabIndex = 0;
            // 
            // termekHozzaad1
            // 
            this.termekHozzaad1.BackColor = System.Drawing.Color.White;
            this.termekHozzaad1.Location = new System.Drawing.Point(0, 0);
            this.termekHozzaad1.Name = "termekHozzaad1";
            this.termekHozzaad1.Size = new System.Drawing.Size(800, 571);
            this.termekHozzaad1.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1000, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRendel;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnTermMod;
        private System.Windows.Forms.Button btnTermHoz;
        private System.Windows.Forms.Button btnKijel;
        private MyUserControl.Udvozles udvozles1;
        private MyUserControl.Rendeles rendeles1;
        private MyUserControl.TermekHozzaad termekHozzaad1;
        private MyUserControl.TermekModosit termekModosit1;
        private System.Windows.Forms.Button btnJelszMod;
        private MyUserControl.JelszoMod jelszoMod1;
        private System.Windows.Forms.Button btnForgalom;
        private MyUserControl.Forgalom forgalom1;
    }
}