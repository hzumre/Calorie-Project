namespace KaloriHesaplamaProjesi.UI
{
    partial class Besinler
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
            this.dgvBesinler = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblAdet = new System.Windows.Forms.Label();
            this.dgvTuketim = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuketim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBesinler
            // 
            this.dgvBesinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBesinler.Location = new System.Drawing.Point(-3, 4);
            this.dgvBesinler.MultiSelect = false;
            this.dgvBesinler.Name = "dgvBesinler";
            this.dgvBesinler.RowHeadersWidth = 51;
            this.dgvBesinler.RowTemplate.Height = 29;
            this.dgvBesinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBesinler.Size = new System.Drawing.Size(767, 521);
            this.dgvBesinler.TabIndex = 0;
            this.dgvBesinler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvBesinler.DoubleClick += new System.EventHandler(this.dgvBesinler_DoubleClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(77, 587);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 27);
            this.numericUpDown1.TabIndex = 1;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdet.Location = new System.Drawing.Point(12, 587);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(59, 23);
            this.lblAdet.TabIndex = 2;
            this.lblAdet.Text = "Adet :";
            // 
            // dgvTuketim
            // 
            this.dgvTuketim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuketim.Location = new System.Drawing.Point(770, 4);
            this.dgvTuketim.Name = "dgvTuketim";
            this.dgvTuketim.RowHeadersWidth = 51;
            this.dgvTuketim.RowTemplate.Height = 29;
            this.dgvTuketim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuketim.Size = new System.Drawing.Size(766, 521);
            this.dgvTuketim.TabIndex = 3;
            this.dgvTuketim.DoubleClick += new System.EventHandler(this.dgvTuketim_DoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(209, 585);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 29);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(326, 587);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 29);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(447, 587);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(160, 29);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kaydet-Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Besinler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 711);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvTuketim);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dgvBesinler);
            this.Name = "Besinler";
            this.Text = "Besinler";
            this.Load += new System.EventHandler(this.Besinler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuketim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBesinler;
        private NumericUpDown numericUpDown1;
        private Label lblAdet;
        private DataGridView dgvTuketim;
        private Button btnEkle;
        private Button btnSil;
        private Button btnKapat;
    }
}