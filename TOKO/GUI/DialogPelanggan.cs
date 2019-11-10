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
    public partial class DialogPelanggan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        public string IdPelanggan, NamaPelanggan;
        Class.Koneksi konn = new Class.Koneksi();

        void refresh_Pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pelanggan", conn);
                    ds = new DataSet();
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds, "tbl_pelanggan");
                    dataGridView_Pelanggan.DataSource = ds;
                    dataGridView_Pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_Pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Pelanggan.AllowUserToAddRows = false;
                    dataGridView_Pelanggan.Refresh();

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
        void cari_Pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pelanggan where IdPelanggan like '%" + textBox_Cari.Text + "%' or NamaPelanggan like '%" + textBox_Cari.Text + "%'", conn);
                    ds = new DataSet();
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds, "tbl_pelanggan");
                    dataGridView_Pelanggan.DataSource = ds;
                    dataGridView_Pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_Pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_Pelanggan.AllowUserToAddRows = false;
                    dataGridView_Pelanggan.Refresh();

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
        
        public DialogPelanggan()
        {
            InitializeComponent();
            refresh_Pelanggan();
        }
        private void textBox_Cari_TextChanged(object sender, EventArgs e)
        {
            cari_Pelanggan();
        }
        public string AmbilIdPelanggan
        {
            get {
                return IdPelanggan;
            }
        }

        private void dataGridView_Pelanggan_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = this.dataGridView_Pelanggan.Rows[e.RowIndex];
                IdPelanggan = row.Cells["IdPelanggan"].Value.ToString();
                NamaPelanggan = row.Cells["NamaPelanggan"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public string AmbilNamaPelanggan
        {
            get
            {
                return NamaPelanggan;
            }
        }

    }
}
