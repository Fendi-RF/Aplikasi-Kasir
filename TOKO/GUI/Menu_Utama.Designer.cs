namespace TOKO.GUI
{
    partial class Menu_Utama
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Submenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Master = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_Barang = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_Pelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_Penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_LapBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_LapPelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Pengaturan = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_UbahKataSandi = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_TambahkanAkun = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tentang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Toolbar_Barang = new System.Windows.Forms.ToolStripButton();
            this.Toolbar_Pelanggan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Toolbar_Transaksi = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_NamaUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel_NamaPengguna = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Master,
            this.Menu_Transaksi,
            this.Menu_Laporan,
            this.Menu_Pengaturan,
            this.Menu_Tentang});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_Login,
            this.Submenu_Logout,
            this.toolStripMenuItem1,
            this.Submenu_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(37, 20);
            this.Menu_File.Text = "&File";
            // 
            // Submenu_Login
            // 
            this.Submenu_Login.Name = "Submenu_Login";
            this.Submenu_Login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.Submenu_Login.Size = new System.Drawing.Size(184, 22);
            this.Submenu_Login.Text = "&Login";
            this.Submenu_Login.Click += new System.EventHandler(this.Submenu_Login_Click);
            // 
            // Submenu_Logout
            // 
            this.Submenu_Logout.Enabled = false;
            this.Submenu_Logout.Name = "Submenu_Logout";
            this.Submenu_Logout.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.Submenu_Logout.Size = new System.Drawing.Size(184, 22);
            this.Submenu_Logout.Text = "&Logout";
            this.Submenu_Logout.Click += new System.EventHandler(this.Submenu_Logout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // Submenu_Exit
            // 
            this.Submenu_Exit.Name = "Submenu_Exit";
            this.Submenu_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Submenu_Exit.Size = new System.Drawing.Size(184, 22);
            this.Submenu_Exit.Text = "&Exit";
            this.Submenu_Exit.Click += new System.EventHandler(this.Submenu_Exit_Click);
            // 
            // Menu_Master
            // 
            this.Menu_Master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_Barang,
            this.Submenu_Pelanggan});
            this.Menu_Master.Name = "Menu_Master";
            this.Menu_Master.Size = new System.Drawing.Size(55, 20);
            this.Menu_Master.Text = "&Master";
            // 
            // Submenu_Barang
            // 
            this.Submenu_Barang.Name = "Submenu_Barang";
            this.Submenu_Barang.Size = new System.Drawing.Size(130, 22);
            this.Submenu_Barang.Text = "&Barang";
            this.Submenu_Barang.Click += new System.EventHandler(this.Submenu_Barang_Click);
            // 
            // Submenu_Pelanggan
            // 
            this.Submenu_Pelanggan.Name = "Submenu_Pelanggan";
            this.Submenu_Pelanggan.Size = new System.Drawing.Size(130, 22);
            this.Submenu_Pelanggan.Text = "&Pelanggan";
            this.Submenu_Pelanggan.Click += new System.EventHandler(this.Submenu_Pelanggan_Click);
            // 
            // Menu_Transaksi
            // 
            this.Menu_Transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_Penjualan});
            this.Menu_Transaksi.Name = "Menu_Transaksi";
            this.Menu_Transaksi.Size = new System.Drawing.Size(67, 20);
            this.Menu_Transaksi.Text = "&Transaksi";
            // 
            // Submenu_Penjualan
            // 
            this.Submenu_Penjualan.Name = "Submenu_Penjualan";
            this.Submenu_Penjualan.Size = new System.Drawing.Size(126, 22);
            this.Submenu_Penjualan.Text = "&Penjualan";
            this.Submenu_Penjualan.Click += new System.EventHandler(this.Submenu_Penjualan_Click);
            // 
            // Menu_Laporan
            // 
            this.Menu_Laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_LapBarang,
            this.Submenu_LapPelanggan});
            this.Menu_Laporan.Name = "Menu_Laporan";
            this.Menu_Laporan.Size = new System.Drawing.Size(62, 20);
            this.Menu_Laporan.Text = "&Laporan";
            // 
            // Submenu_LapBarang
            // 
            this.Submenu_LapBarang.Name = "Submenu_LapBarang";
            this.Submenu_LapBarang.Size = new System.Drawing.Size(176, 22);
            this.Submenu_LapBarang.Text = "&Laporan Barang";
            this.Submenu_LapBarang.Click += new System.EventHandler(this.Submenu_LapBarang_Click);
            // 
            // Submenu_LapPelanggan
            // 
            this.Submenu_LapPelanggan.Name = "Submenu_LapPelanggan";
            this.Submenu_LapPelanggan.Size = new System.Drawing.Size(176, 22);
            this.Submenu_LapPelanggan.Text = "&Laporan Pelanggan";
            this.Submenu_LapPelanggan.Click += new System.EventHandler(this.Submenu_LapPelanggan_Click);
            // 
            // Menu_Pengaturan
            // 
            this.Menu_Pengaturan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_UbahKataSandi,
            this.Submenu_TambahkanAkun});
            this.Menu_Pengaturan.Name = "Menu_Pengaturan";
            this.Menu_Pengaturan.Size = new System.Drawing.Size(80, 20);
            this.Menu_Pengaturan.Text = "&Pengaturan";
            // 
            // Submenu_UbahKataSandi
            // 
            this.Submenu_UbahKataSandi.Name = "Submenu_UbahKataSandi";
            this.Submenu_UbahKataSandi.Size = new System.Drawing.Size(167, 22);
            this.Submenu_UbahKataSandi.Text = "&Ubah Kata Sandi";
            this.Submenu_UbahKataSandi.Click += new System.EventHandler(this.Submenu_UbahKataSandi_Click);
            // 
            // Submenu_TambahkanAkun
            // 
            this.Submenu_TambahkanAkun.Name = "Submenu_TambahkanAkun";
            this.Submenu_TambahkanAkun.Size = new System.Drawing.Size(167, 22);
            this.Submenu_TambahkanAkun.Text = "&Tambahkan Akun";
            this.Submenu_TambahkanAkun.Click += new System.EventHandler(this.Submenu_TambahkanAkun_Click);
            // 
            // Menu_Tentang
            // 
            this.Menu_Tentang.Name = "Menu_Tentang";
            this.Menu_Tentang.Size = new System.Drawing.Size(62, 20);
            this.Menu_Tentang.Text = "&Tentang";
            this.Menu_Tentang.Click += new System.EventHandler(this.Menu_Tentang_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toolbar_Barang,
            this.Toolbar_Pelanggan,
            this.toolStripSeparator1,
            this.Toolbar_Transaksi});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // Toolbar_Barang
            // 
            this.Toolbar_Barang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Toolbar_Barang.Image = global::TOKO.Properties.Resources.iconfinder_dropbox_306198;
            this.Toolbar_Barang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Toolbar_Barang.Name = "Toolbar_Barang";
            this.Toolbar_Barang.Size = new System.Drawing.Size(23, 22);
            this.Toolbar_Barang.ToolTipText = "Data Barang";
            this.Toolbar_Barang.Click += new System.EventHandler(this.Toolbar_Barang_Click);
            // 
            // Toolbar_Pelanggan
            // 
            this.Toolbar_Pelanggan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Toolbar_Pelanggan.Image = global::TOKO.Properties.Resources.iconfinder_account_circle_326497;
            this.Toolbar_Pelanggan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Toolbar_Pelanggan.Name = "Toolbar_Pelanggan";
            this.Toolbar_Pelanggan.Size = new System.Drawing.Size(23, 22);
            this.Toolbar_Pelanggan.ToolTipText = "Data Pelanggan";
            this.Toolbar_Pelanggan.Click += new System.EventHandler(this.Toolbar_Pelanggan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Toolbar_Transaksi
            // 
            this.Toolbar_Transaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Toolbar_Transaksi.Image = global::TOKO.Properties.Resources.iconfinder_calc_42174;
            this.Toolbar_Transaksi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Toolbar_Transaksi.Name = "Toolbar_Transaksi";
            this.Toolbar_Transaksi.Size = new System.Drawing.Size(23, 22);
            this.Toolbar_Transaksi.ToolTipText = "Transaksi";
            this.Toolbar_Transaksi.Click += new System.EventHandler(this.Toolbar_Transaksi_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel_NamaUser,
            this.toolStripStatusLabel_NamaPengguna});
            this.statusStrip.Location = new System.Drawing.Point(0, 294);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel.Text = "SMK N  1 BANGSRI";
            // 
            // toolStripStatusLabel_NamaUser
            // 
            this.toolStripStatusLabel_NamaUser.Name = "toolStripStatusLabel_NamaUser";
            this.toolStripStatusLabel_NamaUser.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel_NamaPengguna
            // 
            this.toolStripStatusLabel_NamaPengguna.Name = "toolStripStatusLabel_NamaPengguna";
            this.toolStripStatusLabel_NamaPengguna.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel_NamaPengguna.Text = "USER";
            // 
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TOKO.Properties.Resources.ecommerce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 316);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu_Utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "== APLIKASI PENJUALAN ==";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem Menu_File;
        public System.Windows.Forms.ToolStripMenuItem Submenu_Login;
        public System.Windows.Forms.ToolStripMenuItem Submenu_Logout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem Submenu_Exit;
        public System.Windows.Forms.ToolStripMenuItem Menu_Master;
        public System.Windows.Forms.ToolStripMenuItem Submenu_Barang;
        public System.Windows.Forms.ToolStripMenuItem Submenu_Pelanggan;
        public System.Windows.Forms.ToolStripMenuItem Menu_Transaksi;
        public System.Windows.Forms.ToolStripMenuItem Submenu_Penjualan;
        public System.Windows.Forms.ToolStripMenuItem Menu_Laporan;
        public System.Windows.Forms.ToolStripMenuItem Submenu_LapBarang;
        public System.Windows.Forms.ToolStripMenuItem Submenu_LapPelanggan;
        public System.Windows.Forms.ToolStripMenuItem Menu_Pengaturan;
        public System.Windows.Forms.ToolStripMenuItem Submenu_UbahKataSandi;
        public System.Windows.Forms.ToolStripMenuItem Submenu_TambahkanAkun;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tentang;
        private System.Windows.Forms.ToolStripButton Toolbar_Barang;
        private System.Windows.Forms.ToolStripButton Toolbar_Pelanggan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Toolbar_Transaksi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_NamaUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_NamaPengguna;
    }
}



