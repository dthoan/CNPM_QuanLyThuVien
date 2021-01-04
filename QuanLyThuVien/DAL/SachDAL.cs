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
    class SachDAL
    {
        private DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;

        public SachDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllSach()
        {
            // tạo câu lệnh sql
            string sql = "Select * from SACH";
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
        // thêm sách
        public bool InsertSach(tlbSach item)
        {
            string sql = "insert into SACH(MASACH,TENSACH,TACGIA,THELOAI,NXB,NAMXUATBAN,SOTRANG) " +
                "VALUES(@MASACH,@TENSACH,@TACGIA,@THELOAI,@NXB,@NAMXUATBAN,@SOTRANG)";

            //string sql = "Insert into Sach(MaSach, TenSach, GioiTinh, DiaChi, SDT, LoaiSach, GhiChu) " +
            //    "VALUES(" + item.MaSach + ",N'" + item.TenSach + "',N'" + item.GioiTinh + "',N'" + item.SDT + "',N'" + item.DiaChi + "'," + item.LoaiSach + ",N'" + item.GhiChu + "')";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASACH", SqlDbType.Int).Value = item.MASACH;
                cmd.Parameters.Add("@TENSACH", SqlDbType.NVarChar).Value = item.TENSACH;               
                cmd.Parameters.Add("@THELOAI", SqlDbType.Int).Value = item.THELOAI;
                cmd.Parameters.Add("@NXB", SqlDbType.Int).Value = item.NXB;
                cmd.Parameters.Add("@TACGIA", SqlDbType.Int).Value = item.TACGIA;           
                cmd.Parameters.Add("@NAMXUATBAN", SqlDbType.NVarChar).Value = item.NAMXUATBAN;
                cmd.Parameters.Add("@SOTRANG", SqlDbType.Int).Value = item.SOTRANG;              
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
        public bool UpdateSach(tlbSach item)
        {
            string sql = "Update SACH " +
                "set MASACH = @MASACH, TENSACH = @TENSACH, TACGIA=@TACGIA, THELOAI=@THELOAI, NXB=@NXB, NAMXUATBAN=@NAMXUATBAN, SOTRANG=@SOTRANG " +
                " WHERE MASACH = @MASACH ";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASACH", SqlDbType.Int).Value = item.MASACH;
                cmd.Parameters.Add("@TENSACH", SqlDbType.NVarChar).Value = item.TENSACH;
                cmd.Parameters.Add("@TACGIA", SqlDbType.Int).Value = item.TACGIA;
                cmd.Parameters.Add("@THELOAI", SqlDbType.Int).Value = item.THELOAI;
                cmd.Parameters.Add("@NXB", SqlDbType.Int).Value = item.NXB;
                cmd.Parameters.Add("@NAMXUATBAN", SqlDbType.NVarChar).Value = item.NAMXUATBAN;
                cmd.Parameters.Add("@SOTRANG", SqlDbType.Int).Value = item.SOTRANG;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // xóa  sách
        public bool DeleteSach(tlbSach item)
        {
            string sql = "Delete SACH Where MASACH= @MASACH";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MASACH", SqlDbType.Int).Value = item.MASACH;

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
