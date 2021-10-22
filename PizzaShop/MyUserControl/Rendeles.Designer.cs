
namespace PizzaShop.MyUserControl
{
    partial class Rendeles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numUpDownMenny = new System.Windows.Forms.NumericUpDown();
            this.textOsszeg = new System.Windows.Forms.TextBox();
            this.textArR = new System.Windows.Forms.TextBox();
            this.textTermekNevR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxKateg = new System.Windows.Forms.ListBox();
            this.textKereses = new System.Windows.Forms.TextBox();
            this.comboBoxKategR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKosarba = new System.Windows.Forms.Button();
            this.btnEltavolit = new System.Windows.Forms.Button();
            this.btnNyomtat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVegOssz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMenny)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(211, 203);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 247);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Termék";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Egységár";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mennyiség";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Összeg";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // numUpDownMenny
            // 
            this.numUpDownMenny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUpDownMenny.ForeColor = System.Drawing.Color.Black;
            this.numUpDownMenny.Location = new System.Drawing.Point(211, 140);
            this.numUpDownMenny.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDownMenny.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownMenny.Name = "numUpDownMenny";
            this.numUpDownMenny.Size = new System.Drawing.Size(194, 28);
            this.numUpDownMenny.TabIndex = 27;
            this.numUpDownMenny.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownMenny.ValueChanged += new System.EventHandler(this.numUpDownMenny_ValueChanged);
            // 
            // textOsszeg
            // 
            this.textOsszeg.Enabled = false;
            this.textOsszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textOsszeg.ForeColor = System.Drawing.Color.Black;
            this.textOsszeg.Location = new System.Drawing.Point(446, 140);
            this.textOsszeg.Margin = new System.Windows.Forms.Padding(2);
            this.textOsszeg.Name = "textOsszeg";
            this.textOsszeg.Size = new System.Drawing.Size(155, 28);
            this.textOsszeg.TabIndex = 26;
            // 
            // textArR
            // 
            this.textArR.Enabled = false;
            this.textArR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textArR.ForeColor = System.Drawing.Color.Black;
            this.textArR.Location = new System.Drawing.Point(444, 60);
            this.textArR.Margin = new System.Windows.Forms.Padding(2);
            this.textArR.Name = "textArR";
            this.textArR.Size = new System.Drawing.Size(157, 28);
            this.textArR.TabIndex = 25;
            // 
            // textTermekNevR
            // 
            this.textTermekNevR.Enabled = false;
            this.textTermekNevR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textTermekNevR.ForeColor = System.Drawing.Color.Black;
            this.textTermekNevR.Location = new System.Drawing.Point(211, 60);
            this.textTermekNevR.Margin = new System.Windows.Forms.Padding(2);
            this.textTermekNevR.Name = "textTermekNevR";
            this.textTermekNevR.Size = new System.Drawing.Size(194, 28);
            this.textTermekNevR.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(442, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Összeg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(207, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mennyiség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(442, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Egységár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(207, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Termék";
            // 
            // listBoxKateg
            // 
            this.listBoxKateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxKateg.FormattingEnabled = true;
            this.listBoxKateg.ItemHeight = 22;
            this.listBoxKateg.Location = new System.Drawing.Point(27, 205);
            this.listBoxKateg.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxKateg.Name = "listBoxKateg";
            this.listBoxKateg.Size = new System.Drawing.Size(162, 334);
            this.listBoxKateg.TabIndex = 19;
            this.listBoxKateg.SelectedIndexChanged += new System.EventHandler(this.listBoxKateg_SelectedIndexChanged);
            // 
            // textKereses
            // 
            this.textKereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKereses.ForeColor = System.Drawing.Color.DarkGray;
            this.textKereses.Location = new System.Drawing.Point(27, 139);
            this.textKereses.Margin = new System.Windows.Forms.Padding(2);
            this.textKereses.Name = "textKereses";
            this.textKereses.Size = new System.Drawing.Size(162, 28);
            this.textKereses.TabIndex = 18;
            this.textKereses.Text = "Keresés...";
            this.textKereses.Click += new System.EventHandler(this.textKereses_Click);
            this.textKereses.TextChanged += new System.EventHandler(this.textKereses_TextChanged);
            // 
            // comboBoxKategR
            // 
            this.comboBoxKategR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKategR.FormattingEnabled = true;
            this.comboBoxKategR.Location = new System.Drawing.Point(27, 60);
            this.comboBoxKategR.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKategR.Name = "comboBoxKategR";
            this.comboBoxKategR.Size = new System.Drawing.Size(162, 30);
            this.comboBoxKategR.TabIndex = 17;
            this.comboBoxKategR.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategR_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kategória";
            // 
            // btnKosarba
            // 
            this.btnKosarba.BackColor = System.Drawing.Color.Green;
            this.btnKosarba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKosarba.ForeColor = System.Drawing.Color.White;
            this.btnKosarba.Location = new System.Drawing.Point(629, 108);
            this.btnKosarba.Name = "btnKosarba";
            this.btnKosarba.Size = new System.Drawing.Size(141, 60);
            this.btnKosarba.TabIndex = 30;
            this.btnKosarba.Text = "Kosárba";
            this.btnKosarba.UseVisualStyleBackColor = false;
            this.btnKosarba.Click += new System.EventHandler(this.btnKosarba_Click);
            // 
            // btnEltavolit
            // 
            this.btnEltavolit.BackColor = System.Drawing.Color.Red;
            this.btnEltavolit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEltavolit.ForeColor = System.Drawing.Color.White;
            this.btnEltavolit.Location = new System.Drawing.Point(211, 478);
            this.btnEltavolit.Name = "btnEltavolit";
            this.btnEltavolit.Size = new System.Drawing.Size(141, 60);
            this.btnEltavolit.TabIndex = 31;
            this.btnEltavolit.Text = "Eltávolít";
            this.btnEltavolit.UseVisualStyleBackColor = false;
            this.btnEltavolit.Click += new System.EventHandler(this.btnEltavolit_Click);
            // 
            // btnNyomtat
            // 
            this.btnNyomtat.BackColor = System.Drawing.Color.Green;
            this.btnNyomtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNyomtat.ForeColor = System.Drawing.Color.White;
            this.btnNyomtat.Location = new System.Drawing.Point(629, 478);
            this.btnNyomtat.Name = "btnNyomtat";
            this.btnNyomtat.Size = new System.Drawing.Size(141, 60);
            this.btnNyomtat.TabIndex = 32;
            this.btnNyomtat.Text = "Nyomtat";
            this.btnNyomtat.UseVisualStyleBackColor = false;
            this.btnNyomtat.Click += new System.EventHandler(this.btnNyomtat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(427, 466);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Végösszeg";
            // 
            // labelVegOssz
            // 
            this.labelVegOssz.BackColor = System.Drawing.Color.LightGray;
            this.labelVegOssz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVegOssz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelVegOssz.Location = new System.Drawing.Point(431, 497);
            this.labelVegOssz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVegOssz.Name = "labelVegOssz";
            this.labelVegOssz.Size = new System.Drawing.Size(101, 41);
            this.labelVegOssz.TabIndex = 34;
            this.labelVegOssz.Text = "0";
            this.labelVegOssz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelVegOssz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNyomtat);
            this.Controls.Add(this.btnEltavolit);
            this.Controls.Add(this.btnKosarba);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numUpDownMenny);
            this.Controls.Add(this.textOsszeg);
            this.Controls.Add(this.textArR);
            this.Controls.Add(this.textTermekNevR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxKateg);
            this.Controls.Add(this.textKereses);
            this.Controls.Add(this.comboBoxKategR);
            this.Controls.Add(this.label2);
            this.Name = "Rendeles";
            this.Size = new System.Drawing.Size(800, 571);
            this.Load += new System.EventHandler(this.Rendeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMenny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numUpDownMenny;
        private System.Windows.Forms.TextBox textOsszeg;
        private System.Windows.Forms.TextBox textArR;
        private System.Windows.Forms.TextBox textTermekNevR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxKateg;
        private System.Windows.Forms.TextBox textKereses;
        private System.Windows.Forms.ComboBox comboBoxKategR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKosarba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnEltavolit;
        private System.Windows.Forms.Button btnNyomtat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVegOssz;
    }
}
