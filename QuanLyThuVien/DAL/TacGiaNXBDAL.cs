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
    class TacGiaNXBDAL
    {
        private DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;

        public TacGiaNXBDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllTacGia()
        {
            // tạo câu lệnh sql
            string sql = "Select * from TACGIA";
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
        // thêm TacGia
        public bool InsertTacGia(tblTacGia item)
        {
            string sql = "insert into TACGIA(C) " +
                "VALUES(@MATACGIA,@TENTACGIA)";

           
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATACGIA", SqlDbType.Int).Value = item.MATACGIA;
                cmd.Parameters.Add("@TENTACGIA", SqlDbType.NVarChar).Value = item.TENTACGIA;
              
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // chỉnh sửa TacGia
        public bool UpdateTacGia(tblTacGia item)
        {
            string sql = "Update TACGIA " +
                "set MATACGIA = @MATACGIA, TENTACGIA = @TENTACGIA" +
                " WHERE MATACGIA = @MATACGIA ";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATACGIA", SqlDbType.Int).Value = item.MATACGIA;
                cmd.Parameters.Add("@TENTACGIA", SqlDbType.NVarChar).Value = item.TENTACGIA;
              
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // xóa TacGia
        public bool DeleteTacGia(tblTacGia item)
        {
            string sql = "Delete SACH Where MATAGIA= @MATAGIA";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MATAGIA", SqlDbType.Int).Value = item.MATACGIA;

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        /// Nhà Xuất Bản
        /// Nhà Xuất Bản
        /// Nhà Xuất Bản
        /// Nhà Xuất Bản
        public DataTable getAllNXB()
        {
            // tạo câu lệnh sql
            string sql = "Select * from NXB";
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
        // thêm Nhà Xuất Bản
        public bool InsertNXB(tblNXB item)
        {
            string sql = "insert into NXB " +
                "VALUES(@MANXB,@TENNXB)";


            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANXB", SqlDbType.Int).Value = item.MANXB;
                cmd.Parameters.Add("@TENNXB", SqlDbType.NVarChar).Value = item.TENNXB;

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // chỉnh sửa Nhà Xuất Bản
        public bool UpdateNXB(tblNXB item)
        {
            string sql = "Update NXB " +
                "set MANXB = @MANXB, TENNXB = @TENNXB" +
                " WHERE MANXB = @MANXB ";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANXB", SqlDbType.Int).Value = item.MANXB;
                cmd.Parameters.Add("@TENNXB", SqlDbType.NVarChar).Value = item.TENNXB;

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // xóa Nhà Xuất Bản
        public bool DeleteNXB(tblNXB item)
        {
            string sql = "Delete NXB Where MANXB= @MANXB";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANXB", SqlDbType.Int).Value = item.MANXB;

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

