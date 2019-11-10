namespace TOKO.GUI
{
    partial class FormBarang
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
            this.groupBox_Form = new System.Windows.Forms.GroupBox();
            this.comboBox_Satuan = new System.Windows.Forms.ComboBox();
            this.textBox_NamaBarang = new System.Windows.Forms.TextBox();
            this.textBox_Harga = new System.Windows.Forms.TextBox();
            this.textBox_Stok = new System.Windows.Forms.TextBox();
            this.textBox_KodeBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.textBox_Cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_barang = new System.Windows.Forms.DataGridView();
            this.groupBox_Aksi = new System.Windows.Forms.GroupBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Simpan = new System.Windows.Forms.Button();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.button_Buat = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_Form.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
            this.groupBox_Aksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Form
            // 
            this.groupBox_Form.Controls.Add(this.comboBox_Satuan);
            this.groupBox_Form.Controls.Add(this.textBox_NamaBarang);
            this.groupBox_Form.Controls.Add(this.textBox_Harga);
            this.groupBox_Form.Controls.Add(this.textBox_Stok);
            this.groupBox_Form.Controls.Add(this.textBox_KodeBarang);
            this.groupBox_Form.Controls.Add(this.label5);
            this.groupBox_Form.Controls.Add(this.label4);
            this.groupBox_Form.Controls.Add(this.label3);
            this.groupBox_Form.Controls.Add(this.label2);
            this.groupBox_Form.Controls.Add(this.label1);
            this.groupBox_Form.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Form.Name = "groupBox_Form";
            this.groupBox_Form.Size = new System.Drawing.Size(294, 204);
            this.groupBox_Form.TabIndex = 0;
            this.groupBox_Form.TabStop = false;
            this.groupBox_Form.Text = "==Form Barang==";
            // 
            // comboBox_Satuan
            // 
            this.comboBox_Satuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Satuan.FormattingEnabled = true;
            this.comboBox_Satuan.Items.AddRange(new object[] {
            "Unit",
            "Lusin",
            "Kodi",
            "Box"});
            this.comboBox_Satuan.Location = new System.Drawing.Point(119, 171);
            this.comboBox_Satuan.Name = "comboBox_Satuan";
            this.comboBox_Satuan.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Satuan.TabIndex = 9;
            // 
            // textBox_NamaBarang
            // 
            this.textBox_NamaBarang.Location = new System.Drawing.Point(119, 63);
            this.textBox_NamaBarang.Name = "textBox_NamaBarang";
            this.textBox_NamaBarang.Size = new System.Drawing.Size(114, 20);
            this.textBox_NamaBarang.TabIndex = 8;
            // 
            // textBox_Harga
            // 
            this.textBox_Harga.Location = new System.Drawing.Point(119, 103);
            this.textBox_Harga.Name = "textBox_Harga";
            this.textBox_Harga.Size = new System.Drawing.Size(88, 20);
            this.textBox_Harga.TabIndex = 7;
            // 
            // textBox_Stok
            // 
            this.textBox_Stok.Location = new System.Drawing.Point(119, 138);
            this.textBox_Stok.Name = "textBox_Stok";
            this.textBox_Stok.Size = new System.Drawing.Size(58, 20);
            this.textBox_Stok.TabIndex = 6;
            // 
            // textBox_KodeBarang
            // 
            this.textBox_KodeBarang.Location = new System.Drawing.Point(119, 26);
            this.textBox_KodeBarang.Name = "textBox_KodeBarang";
            this.textBox_KodeBarang.Size = new System.Drawing.Size(58, 20);
            this.textBox_KodeBarang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Data.Controls.Add(this.textBox_Cari);
            this.groupBox_Data.Controls.Add(this.label6);
            this.groupBox_Data.Controls.Add(this.dataGridView_barang);
            this.groupBox_Data.Location = new System.Drawing.Point(322, 12);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(348, 308);
            this.groupBox_Data.TabIndex = 1;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "==Data Barang==";
            // 
            // textBox_Cari
            // 
            this.textBox_Cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Cari.Location = new System.Drawing.Point(154, 30);
            this.textBox_Cari.Name = "textBox_Cari";
            this.textBox_Cari.Size = new System.Drawing.Size(176, 20);
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
            this.dataGridView_barang.Size = new System.Drawing.Size(336, 232);
            this.dataGridView_barang.TabIndex = 0;
            this.dataGridView_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellClick);
            // 
            // groupBox_Aksi
            // 
            this.groupBox_Aksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Aksi.Controls.Add(this.button_Edit);
            this.groupBox_Aksi.Controls.Add(this.button_Simpan);
            this.groupBox_Aksi.Controls.Add(this.button_Hapus);
            this.groupBox_Aksi.Controls.Add(this.button_Buat);
            this.groupBox_Aksi.Location = new System.Drawing.Point(12, 222);
            this.groupBox_Aksi.Name = "groupBox_Aksi";
            this.groupBox_Aksi.Size = new System.Drawing.Size(294, 98);
            this.groupBox_Aksi.TabIndex = 1;
            this.groupBox_Aksi.TabStop = false;
            this.groupBox_Aksi.Text = "==Aksi==";
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(3, 62);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(120, 34);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Simpan
            // 
            this.button_Simpan.Location = new System.Drawing.Point(161, 16);
            this.button_Simpan.Name = "button_Simpan";
            this.button_Simpan.Size = new System.Drawing.Size(127, 40);
            this.button_Simpan.TabIndex = 2;
            this.button_Simpan.Text = "Simpan";
            this.button_Simpan.UseVisualStyleBackColor = true;
            this.button_Simpan.Click += new System.EventHandler(this.button_Simpan_Click);
            // 
            // button_Hapus
            // 
            this.button_Hapus.Location = new System.Drawing.Point(161, 62);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(127, 36);
            this.button_Hapus.TabIndex = 1;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // button_Buat
            // 
            this.button_Buat.Location = new System.Drawing.Point(3, 16);
            this.button_Buat.Name = "button_Buat";
            this.button_Buat.Size = new System.Drawing.Size(120, 40);
            this.button_Buat.TabIndex = 0;
            this.button_Buat.Text = "Buat";
            this.button_Buat.UseVisualStyleBackColor = true;
            this.button_Buat.Click += new System.EventHandler(this.button_Buat_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 332);
            this.Controls.Add(this.groupBox_Aksi);
            this.Controls.Add(this.groupBox_Data);
            this.Controls.Add(this.groupBox_Form);
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBarang";
            this.groupBox_Form.ResumeLayout(false);
            this.groupBox_Form.PerformLayout();
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).EndInit();
            this.groupBox_Aksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Form;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.GroupBox groupBox_Aksi;
        private System.Windows.Forms.TextBox textBox_NamaBarang;
        private System.Windows.Forms.TextBox textBox_Harga;
        private System.Windows.Forms.TextBox textBox_Stok;
        private System.Windows.Forms.TextBox textBox_KodeBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_barang;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Simpan;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.Button button_Buat;
        private System.Windows.Forms.TextBox textBox_Cari;
        private System.Windows.Forms.ComboBox comboBox_Satuan;
        private System.Windows.Forms.ErrorProvider ep;
    }
}