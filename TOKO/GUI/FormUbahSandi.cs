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
    public partial class FormUbahSandi : Form
    {
        Class.Koneksi konn = new Class.Koneksi();
        void awal()
        {
            textBox_PasswordLama.Text = "";
            textBox_PasswordBaru.Text = "";
            textBox_KonfPasswordBaru.Text = "";
        }
        public FormUbahSandi()
        {
            InitializeComponent();
            awal();
        }

        private void button_UbahPassword_Click(object sender, EventArgs e)
        {
            string PasswordBaru = "";
            bool IsExist = false;
            SqlCommand cmd;
            SqlConnection conn = konn.GetConn();
            if (textBox_PasswordLama.Text.Trim() == "" || textBox_PasswordBaru.Text.Trim() == "" || textBox_KonfPasswordBaru.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pengguna where KataSandi = '" + textBox_PasswordLama.Text + "'", conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        IsExist = true;
                    }
                    if (IsExist)
                    {
                        if (textBox_PasswordBaru.Text.Trim() == textBox_KonfPasswordBaru.Text.Trim())
                        {
                            PasswordBaru = Class.Encrypt.Enkripsi(textBox_PasswordBaru.Text);
                            cmd = new SqlCommand("update tbl_pengguna set KataSandi = '"+PasswordBaru+"'", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kata Sandi berhasil diubah", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kata Sandi dan konfirmasinya tidak sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kata sandi lama anda salah/tidak terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
    }
}
