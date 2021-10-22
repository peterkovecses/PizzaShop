
namespace PizzaShop.MyUserControl
{
    partial class TermekModosit
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textArM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.textKategM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textKeresesM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTermekNevM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(33, 116);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 240);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textArM
            // 
            this.textArM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textArM.ForeColor = System.Drawing.Color.Black;
            this.textArM.Location = new System.Drawing.Point(583, 416);
            this.textArM.Name = "textArM";
            this.textArM.Size = new System.Drawing.Size(181, 30);
            this.textArM.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(579, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ár";
            // 
            // btnModosit
            // 
            this.btnModosit.BackColor = System.Drawing.Color.Green;
            this.btnModosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModosit.ForeColor = System.Drawing.Color.White;
            this.btnModosit.Location = new System.Drawing.Point(33, 471);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(162, 57);
            this.btnModosit.TabIndex = 10;
            this.btnModosit.Text = "Módosít";
            this.btnModosit.UseVisualStyleBackColor = false;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.BackColor = System.Drawing.Color.Red;
            this.btnTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorol.ForeColor = System.Drawing.Color.White;
            this.btnTorol.Location = new System.Drawing.Point(307, 471);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(162, 57);
            this.btnTorol.TabIndex = 11;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = false;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // textKategM
            // 
            this.textKategM.Enabled = false;
            this.textKategM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKategM.ForeColor = System.Drawing.Color.Black;
            this.textKategM.Location = new System.Drawing.Point(32, 416);
            this.textKategM.Name = "textKategM";
            this.textKategM.Size = new System.Drawing.Size(181, 30);
            this.textKategM.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kategória";
            // 
            // textKeresesM
            // 
            this.textKeresesM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKeresesM.ForeColor = System.Drawing.Color.DarkGray;
            this.textKeresesM.Location = new System.Drawing.Point(31, 60);
            this.textKeresesM.Name = "textKeresesM";
            this.textKeresesM.Size = new System.Drawing.Size(181, 30);
            this.textKeresesM.TabIndex = 15;
            this.textKeresesM.Text = "Keresés";
            this.textKeresesM.Click += new System.EventHandler(this.textKeresesM_Click);
            this.textKeresesM.TextChanged += new System.EventHandler(this.textKeresesM_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Termék";
            // 
            // textTermekNevM
            // 
            this.textTermekNevM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textTermekNevM.ForeColor = System.Drawing.Color.Black;
            this.textTermekNevM.Location = new System.Drawing.Point(306, 416);
            this.textTermekNevM.Name = "textTermekNevM";
            this.textTermekNevM.Size = new System.Drawing.Size(181, 30);
            this.textTermekNevM.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(302, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Termék";
            // 
            // TermekModosit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textTermekNevM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textKeresesM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKategM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.textArM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TermekModosit";
            this.Size = new System.Drawing.Size(800, 571);
            this.Load += new System.EventHandler(this.TermekModosit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textArM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.TextBox textKategM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKeresesM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTermekNevM;
        private System.Windows.Forms.Label label4;
    }
}
