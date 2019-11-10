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
    public partial class FormLogin : Form
    {
        string NamaPengguna = "";
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter sda;
        Class.Koneksi konn = new Class.Koneksi();

        void kelas()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select Kelas from tbl_pengguna where NamaPengguna ='" + textBox_User.Text + "'", conn);
                cmd.Connection = conn;
                string Kelas = ((string)cmd.ExecuteScalar());
                cmd.ExecuteNonQuery();
            }

        }
        void awal()
        {
            textBox_User.Text = "";
            textBox_Password.Text = "";
        }
        public FormLogin()
        {
            InitializeComponent();
            awal();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            
            string Password = "";
            bool IsExist = false;
            SqlConnection conn = konn.GetConn();
            if (textBox_User.Text.Trim() == "" || textBox_Password.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pengguna where NamaPengguna = '" + textBox_User.Text + "'", conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    kelas();
                    if (rd.Read())
                    {
                        Password = rd.GetString(1);
                        IsExist = true;
                    }
                    if (IsExist)
                    {
                        if (Class.Encrypt.Dekripsi(Password).Equals(textBox_Password.Text))
                        {
                            string NamaPengguna = textBox_User.Text;
                            MessageBox.Show("Berhasil login sebagai " + textBox_User.Text + " ", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Menu_Utama mu = new Menu_Utama();
                            mu.Show();
                            
                           
                        }
                        else
                        {
                            MessageBox.Show("Kata Sandi salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            textBox_Password.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Akun yang anda masukkan salah/tidak terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox_Password.Text = "";
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                
            }
            
        }
        public string AmbilNamaPengguna
        {
            get
            {
                return NamaPengguna;
            }
        }
    }
}
