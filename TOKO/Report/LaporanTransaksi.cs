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
using CrystalDecisions.CrystalReports.Engine;

namespace TOKO.Report
{
    public partial class LaporanTransaksi : Form
    {
        SqlDataAdapter sda;
        DataSet ds;
        Class.Koneksi konn = new Class.Koneksi();
        private string NoKwitansi;

        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                sda = new SqlDataAdapter("select * from vw_cetaktransaksirev order by NoKwitansi asc", conn);
                ds = new DataSet();
                sda.Fill(ds, "vw_cetaktransaksirev");
                Report_Transaksi myreport = new Report_Transaksi();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                crystalReportViewer1.Refresh();
            }
        }
        public LaporanTransaksi(string NoKwitansi)
        {
            InitializeComponent();
        }

        private void LaporanTransaksi_Load(object sender, EventArgs e)
        {
            cetak();
        }
    }
}
