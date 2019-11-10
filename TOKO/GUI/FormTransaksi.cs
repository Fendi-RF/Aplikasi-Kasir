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
    public partial class FormTransaksi : Form
    {
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter sda;
        Class.Koneksi konn = new Class.Koneksi();

        void tombol_disable(bool status)
        {
            textBox_idPelanggan.Enabled = status;
            textBox_NamaPelanggan.Enabled = status;
            textBox_KodeBarang.Enabled = status;
            textBox_NamaBarang.Enabled = status;
            textBox_HargaBarang.Enabled = status;
            button_Minus.Enabled = status;
            button_Simpan.Enabled = status;
            dateTimePicker_TanggalKwitansi.Enabled = status;

        }

        void bersih()
        {
            dateTimePicker_TanggalKwitansi.Value = DateTime.Now;
            textBox_idPelanggan.Text = "";
            textBox_NamaPelanggan.Text="";
            textBox_NamaBarang.Text = "";
            textBox_KodeBarang.Text = "";
            textBox_HargaBarang.Text = "0";
            textBox_JumlahBarang.Text = "0";
            tombol_disable(false);
        }
        private void awal()
        {
            bersih();
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from vw_dtlpenjualan order by NoKwitansi desc", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "vw_dtlpenjualan");
                dataGridView_Transaksi.DataSource = ds;
                dataGridView_Transaksi.DataMember = "vw_dtlpenjualan";
                dataGridView_Transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_Transaksi.AllowUserToAddRows = false;
                dataGridView_Transaksi.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            button1.Enabled = true;
            button2.Enabled = true;
        }
        void autonumber()
        {
            long hitung;
            string urut;
            string tgl;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NoKwitansi from vw_dtlpenjualan  where NoKwitansi in (select max(NoKwitansi) from vw_dtlpenjualan) order by NoKwitansi desc", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            tgl = DateTime.Now.ToString("dd/MM/yyyy");
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoKwitansi"].ToString().Length - 15, 4)) + 1;                
                string joinstr = "0000" + hitung;
                urut = "Trx-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + tgl;
            }
            else
            {
                urut = "Trx-0001" + "/" + tgl;
            }
            rd.Close();
            textBox_NoKwitansi.Text = urut;
            textBox_NoKwitansi.Enabled = false;
            conn.Close();
        }
        private void SimpanPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_penjualan values('" + textBox_NoKwitansi.Text + "', '" + dateTimePicker_TanggalKwitansi.Text + "', '" + textBox_idPelanggan.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void SimpanDetailPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_detailpenjualan values('" + textBox_NoKwitansi.Text + "', '" + textBox_KodeBarang.Text + "', '" + textBox_JumlahBarang.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private bool validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(textBox_idPelanggan.Text))
            {
                ep.Clear();
                ep.SetError(textBox_NamaPelanggan, "Pilih pelanggan terlebih dahulu");
            }
            else if (string.IsNullOrEmpty(textBox_KodeBarang.Text))
            {
                ep.Clear();
                ep.SetError(textBox_NamaBarang, "Pilih barang terlebih dahulu");
            }
            else if (textBox_JumlahBarang.Text == "0")
            {
                ep.Clear();
                ep.SetError(textBox_JumlahBarang, "Jumlah barang belum diisi");
            }
            return result;
        }
        private void refresh_penjualan()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from vw_dtlpenjualan where NoKwitansi = '" + textBox_NoKwitansi.Text + "'", conn);
                ds = new DataSet();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "vw_dtlpenjualan");
                dataGridView_Transaksi.DataSource = ds;
                dataGridView_Transaksi.DataMember = "vw_dtlpenjualan";
                dataGridView_Transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_Transaksi.AllowUserToAddRows = false;
                dataGridView_Transaksi.Refresh();
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
        private void refresh_transaksi()
        {
            refresh_penjualan();
            textBox_KodeBarang.Clear();
            textBox_NamaBarang.Clear();
            textBox_HargaBarang.Text = "0";
            textBox_JumlahBarang.Text="0";
            textBox_JumlahBarang.Focus();
        }
        void TotalHarga()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select sum(Harga*Jumlah) as TotalBayar from vw_dtlpenjualan where NoKwitansi = '" + textBox_NoKwitansi.Text + "'", conn);
                cmd.Connection= conn;
                int result =((int)cmd.ExecuteScalar());
                string TotalHarga = result.ToString();
                label_Total.Text = result.ToString();
                cmd.ExecuteNonQuery();
            }
        }
        void cetak()
        {
            Report.LaporanTransaksi ltrx = new Report.LaporanTransaksi(textBox_NoKwitansi.Text);
            ltrx.Show();
        }

        public FormTransaksi()
        {
            InitializeComponent();
            awal();
            autonumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogPelanggan dplgn = new DialogPelanggan();
            dplgn.ShowDialog();
            textBox_idPelanggan.Text = dplgn.AmbilIdPelanggan;
            textBox_NamaPelanggan.Text = dplgn.AmbilNamaPelanggan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogBarang dbrg = new DialogBarang();
            dbrg.ShowDialog();
            textBox_KodeBarang.Text = dbrg.AmbilKodeBarang;
            textBox_NamaBarang.Text = dbrg.AmbilNamaBarang;
            textBox_HargaBarang.Text = dbrg.AmbilHargaBarang;
        }

        private void button_Baru_Click(object sender, EventArgs e)
        {
            awal();
            autonumber();
            dateTimePicker_TanggalKwitansi.Focus();
            button_Plus.Enabled=true;
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            SqlDataReader rd= null;
            SqlConnection conn = konn.GetConn();
            conn.Open();
                if (textBox_KodeBarang.Text.Trim() == "" || textBox_idPelanggan.Text.Trim() == "" || textBox_JumlahBarang.Text.Trim() == "" || textBox_NoKwitansi.Text.Trim() == "" || textBox_JumlahBarang.Text.Trim() == "0")
                {
                }
                else
                {
                    try
                    {
                        cmd = new SqlCommand("select * from tbl_penjualan where NoKwitansi = '" + textBox_NoKwitansi.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            SimpanDetailPenjualan();
                        }
                        else
                        {
                            SimpanPenjualan();
                            SimpanDetailPenjualan();
                        }
                        MessageBox.Show("Data Berhasil Disimpan", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button1.Enabled = false;
                        button2.Enabled = false;
                        groupBox_TransaksiPenjualan.Enabled = true;
                        button_Simpan.Enabled = true;
                        refresh_transaksi();
                        TotalHarga();
                        awal();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
            }
        }
        private void dataGridView_Transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_Plus.Enabled = false;
                button_Minus.Enabled = true;
                DataGridViewRow row = this.dataGridView_Transaksi.Rows[e.RowIndex];
                textBox_NoKwitansi.Text = row.Cells["NoKwitansi"].Value.ToString();
                textBox_idPelanggan.Text = row.Cells["IdPelanggan"].Value.ToString();
                textBox_NamaPelanggan.Text = row.Cells["NamaPelanggan"].Value.ToString();
                textBox_KodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox_NamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox_HargaBarang.Text = row.Cells["Harga"].Value.ToString();
                textBox_JumlahBarang.Text = row.Cells["Jumlah"].Value.ToString();
                TotalHarga();
                button_Simpan.Enabled=true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus Transaksi : '" + textBox_NamaBarang.Text + "'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("delete from tbl_detailpenjualan where NoKwitansi ='" + textBox_NoKwitansi.Text + "' and KodeBarang = '" + textBox_KodeBarang.Text + "' ", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_transaksi();
                    awal();
                    button_Plus.Enabled = true;
                    button_Minus.Enabled = false;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
        private void button_Simpan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaksi Selesai");

            awal();
            label_Total.Text = "0";
            button1.Enabled = true;
            button2.Enabled = true;
            autonumber();
            cetak();
        }
    }
}
