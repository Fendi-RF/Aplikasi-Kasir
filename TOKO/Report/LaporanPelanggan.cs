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
    public partial class LaporanPelanggan : Form
    {
        SqlDataAdapter sda;
        DataSet ds;
        Class.Koneksi konn = new Class.Koneksi();

        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                sda = new SqlDataAdapter("select * from tbl_pelanggan order by IdPelanggan asc", conn);
                ds = new DataSet();
                sda.Fill(ds, "tbl_pelanggan");
                Report_Pelanggan myreport = new Report_Pelanggan();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                crystalReportViewer1.Refresh();
            }
        }
        public LaporanPelanggan()
        {
            InitializeComponent();
            cetak();
        }
    }
}
