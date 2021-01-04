using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(conStr);
        }
    }
}
