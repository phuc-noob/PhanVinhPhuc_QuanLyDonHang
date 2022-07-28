using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dbConnectionData
    {
        public static SqlConnection connect()
        {
            string strCon = @"Data Source=PHUCNOOB;Initial Catalog=QuanLyDonHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strCon);
            
            return conn;
        }
    }
}
