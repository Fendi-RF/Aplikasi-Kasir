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
    public partial class FormTambahAkun : Form
    {

        Class.Koneksi konn = new Class.Koneksi();

        void awal()
        {
            textBox_User.Text = "";
            textBox_Password.Text = "";
            comboBox_Kelas.Text = "==Pilih Kelas==";
        }
        void refencrypt()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            SqlCommand enc = new SqlCommand("update tbl_pengguna set KataSandi = pwdencrypt('" + textBox_Password + "')", conn);
            enc.ExecuteReader();
            conn.Close();
        }
        public FormTambahAkun()
        {
            InitializeComponent();
            awal();
        }

        private void button_TambahAkun_Click(object sender, EventArgs e)
        {

            SqlConnection conn = konn.GetConn();
            if (textBox_User.Text.Trim() == "" || textBox_Password.Text.Trim() == "" || comboBox_Kelas.Text.Trim() == "==Pilih Kelas==" || textBox_KonfPassword.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (textBox_Password.Text.Trim() == textBox_KonfPassword.Text.Trim())
                {
                    string Password = Class.Encrypt.Enkripsi(textBox_Password.Text);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbl_pengguna values('" + textBox_User.Text + "', '" +Password+ "', '" + comboBox_Kelas.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Akun Telah Ditambahkan", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kata sandi dan Konfirmasinya tidak sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
