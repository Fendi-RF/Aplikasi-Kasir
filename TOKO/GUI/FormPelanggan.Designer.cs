namespace TOKO.GUI
{
    partial class FormPelanggan
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
            this.richTextBox_Alamat = new System.Windows.Forms.RichTextBox();
            this.textBox_NamaPelanggan = new System.Windows.Forms.TextBox();
            this.textBox_NoTelp = new System.Windows.Forms.TextBox();
            this.textBox_IdPelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Aksi = new System.Windows.Forms.GroupBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Simpan = new System.Windows.Forms.Button();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.button_Buat = new System.Windows.Forms.Button();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.textBox_Cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Pelanggan = new System.Windows.Forms.DataGridView();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_Form.SuspendLayout();
            this.groupBox_Aksi.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Form
            // 
            this.groupBox_Form.Controls.Add(this.richTextBox_Alamat);
            this.groupBox_Form.Controls.Add(this.textBox_NamaPelanggan);
            this.groupBox_Form.Controls.Add(this.textBox_NoTelp);
            this.groupBox_Form.Controls.Add(this.textBox_IdPelanggan);
            this.groupBox_Form.Controls.Add(this.label4);
            this.groupBox_Form.Controls.Add(this.label3);
            this.groupBox_Form.Controls.Add(this.label2);
            this.groupBox_Form.Controls.Add(this.label1);
            this.groupBox_Form.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Form.Name = "groupBox_Form";
            this.groupBox_Form.Size = new System.Drawing.Size(332, 204);
            this.groupBox_Form.TabIndex = 1;
            this.groupBox_Form.TabStop = false;
            this.groupBox_Form.Text = "==Form Pelanggan==";
            // 
            // richTextBox_Alamat
            // 
            this.richTextBox_Alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_Alamat.Location = new System.Drawing.Point(119, 89);
            this.richTextBox_Alamat.Name = "richTextBox_Alamat";
            this.richTextBox_Alamat.Size = new System.Drawing.Size(207, 73);
            this.richTextBox_Alamat.TabIndex = 2;
            this.richTextBox_Alamat.Text = "";
            // 
            // textBox_NamaPelanggan
            // 
            this.textBox_NamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NamaPelanggan.Location = new System.Drawing.Point(119, 63);
            this.textBox_NamaPelanggan.Name = "textBox_NamaPelanggan";
            this.textBox_NamaPelanggan.Size = new System.Drawing.Size(127, 20);
            this.textBox_NamaPelanggan.TabIndex = 8;
            // 
            // textBox_NoTelp
            // 
            this.textBox_NoTelp.Location = new System.Drawing.Point(119, 168);
            this.textBox_NoTelp.Name = "textBox_NoTelp";
            this.textBox_NoTelp.Size = new System.Drawing.Size(127, 20);
            this.textBox_NoTelp.TabIndex = 6;
            this.textBox_NoTelp.TextChanged += new System.EventHandler(this.textBox_NoTelp_TextChanged);
            this.textBox_NoTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NoTelp_KeyPress);
            // 
            // textBox_IdPelanggan
            // 
            this.textBox_IdPelanggan.Location = new System.Drawing.Point(119, 26);
            this.textBox_IdPelanggan.Name = "textBox_IdPelanggan";
            this.textBox_IdPelanggan.Size = new System.Drawing.Size(58, 20);
            this.textBox_IdPelanggan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. Telp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pelanggan";
            // 
            // groupBox_Aksi
            // 
            this.groupBox_Aksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Aksi.Controls.Add(this.button_Edit);
            this.groupBox_Aksi.Controls.Add(this.button_Simpan);
            this.groupBox_Aksi.Controls.Add(this.button_Hapus);
            this.groupBox_Aksi.Controls.Add(this.button_Buat);
            this.groupBox_Aksi.Location = new System.Drawing.Point(12, 232);
            this.groupBox_Aksi.Name = "groupBox_Aksi";
            this.groupBox_Aksi.Size = new System.Drawing.Size(332, 98);
            this.groupBox_Aksi.TabIndex = 2;
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
            this.button_Simpan.Location = new System.Drawing.Point(199, 16);
            this.button_Simpan.Name = "button_Simpan";
            this.button_Simpan.Size = new System.Drawing.Size(127, 40);
            this.button_Simpan.TabIndex = 2;
            this.button_Simpan.Text = "Simpan";
            this.button_Simpan.UseVisualStyleBackColor = true;
            this.button_Simpan.Click += new System.EventHandler(this.button_Simpan_Click);
            // 
            // button_Hapus
            // 
            this.button_Hapus.Location = new System.Drawing.Point(199, 62);
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
            // groupBox_Data
            // 
            this.groupBox_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Data.Controls.Add(this.textBox_Cari);
            this.groupBox_Data.Controls.Add(this.label6);
            this.groupBox_Data.Controls.Add(this.dataGridView_Pelanggan);
            this.groupBox_Data.Location = new System.Drawing.Point(350, 22);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(310, 308);
            this.groupBox_Data.TabIndex = 3;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "==Data Pelanggan==";
            // 
            // textBox_Cari
            // 
            this.textBox_Cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Cari.Location = new System.Drawing.Point(154, 30);
            this.textBox_Cari.Name = "textBox_Cari";
            this.textBox_Cari.Size = new System.Drawing.Size(138, 20);
            this.textBox_Cari.TabIndex = 10;
            this.textBox_Cari.TextChanged += new System.EventHandler(this.textBox_Cari_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cari Pelanggan (Id/Nama)";
            // 
            // dataGridView_Pelanggan
            // 
            this.dataGridView_Pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pelanggan.Location = new System.Drawing.Point(6, 70);
            this.dataGridView_Pelanggan.Name = "dataGridView_Pelanggan";
            this.dataGridView_Pelanggan.Size = new System.Drawing.Size(298, 232);
            this.dataGridView_Pelanggan.TabIndex = 0;
            this.dataGridView_Pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Pelanggan_CellContentClick);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 342);
            this.Controls.Add(this.groupBox_Data);
            this.Controls.Add(this.groupBox_Aksi);
            this.Controls.Add(this.groupBox_Form);
            this.Name = "FormPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPelanggan";
            this.groupBox_Form.ResumeLayout(false);
            this.groupBox_Form.PerformLayout();
            this.groupBox_Aksi.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Form;
        private System.Windows.Forms.TextBox textBox_NamaPelanggan;
        private System.Windows.Forms.TextBox textBox_NoTelp;
        private System.Windows.Forms.TextBox textBox_IdPelanggan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_Alamat;
        private System.Windows.Forms.GroupBox groupBox_Aksi;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Simpan;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.Button button_Buat;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.TextBox textBox_Cari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_Pelanggan;
        private System.Windows.Forms.ErrorProvider ep;
    }
}