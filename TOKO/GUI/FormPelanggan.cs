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
    public partial class FormPelanggan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter sda;
        Class.Koneksi konn = new Class.Koneksi();
        void bersih()
        {
            textBox_IdPelanggan.Text = "";
            textBox_NamaPelanggan.Text = "";
            richTextBox_Alamat.Text = "";
            textBox_NoTelp.Text = "";
        }

        //Tombol disabled
        void tombol_awal(Boolean status)
        {
            button_Hapus.Enabled = status;
            button_Edit.Enabled = status;
        }

        //Fungsi Refresh Barang
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
        //Fungsi Cari Barang
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
        void autonumber()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select IdPelanggan from tbl_pelanggan  where IdPelanggan in (select max(IdPelanggan) from tbl_pelanggan) order by IdPelanggan desc", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IdPelanggan"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "P" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "B001";
            }
            rd.Close();
            textBox_IdPelanggan.Text = urut;
            textBox_IdPelanggan.Enabled = false;
            conn.Close();
        }
        public FormPelanggan()
        {
            InitializeComponent();
            bersih();
            tombol_awal(false);
            refresh_Pelanggan();
            autonumber();

        }

        private void dataGridView_Pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_Simpan.Enabled = false;
                tombol_awal(true);
                DataGridViewRow row = this.dataGridView_Pelanggan.Rows[e.RowIndex];
                textBox_IdPelanggan.Text = row.Cells["IdPelanggan"].Value.ToString();
                textBox_NamaPelanggan.Text = row.Cells["NamaPelanggan"].Value.ToString();
                richTextBox_Alamat.Text = row.Cells["Alamat"].Value.ToString();
                textBox_NoTelp.Text = row.Cells["NoTelp"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_Buat_Click(object sender, EventArgs e)
        {

            bersih();
            tombol_awal(false);
            autonumber();
            button_Simpan.Enabled = true;

        }
        private void button_Simpan_Click(object sender, EventArgs e)
        {
          if (validation())
           {
                if (textBox_IdPelanggan.Text.Trim() == "" || textBox_NamaPelanggan.Text.Trim() == "")
                {
                }
                else
                {
                    SqlConnection conn = konn.GetConn();
                    try
                    {
                        cmd = new SqlCommand("insert into tbl_pelanggan values ('" + textBox_IdPelanggan.Text + "', '" + textBox_NamaPelanggan.Text + "','" + richTextBox_Alamat.Text + "','" + textBox_NoTelp.Text + "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Disimpan", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_Pelanggan();
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
            if (string.IsNullOrEmpty(textBox_NamaPelanggan.Text))
            {
                ep.Clear();
                ep.SetError(textBox_NamaPelanggan, "Nama Pelanggan tidak boleh kosong");
            }
            return result;
        }


        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (textBox_IdPelanggan.Text.Trim() == "" || textBox_NamaPelanggan.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tbl_barang set NamaPelanggan = '" + textBox_NamaPelanggan.Text + "', Alamat = '" + richTextBox_Alamat.Text + "', NoTelp = '" + textBox_NoTelp.Text + "' where IdPelanggan = '" + textBox_IdPelanggan.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diedit", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_Pelanggan();
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

            private void button_Hapus_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Yakin ingin menghapus pelanggan : '" + textBox_NamaPelanggan.Text + "'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = konn.GetConn();
                    try
                    {
                        cmd = new SqlCommand("delete from tbl_pelanggan where IdPelanggan = '" + textBox_IdPelanggan.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_Pelanggan();
                        bersih();
                        tombol_awal(false);
                        button_Simpan.Enabled = true;
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
            }

        private void textBox_Cari_TextChanged_1(object sender, EventArgs e)
        {
            cari_Pelanggan();
        }

        private void textBox_NoTelp_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_NoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 46)
            {

            }
            else if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }
    }
    }