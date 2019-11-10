namespace TOKO.GUI
{
    partial class FormTransaksi
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_TransaksiPenjualan = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_NamaPelanggan = new System.Windows.Forms.TextBox();
            this.textBox_idPelanggan = new System.Windows.Forms.TextBox();
            this.dateTimePicker_TanggalKwitansi = new System.Windows.Forms.DateTimePicker();
            this.textBox_NoKwitansi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_JumlahBarang = new System.Windows.Forms.TextBox();
            this.textBox_HargaBarang = new System.Windows.Forms.TextBox();
            this.textBox_NamaBarang = new System.Windows.Forms.TextBox();
            this.textBox_KodeBarang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_Transaksi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Simpan = new System.Windows.Forms.Button();
            this.button_Baru = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_TransaksiPenjualan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transaksi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_TransaksiPenjualan
            // 
            this.groupBox_TransaksiPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_TransaksiPenjualan.Controls.Add(this.button1);
            this.groupBox_TransaksiPenjualan.Controls.Add(this.textBox_NamaPelanggan);
            this.groupBox_TransaksiPenjualan.Controls.Add(this.textBox_idPelanggan);
            this.groupBox_TransaksiPenjualan.Controls.Add(this.dateTimePicker_TanggalKwitansi);
            this.groupBox_TransaksiPenjualan.Controls.Add(this.textBox_NoKwitansi);
            this.groupBox_TransaksiPenjualan.Controls.Add(this.label5);
            this.groupBox_TransaksiPenjualan.Controls.Add(this.label4);
            this.groupBox_TransaksiPenjualan.Controls.Add(this.label3);
            this.groupBox_TransaksiPenjualan.Controls.Add(this.label2);
            this.groupBox_TransaksiPenjualan.Controls.Add(this.label1);
            this.groupBox_TransaksiPenjualan.Location = new System.Drawing.Point(12, 12);
            this.groupBox_TransaksiPenjualan.Name = "groupBox_TransaksiPenjualan";
            this.groupBox_TransaksiPenjualan.Size = new System.Drawing.Size(338, 202);
            this.groupBox_TransaksiPenjualan.TabIndex = 0;
            this.groupBox_TransaksiPenjualan.TabStop = false;
            this.groupBox_TransaksiPenjualan.Text = "==Form Transaksi Penjualan==";
            // 
            // button1
            // 
            this.button1.Image = global::TOKO.Properties.Resources.iconfinder_013_MagnifyingGlass_183520_1_;
            this.button1.Location = new System.Drawing.Point(135, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_NamaPelanggan
            // 
            this.textBox_NamaPelanggan.Location = new System.Drawing.Point(191, 176);
            this.textBox_NamaPelanggan.Name = "textBox_NamaPelanggan";
            this.textBox_NamaPelanggan.Size = new System.Drawing.Size(120, 20);
            this.textBox_NamaPelanggan.TabIndex = 8;
            // 
            // textBox_idPelanggan
            // 
            this.textBox_idPelanggan.Location = new System.Drawing.Point(9, 176);
            this.textBox_idPelanggan.Name = "textBox_idPelanggan";
            this.textBox_idPelanggan.Size = new System.Drawing.Size(116, 20);
            this.textBox_idPelanggan.TabIndex = 7;
            // 
            // dateTimePicker_TanggalKwitansi
            // 
            this.dateTimePicker_TanggalKwitansi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_TanggalKwitansi.Location = new System.Drawing.Point(135, 73);
            this.dateTimePicker_TanggalKwitansi.Name = "dateTimePicker_TanggalKwitansi";
            this.dateTimePicker_TanggalKwitansi.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_TanggalKwitansi.TabIndex = 6;
            // 
            // textBox_NoKwitansi
            // 
            this.textBox_NoKwitansi.Location = new System.Drawing.Point(135, 29);
            this.textBox_NoKwitansi.Name = "textBox_NoKwitansi";
            this.textBox_NoKwitansi.Size = new System.Drawing.Size(100, 20);
            this.textBox_NoKwitansi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::TOKO.Properties.Resources.iconfinder_calc_42174;
            this.label5.Location = new System.Drawing.Point(62, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Kwitansi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Kwitansi";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.button_Plus);
            this.groupBox2.Controls.Add(this.button_Minus);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox_JumlahBarang);
            this.groupBox2.Controls.Add(this.textBox_HargaBarang);
            this.groupBox2.Controls.Add(this.textBox_NamaBarang);
            this.groupBox2.Controls.Add(this.textBox_KodeBarang);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "==Ambil Barang==";
            // 
            // button_Plus
            // 
            this.button_Plus.Image = global::TOKO.Properties.Resources.iconfinder_013_MagnifyingGlass_183520;
            this.button_Plus.Location = new System.Drawing.Point(298, 92);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(22, 23);
            this.button_Plus.TabIndex = 15;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.Image = global::TOKO.Properties.Resources.iconfinder_013_MagnifyingGlass_183520;
            this.button_Minus.Location = new System.Drawing.Point(298, 121);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(22, 23);
            this.button_Minus.TabIndex = 14;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button2
            // 
            this.button2.Image = global::TOKO.Properties.Resources.iconfinder_013_MagnifyingGlass_183520_1_;
            this.button2.Location = new System.Drawing.Point(128, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_JumlahBarang
            // 
            this.textBox_JumlahBarang.Location = new System.Drawing.Point(172, 114);
            this.textBox_JumlahBarang.Name = "textBox_JumlahBarang";
            this.textBox_JumlahBarang.Size = new System.Drawing.Size(116, 20);
            this.textBox_JumlahBarang.TabIndex = 11;
            // 
            // textBox_HargaBarang
            // 
            this.textBox_HargaBarang.Location = new System.Drawing.Point(6, 114);
            this.textBox_HargaBarang.Name = "textBox_HargaBarang";
            this.textBox_HargaBarang.Size = new System.Drawing.Size(116, 20);
            this.textBox_HargaBarang.TabIndex = 10;
            // 
            // textBox_NamaBarang
            // 
            this.textBox_NamaBarang.Location = new System.Drawing.Point(172, 52);
            this.textBox_NamaBarang.Name = "textBox_NamaBarang";
            this.textBox_NamaBarang.Size = new System.Drawing.Size(116, 20);
            this.textBox_NamaBarang.TabIndex = 9;
            // 
            // textBox_KodeBarang
            // 
            this.textBox_KodeBarang.Location = new System.Drawing.Point(6, 52);
            this.textBox_KodeBarang.Name = "textBox_KodeBarang";
            this.textBox_KodeBarang.Size = new System.Drawing.Size(116, 20);
            this.textBox_KodeBarang.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Jumlah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Harga Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nama Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kode Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.dataGridView_Transaksi);
            this.groupBox3.Location = new System.Drawing.Point(356, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 411);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "==Data Transaksi==";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.label_Total);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(6, 371);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(379, 40);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(125, 16);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(16, 13);
            this.label_Total.TabIndex = 16;
            this.label_Total.Text = " 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total Seluruh : Rp.";
            // 
            // dataGridView_Transaksi
            // 
            this.dataGridView_Transaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Transaksi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Transaksi.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Transaksi.Name = "dataGridView_Transaksi";
            this.dataGridView_Transaksi.Size = new System.Drawing.Size(379, 354);
            this.dataGridView_Transaksi.TabIndex = 0;
            this.dataGridView_Transaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Transaksi_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.button_Simpan);
            this.groupBox4.Controls.Add(this.button_Baru);
            this.groupBox4.Location = new System.Drawing.Point(12, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 47);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // button_Simpan
            // 
            this.button_Simpan.Location = new System.Drawing.Point(237, 7);
            this.button_Simpan.Name = "button_Simpan";
            this.button_Simpan.Size = new System.Drawing.Size(101, 40);
            this.button_Simpan.TabIndex = 1;
            this.button_Simpan.Text = "Simpan";
            this.button_Simpan.UseVisualStyleBackColor = true;
            this.button_Simpan.Click += new System.EventHandler(this.button_Simpan_Click);
            // 
            // button_Baru
            // 
            this.button_Baru.Location = new System.Drawing.Point(0, 7);
            this.button_Baru.Name = "button_Baru";
            this.button_Baru.Size = new System.Drawing.Size(101, 40);
            this.button_Baru.TabIndex = 0;
            this.button_Baru.Text = "Baru";
            this.button_Baru.UseVisualStyleBackColor = true;
            this.button_Baru.Click += new System.EventHandler(this.button_Baru_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 426);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_TransaksiPenjualan);
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransaksi";
            this.groupBox_TransaksiPenjualan.ResumeLayout(false);
            this.groupBox_TransaksiPenjualan.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transaksi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_TransaksiPenjualan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TanggalKwitansi;
        private System.Windows.Forms.TextBox textBox_NoKwitansi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_NamaPelanggan;
        private System.Windows.Forms.TextBox textBox_idPelanggan;
        private System.Windows.Forms.TextBox textBox_JumlahBarang;
        private System.Windows.Forms.TextBox textBox_HargaBarang;
        private System.Windows.Forms.TextBox textBox_NamaBarang;
        private System.Windows.Forms.TextBox textBox_KodeBarang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView_Transaksi;
        private System.Windows.Forms.Button button_Simpan;
        private System.Windows.Forms.Button button_Baru;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider ep;
    }
}