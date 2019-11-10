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
    public partial class FormBarang : Form
    {
        //Deklarasi
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        Class.Koneksi konn = new Class.Koneksi();

        //Fungsi Kotak kosong
        void bersih()
        {
            textBox_KodeBarang.Text = "";
            textBox_NamaBarang.Text = "";
            textBox_Harga.Text = "0";
            textBox_Stok.Text = "0";
            comboBox_Satuan.Text = "--Pilih Satuan--";
            textBox_Cari.Text = "";
        }

        //Tombol disabled
        void tombol_awal(Boolean status)
        {
            button_Hapus.Enabled = status;
            button_Edit.Enabled = status;
        }

        //Fungsi Refresh Barang
        void refresh_barang()
        {
            SqlConnection conn = konn.GetConn(); {
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
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        //Fungsi Cari Barang
        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang where KodeBarang like '%"+textBox_Cari.Text+"%' or NamaBarang like '%"+textBox_Cari.Text+"%'", conn);
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
        void autonumber()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeBarang from tbl_barang  where KodeBarang in (select max(KodeBarang) from tbl_barang) order by kodeBarang desc", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "B" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "B001";
            }
            rd.Close();
            textBox_KodeBarang.Text = urut;
            textBox_KodeBarang.Enabled = false;
            conn.Close();
        }


        public FormBarang()
        {
            InitializeComponent();
            bersih();
            //Disable edit dan hapus
            tombol_awal(false);
            refresh_barang();
            autonumber();
        }

        private void textBox_Cari_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
            autonumber();
        }

        private void button_Simpan_Click(object sender, EventArgs e)
        {
            if (validation())
            {


                if (textBox_Harga.Text.Trim() == "" || textBox_KodeBarang.Text.Trim() == "" || textBox_NamaBarang.Text.Trim() == "" || textBox_Stok.Text.Trim() == "0" || comboBox_Satuan.Text.Trim() == "--Pilih Satuan--")
                {
                    
                }
                else
                {
                    SqlConnection conn = konn.GetConn();
                    try
                    {
                        cmd = new SqlCommand("insert into tbl_barang values ('" + textBox_KodeBarang.Text + "', '" + textBox_NamaBarang.Text + "','" + textBox_Harga.Text + "','" + textBox_Stok.Text + "','" + comboBox_Satuan.Text + "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Disimpan", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_barang();
                        bersih();
                        autonumber();
                        tombol_awal(false);
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
            }
        }
        private bool validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(textBox_NamaBarang.Text))
            {
                ep.Clear();
                ep.SetError(textBox_NamaBarang,"Nama Barang tidak boleh kosong");
            }
            else if (textBox_Harga.Text == "0")
            {
                ep.Clear();
                ep.SetError(textBox_Harga, "Harga belum diisi");
            }
            else if (textBox_Stok.Text == "0")
            {
                ep.Clear();
                ep.SetError(textBox_Stok, "Stok belum diisi");
            }
            else if (string.IsNullOrEmpty(comboBox_Satuan.Text))
            {
                ep.Clear();
                ep.SetError(comboBox_Satuan, "Pilih jenis satuan terlebih dahulu");
            }
            else
            {
                ep.Clear();
                result = true;
            }
            return result;
        }

        private void dataGridView_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_Simpan.Enabled = false;
                tombol_awal(true);
                DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                textBox_KodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox_NamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox_Harga.Text = row.Cells["Harga"].Value.ToString();
                textBox_Stok.Text = row.Cells["Stok"].Value.ToString();
                comboBox_Satuan.Text = row.Cells["Satuan"].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (textBox_Harga.Text.Trim() == "0" || textBox_KodeBarang.Text.Trim() == "" || textBox_NamaBarang.Text.Trim() == "" || textBox_Stok.Text.Trim() == "0" || comboBox_Satuan.Text.Trim() == "--Pilih Satuan--")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tbl_barang set NamaBarang = '"+textBox_NamaBarang.Text+"', Harga = '"+textBox_Harga.Text+"', Stok = '"+textBox_Stok.Text+"', Satuan = '"+comboBox_Satuan.Text+"' where KodeBarang = '"+textBox_KodeBarang.Text+"'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diedit", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
                    bersih();
                    tombol_awal(false);
                    autonumber();
                    button_Simpan.Enabled=true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin ingin menghapus barang : '"+textBox_NamaBarang.Text+"'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("delete from tbl_barang where KodeBarang = '"+textBox_KodeBarang.Text+"'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
                    bersih();
                    tombol_awal(false);
                    autonumber();
                    button_Simpan.Enabled = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_Buat_Click(object sender, EventArgs e)
        {
            bersih();
            tombol_awal(false);
            autonumber();
            button_Simpan.Enabled = true;
        }
    }
}
