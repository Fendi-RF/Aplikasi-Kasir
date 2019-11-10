using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TOKO.Class
{
    class Koneksi
    {
        public SqlConnection GetConn() {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "SERVER=DELLXFND\\SQLEXPRESS; Initial Catalog=db_penjualan; Integrated Security=True";
            return conn;
    }
    }
}
