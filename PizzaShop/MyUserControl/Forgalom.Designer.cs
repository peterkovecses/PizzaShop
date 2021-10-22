
namespace PizzaShop.MyUserControl
{
    partial class Forgalom
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
            this.dataGridViewF = new System.Windows.Forms.DataGridView();
            this.labelVegOsszF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTorol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPTol = new System.Windows.Forms.DateTimePicker();
            this.dTPIg = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelVegOsszR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNyomtat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewR = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewF
            // 
            this.dataGridViewF.AllowUserToAddRows = false;
            this.dataGridViewF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewF.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewF.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewF.Location = new System.Drawing.Point(21, 118);
            this.dataGridViewF.MultiSelect = false;
            this.dataGridViewF.Name = "dataGridViewF";
            this.dataGridViewF.RowHeadersWidth = 51;
            this.dataGridViewF.RowTemplate.Height = 24;
            this.dataGridViewF.Size = new System.Drawing.Size(583, 180);
            this.dataGridViewF.TabIndex = 4;
            this.dataGridViewF.SelectionChanged += new System.EventHandler(this.dataGridViewF_SelectionChanged);
            // 
            // labelVegOsszF
            // 
            this.labelVegOsszF.BackColor = System.Drawing.Color.LightGray;
            this.labelVegOsszF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVegOsszF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelVegOsszF.Location = new System.Drawing.Point(617, 215);
            this.labelVegOsszF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVegOsszF.Name = "labelVegOsszF";
            this.labelVegOsszF.Size = new System.Drawing.Size(148, 41);
            this.labelVegOsszF.TabIndex = 36;
            this.labelVegOsszF.Text = "0";
            this.labelVegOsszF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(617, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Időszak forgalma";
            // 
            // btnTorol
            // 
            this.btnTorol.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.btnTorol.Location = new System.Drawing.Point(610, 118);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(38, 38);
            this.btnTorol.TabIndex = 52;
            this.btnTorol.Text = "-";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Rendelések:";
            // 
            // dTPTol
            // 
            this.dTPTol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dTPTol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPTol.Location = new System.Drawing.Point(193, 34);
            this.dTPTol.Name = "dTPTol";
            this.dTPTol.Size = new System.Drawing.Size(200, 28);
            this.dTPTol.TabIndex = 54;
            this.dTPTol.ValueChanged += new System.EventHandler(this.dTPTol_ValueChanged);
            // 
            // dTPIg
            // 
            this.dTPIg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dTPIg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPIg.Location = new System.Drawing.Point(438, 34);
            this.dTPIg.Name = "dTPIg";
            this.dTPIg.Size = new System.Drawing.Size(200, 28);
            this.dTPIg.TabIndex = 55;
            this.dTPIg.ValueChanged += new System.EventHandler(this.dTPIg_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(398, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "-tól";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(643, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "-ig";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Forgalmi adatok:";
            // 
            // labelVegOsszR
            // 
            this.labelVegOsszR.BackColor = System.Drawing.Color.LightGray;
            this.labelVegOsszR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVegOsszR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelVegOsszR.Location = new System.Drawing.Point(621, 386);
            this.labelVegOsszR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVegOsszR.Name = "labelVegOsszR";
            this.labelVegOsszR.Size = new System.Drawing.Size(101, 41);
            this.labelVegOsszR.TabIndex = 74;
            this.labelVegOsszR.Text = "0";
            this.labelVegOsszR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(617, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 73;
            this.label6.Text = "Végösszeg";
            // 
            // btnNyomtat
            // 
            this.btnNyomtat.BackColor = System.Drawing.Color.Green;
            this.btnNyomtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNyomtat.ForeColor = System.Drawing.Color.White;
            this.btnNyomtat.Location = new System.Drawing.Point(621, 467);
            this.btnNyomtat.Name = "btnNyomtat";
            this.btnNyomtat.Size = new System.Drawing.Size(161, 66);
            this.btnNyomtat.TabIndex = 72;
            this.btnNyomtat.Text = "Bizonylat újranyomtatás";
            this.btnNyomtat.UseVisualStyleBackColor = false;
            this.btnNyomtat.Click += new System.EventHandler(this.btnNyomtat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(16, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 71;
            this.label7.Text = "Rendelés részletek:";
            // 
            // dataGridViewR
            // 
            this.dataGridViewR.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewR.Location = new System.Drawing.Point(21, 353);
            this.dataGridViewR.Name = "dataGridViewR";
            this.dataGridViewR.RowHeadersWidth = 51;
            this.dataGridViewR.RowTemplate.Height = 24;
            this.dataGridViewR.Size = new System.Drawing.Size(583, 180);
            this.dataGridViewR.TabIndex = 70;
            // 
            // Forgalom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelVegOsszR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNyomtat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTPIg);
            this.Controls.Add(this.dTPTol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.labelVegOsszF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewF);
            this.Name = "Forgalom";
            this.Size = new System.Drawing.Size(800, 571);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewF;
        private System.Windows.Forms.Label labelVegOsszF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPTol;
        private System.Windows.Forms.DateTimePicker dTPIg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelVegOsszR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNyomtat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewR;
    }
}
