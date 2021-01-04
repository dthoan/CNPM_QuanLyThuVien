using QuanLyThuVien.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class FrmTimKiemSach : Form
    {
        SachBLL bllSach;

        DataConnection dc;

        private SqlDataAdapter da;
        private SqlCommand cmd;
        SqlConnection conn;
        public FrmTimKiemSach()
        {
            dc = new DataConnection();
            bllSach = new SachBLL();
            InitializeComponent();
        }
       
        public void ShowAllSach()
        {
            DataTable dt = bllSach.getAllSach();
            dataGridViewTimKiemSach.DataSource = dt;
        }


        public DataTable XemDL(string sql)
        {
            conn = dc.GetConnection();
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
            conn.Close();
        }
        

        private void txtTu_TextChanged(object sender, EventArgs e)
        {
            if (cbbTimKiem.Text == "Mã Sách")
            {
                dataGridViewTimKiemSach.DataSource = XemDL("select * from SACH where MASACH like '%" + txtTu.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Tên Sách")
            {
                dataGridViewTimKiemSach.DataSource = XemDL("select * from SACH where TENSACH like '%" + txtTu.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Thể Loại")
            {
                dataGridViewTimKiemSach.DataSource = XemDL("select * from SACH where THELOAI like '%" + txtTu.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Nhà Xuất Bản")
            {
                dataGridViewTimKiemSach.DataSource = XemDL("select * from SACH where NXB like '%" + txtTu.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Tác Giả")
            {
                dataGridViewTimKiemSach.DataSource = XemDL("select * from SACH where TACGIA like '%" + txtTu.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Số Trang")
            {
                dataGridViewTimKiemSach.DataSource = XemDL("select * from SACH where SOTRANG like '%" + txtTu.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Năm Xuất Bản")
            {
                dataGridViewTimKiemSach.DataSource = XemDL("select * from SACH where NAWMXUATBAN like '%" + txtTu.Text.Trim() + "%'");
            }

        }

        private void FrmTimKiemSach_Load(object sender, EventArgs e)
        {
            this.ShowAllSach();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbbTimKiem.Items.Clear();
            txtTu.ResetText();
        }
    }
}
