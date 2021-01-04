using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class TheThuVienDAL
    {
        private DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;

        public TheThuVienDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllTheThuVien()
        {
            // tạo câu lệnh sql
            string sql = "Select * from THETHUVIEN";
            // Tạo kết nối sql
            SqlConnection con = dc.GetConnection();
            //Khởi tạo đối tượng lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            con.Open();
            // đổ dữ liệu từ dataAapter vào datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            // đóng kết nối
            con.Close();
            return dt;
        }
        // thêm itemách hàng
        public bool InsertTheThuVien(tblTheThuVien item)
        {
            string sql = "insert into THETHUVIEN(MATHETHUVIEN, NGAYLAPTHE, NGAYHETHAN, MADOCGIA,CTMUONTRA) " +
                "VALUES(@MATHE, @NGAYLAPTHE, @NGAYHETHAN, @MADOCGIA,@CTMUONTRA)";

           
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATHE", SqlDbType.Int).Value = item.MATHE;
                cmd.Parameters.Add("@NGAYLAPTHE", SqlDbType.NVarChar).Value = item.NGAYLAPTHE;
                cmd.Parameters.Add("@NGAYHETHAN", SqlDbType.NVarChar).Value = item.NGAYHETHAN;
                cmd.Parameters.Add("@MADOCGIA", SqlDbType.Int).Value = item.MADOCGIA;
                cmd.Parameters.Add("@CTMUONTRA", SqlDbType.Int).Value = item.MADOCGIA;

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // chỉnh sửa Sach
        public bool UpdateTheThuVien(tblTheThuVien item)
        {
            string sql = "Update THETHUVIEN " +
                "set MATHETHUVIEN = @MATHE, NGAYLAPTHE = @NGAYLAPTHE, NGAYHETHAN=@NGAYHETHAN, MADOCGIA=@MADOCGIA, CTMUONTRA=@CTMUONTRA" +
                " WHERE MATHETHUVIEN = @MATHE";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATHE", SqlDbType.Int).Value = item.MATHE;
                cmd.Parameters.Add("@NGAYLAPTHE", SqlDbType.NVarChar).Value = item.NGAYLAPTHE;
                cmd.Parameters.Add("@NGAYHETHAN", SqlDbType.NVarChar).Value = item.NGAYHETHAN;
                cmd.Parameters.Add("@MADOCGIA", SqlDbType.Int).Value = item.MADOCGIA;
                cmd.Parameters.Add("@CTMUONTRA", SqlDbType.Int).Value = item.MADOCGIA;


                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // xóa itemách hàng
        public bool DeleteTheThuVien(tblTheThuVien item)
        {
            string sql = "Delete THETHUVIEN Where MATHETHUVIEN = @MATHE";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATHE", SqlDbType.Int).Value = item.MATHE;

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
