namespace TOKO.GUI
{
    partial class DialogBarang
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
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.textBox_Cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_barang = new System.Windows.Forms.DataGridView();
            this.groupBox_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Data.Controls.Add(this.textBox_Cari);
            this.groupBox_Data.Controls.Add(this.label6);
            this.groupBox_Data.Controls.Add(this.dataGridView_barang);
            this.groupBox_Data.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(578, 239);
            this.groupBox_Data.TabIndex = 2;
            this.groupBox_Data.TabStop = false;
            // 
            // textBox_Cari
            // 
            this.textBox_Cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Cari.Location = new System.Drawing.Point(154, 30);
            this.textBox_Cari.Name = "textBox_Cari";
            this.textBox_Cari.Size = new System.Drawing.Size(406, 20);
            this.textBox_Cari.TabIndex = 10;
            this.textBox_Cari.TextChanged += new System.EventHandler(this.textBox_Cari_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cari Barang (Kode/Nama)";
            // 
            // dataGridView_barang
            // 
            this.dataGridView_barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barang.Location = new System.Drawing.Point(6, 70);
            this.dataGridView_barang.Name = "dataGridView_barang";
            this.dataGridView_barang.Size = new System.Drawing.Size(566, 186);
            this.dataGridView_barang.TabIndex = 0;
            this.dataGridView_barang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellDoubleClick_1);
            // 
            // DialogBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 263);
            this.Controls.Add(this.groupBox_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "==Cari Barang==";
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.TextBox textBox_Cari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_barang;
    }
}