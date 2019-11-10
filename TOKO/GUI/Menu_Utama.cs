using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOKO.GUI
{
    public partial class Menu_Utama : Form
    {
        public void menuadmin(bool status)
        {
            Menu_Master.Enabled = status;
            Menu_Laporan.Enabled = status;
            Menu_Transaksi.Enabled = status;
            Menu_Pengaturan.Enabled = status;
            Toolbar_Barang.Enabled = status;
            Toolbar_Pelanggan.Enabled = status;
            Toolbar_Transaksi.Enabled = status;
        }
        public void menukasir(bool status)
        {
            Menu_Laporan.Enabled = status;
            Menu_Transaksi.Enabled = status;
            Menu_Pengaturan.Enabled = status;
            Submenu_TambahkanAkun.Enabled = false;
            Toolbar_Transaksi.Enabled = status;
        }

        FormUbahSandi ubhsnd;
        void ubhsnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            ubhsnd = null;
        }
        FormBarang brg;
        void brg_FormClosed(Object sender, FormClosedEventArgs e)
        {
            brg = null;
        }
        FormPelanggan plg;
        void plg_FormClosed(Object sender, FormClosedEventArgs e)
        {
            plg = null;
        }
        FormTransaksi trns;
        void trns_FormClosed(Object sender, FormClosedEventArgs e)
        {
            trns = null;
        }
        FormLogin lgn;
        void lgn_FormClosed(object sender, FormClosedEventArgs e)
        {
            lgn = null;
        }
        FormTambahAkun ta;
        void ta_FormClosed(object sender, FormClosedEventArgs e)
        {
            ta = null;
        }
        DialogLogin dlgin = new DialogLogin();
        public Menu_Utama()
        {
            InitializeComponent();
            FormLogin flgn = new FormLogin();
            toolStripStatusLabel_NamaPengguna.Text = flgn.AmbilNamaPengguna;
        }

        private void Submenu_Barang_Click(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new FormBarang();
                brg.MdiParent = this;
                brg.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void Submenu_Pelanggan_Click(object sender, EventArgs e)
        {
            if (plg == null)
            {
                plg = new FormPelanggan();
                plg.MdiParent = this;
                plg.FormClosed += new FormClosedEventHandler(plg_FormClosed);
                plg.Show();
            }
            else
            {
                plg.Activate();
            }
        }

        private void Submenu_Penjualan_Click(object sender, EventArgs e)
        {
            if (trns == null)
            {
                trns = new FormTransaksi();
                trns.MdiParent = this;
                trns.FormClosed += new FormClosedEventHandler(trns_FormClosed);
                trns.Show();
            }
            else
            {
                trns.Activate();
            }
        }

        private void Toolbar_Barang_Click(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new FormBarang();
                brg.MdiParent = this;
                brg.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void Toolbar_Pelanggan_Click(object sender, EventArgs e)
        {
            if (plg == null)
            {
                plg = new FormPelanggan();
                plg.MdiParent = this;
                plg.FormClosed += new FormClosedEventHandler(plg_FormClosed);
                plg.Show();
            }
            else
            {
                plg.Activate();
            }
        }

        private void Toolbar_Transaksi_Click(object sender, EventArgs e)
        {
            if (trns == null)
            {
                trns = new FormTransaksi();
                trns.MdiParent = this;
                trns.FormClosed += new FormClosedEventHandler(trns_FormClosed);
                trns.Show();
            }
            else
            {
                trns.Activate();
            }
        }

        private void Submenu_Login_Click(object sender, EventArgs e)
        {
            if (lgn == null)
            {
                lgn = new FormLogin();
                lgn.MdiParent = this;
                lgn.FormClosed += new FormClosedEventHandler(lgn_FormClosed);
                lgn.Show();
            }
            else
            {
                lgn.Activate();
            }
        }

        private void Submenu_TambahkanAkun_Click(object sender, EventArgs e)
        {
            if (ta == null)
            {
                ta = new FormTambahAkun();
                ta.MdiParent = this;
                ta.FormClosed += new FormClosedEventHandler(ta_FormClosed);
                ta.Show();
            }
            else
            {
                ta.Activate();
            }
        }

        private void Submenu_Logout_Click(object sender, EventArgs e)
        {
            DialogLogout dlogo = new DialogLogout();
            dlogo.ShowDialog();
        }

        private void Submenu_UbahKataSandi_Click(object sender, EventArgs e)
        {
            if (ubhsnd == null)
            {
                ubhsnd = new FormUbahSandi();
                ubhsnd.MdiParent = this;
                ubhsnd.FormClosed += new FormClosedEventHandler(ubhsnd_FormClosed);
                ubhsnd.Show();
            }
            else
            {
                ubhsnd.Activate();
            }
        }

        private void Submenu_LapBarang_Click(object sender, EventArgs e)
        {
            Report.LaporanBarang lbrg = new Report.LaporanBarang();
            lbrg.Show();
        }

        private void Submenu_LapPelanggan_Click(object sender, EventArgs e)
        {
            Report.LaporanPelanggan lplgn = new Report.LaporanPelanggan();
            lplgn.Show();
        }

        private void Submenu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Tentang_Click(object sender, EventArgs e)
        {
            FormTentang tntg = new FormTentang();
            tntg.Show();
        }
    }
}
