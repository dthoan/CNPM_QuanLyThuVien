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
    class DocGiaDAL
    {
        private DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;

        public DocGiaDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllDocGia()
        {
            // tạo câu lệnh sql
            string sql = "Select * from DOCGIAS";
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
        // thêm đọc giả
        public bool InsertDocGia(tblDocGia item)
        {
            string sql = "insert into  DOCGIAS(MADOCGIA, HOTEN, SDT, EMAIL) " +
                "VALUES(@MADOCGIA, @HOTEN, @SDT, @EMAIL)";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MADOCGIA", SqlDbType.Int).Value = item.MADOCGIA;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = item.HOTEN;              
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = item.SDT;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = item.EMAIL;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // chỉnh sửa DocGia
        public bool UpdateDocGia(tblDocGia item)
        {
            string sql = "Update DOCGIAS " +
                "set MADOCGIA = @MADOCGIA, HOTEN= @HOTEN, SDT=@SDT, EMAIL=@EMAIL" +
                " WHERE MADOCGIA = @MADOCGIA ";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MADOCGIA", SqlDbType.Int).Value = item.MADOCGIA;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = item.HOTEN;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = item.SDT;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = item.EMAIL;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // xóa sách
        public bool DeleteDocGia(tblDocGia item)
        {
            string sql = "Delete DOCGIAS Where MADOCGIA= @MADOCGIA";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MADOCGIA", SqlDbType.Int).Value = item.MADOCGIA;

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
