namespace KaloriHesaplamaProjesi.UI
{
    partial class AylikRaporEkrani
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYag = new System.Windows.Forms.Label();
            this.lblKarbonhidrat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(546, 326);
            this.dataGridView1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KaloriHesaplamaProjesi.UI.Properties.Resources.RaporEkrani6;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 648);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblToplamKalori);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblProtein);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblYag);
            this.panel2.Controls.Add(this.lblKarbonhidrat);
            this.panel2.Location = new System.Drawing.Point(24, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 125);
            this.panel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Toplam Kalori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(176, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Karbonhidrat :";
            // 
            // lblToplamKalori
            // 
            this.lblToplamKalori.AutoSize = true;
            this.lblToplamKalori.BackColor = System.Drawing.Color.White;
            this.lblToplamKalori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamKalori.ForeColor = System.Drawing.Color.Green;
            this.lblToplamKalori.Location = new System.Drawing.Point(68, 58);
            this.lblToplamKalori.Name = "lblToplamKalori";
            this.lblToplamKalori.Size = new System.Drawing.Size(57, 23);
            this.lblToplamKalori.TabIndex = 19;
            this.lblToplamKalori.Text = "0 kcal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(340, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yağ :";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProtein.ForeColor = System.Drawing.Color.Green;
            this.lblProtein.Location = new System.Drawing.Point(431, 58);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(57, 23);
            this.lblProtein.TabIndex = 17;
            this.lblProtein.Text = "0 kcal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(431, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Protein :";
            // 
            // lblYag
            // 
            this.lblYag.AutoSize = true;
            this.lblYag.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYag.ForeColor = System.Drawing.Color.Green;
            this.lblYag.Location = new System.Drawing.Point(331, 58);
            this.lblYag.Name = "lblYag";
            this.lblYag.Size = new System.Drawing.Size(57, 23);
            this.lblYag.TabIndex = 16;
            this.lblYag.Text = "0 kcal";
            // 
            // lblKarbonhidrat
            // 
            this.lblKarbonhidrat.AutoSize = true;
            this.lblKarbonhidrat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKarbonhidrat.ForeColor = System.Drawing.Color.Green;
            this.lblKarbonhidrat.Location = new System.Drawing.Point(205, 58);
            this.lblKarbonhidrat.Name = "lblKarbonhidrat";
            this.lblKarbonhidrat.Size = new System.Drawing.Size(57, 23);
            this.lblKarbonhidrat.TabIndex = 15;
            this.lblKarbonhidrat.Text = "0 kcal";
            // 
            // AylikRaporEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AylikRaporEkrani";
            this.Text = "AylikRaporEkrani";
            this.Load += new System.EventHandler(this.AylikRaporEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label lblToplamKalori;
        private Label label4;
        private Label lblProtein;
        private Label label9;
        private Label lblYag;
        private Label lblKarbonhidrat;
    }
}