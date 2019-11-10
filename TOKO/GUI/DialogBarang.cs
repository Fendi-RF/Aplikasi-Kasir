using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TOKO.GUI
{
    public partial class DialogBarang : Form
    {
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter sda;
        public string KodeBarang, NamaBarang, HargaBarang;

        Class.Koneksi konn = new Class.Koneksi();
        void refresh_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang", conn);
                    ds = new DataSet();
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang where KodeBarang like '%" + textBox_Cari.Text + "%' or NamaBarang like '%" + textBox_Cari.Text + "%'", conn);
                    ds = new DataSet();
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void textBox_Cari_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
        }
        public DialogBarang()
        {
            InitializeComponent();
            refresh_barang();
        }
        public string AmbilKodeBarang
        {
            get
            {
                return KodeBarang;
            }
        }

        private void dataGridView_barang_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                    KodeBarang = row.Cells["KodeBarang"].Value.ToString();
                    NamaBarang = row.Cells["NamaBarang"].Value.ToString();
                    HargaBarang = row.Cells["Harga"].Value.ToString();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        public string AmbilNamaBarang
        {
            get
            {
                return NamaBarang;
            }
        }
        public string AmbilHargaBarang
        {
            get
            {
                return HargaBarang;
            }
        }
    }
}
