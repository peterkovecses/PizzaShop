
namespace PizzaShop.MyUserControl
{
    partial class TermekHozzaad
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.textAr = new System.Windows.Forms.TextBox();
            this.textTermekNev = new System.Windows.Forms.TextBox();
            this.comboBoxKateg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnHozzaad);
            this.groupBox1.Controls.Add(this.textAr);
            this.groupBox1.Controls.Add(this.textTermekNev);
            this.groupBox1.Controls.Add(this.comboBoxKateg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(41, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 423);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új termék létrehozása";
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.BackColor = System.Drawing.Color.Green;
            this.btnHozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHozzaad.ForeColor = System.Drawing.Color.White;
            this.btnHozzaad.Location = new System.Drawing.Point(393, 342);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(162, 57);
            this.btnHozzaad.TabIndex = 16;
            this.btnHozzaad.Text = "Hozzáadás";
            this.btnHozzaad.UseVisualStyleBackColor = false;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click_1);
            // 
            // textAr
            // 
            this.textAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textAr.Location = new System.Drawing.Point(153, 280);
            this.textAr.Name = "textAr";
            this.textAr.Size = new System.Drawing.Size(402, 30);
            this.textAr.TabIndex = 15;
            // 
            // textTermekNev
            // 
            this.textTermekNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textTermekNev.Location = new System.Drawing.Point(153, 191);
            this.textTermekNev.Name = "textTermekNev";
            this.textTermekNev.Size = new System.Drawing.Size(402, 30);
            this.textTermekNev.TabIndex = 14;
            // 
            // comboBoxKateg
            // 
            this.comboBoxKateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKateg.FormattingEnabled = true;
            this.comboBoxKateg.Location = new System.Drawing.Point(153, 104);
            this.comboBoxKateg.Name = "comboBoxKateg";
            this.comboBoxKateg.Size = new System.Drawing.Size(402, 33);
            this.comboBoxKateg.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(150, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(150, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Termék neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(150, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kategória";
            // 
            // TermekHozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "TermekHozzaad";
            this.Size = new System.Drawing.Size(800, 571);
            this.Load += new System.EventHandler(this.TermekHozzaad_Load);
            this.Leave += new System.EventHandler(this.TermekHozzaad_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.TextBox textAr;
        private System.Windows.Forms.TextBox textTermekNev;
        private System.Windows.Forms.ComboBox comboBoxKateg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
