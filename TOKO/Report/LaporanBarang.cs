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
    public partial class LaporanBarang : Form
    {
        Class.Koneksi konn = new Class.Koneksi();
        SqlDataAdapter sda;
        DataSet ds;
        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                sda = new SqlDataAdapter("select * from tbl_barang order by KodeBarang asc", conn);
                ds = new DataSet();
                sda.Fill(ds, "tbl_barang");
                Report_Barang myreport = new Report_Barang();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                crystalReportViewer1.Refresh();
            }

        }
        public LaporanBarang()
        {
            InitializeComponent();
            cetak();
        }
    }
}
