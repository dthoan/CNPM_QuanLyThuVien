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
    public partial class FrmTimKiemDocGia : Form
    {
        DocGiaBLL bllDocGia;

        DataConnection dc;

        private SqlDataAdapter da;
        private SqlCommand cmd;
        SqlConnection conn;
        public FrmTimKiemDocGia()
        {
            dc = new DataConnection();
            bllDocGia = new DocGiaBLL();
            InitializeComponent();
        }
        public void ShowAllDocGia()
        {
            DataTable dt = bllDocGia.getAllDocGia();
            dataGridViewTimKiemDocGia.DataSource = dt;

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
            if(cbbDocGia.Text == "Mã Đọc Giả")
            {
                dataGridViewTimKiemDocGia.DataSource = XemDL("select * from DOCGIAS where MADOCGIA like '%" + txtTu.Text.Trim() + "%'");
            }
            if (cbbDocGia.Text == "Họ Tên")
            {
                dataGridViewTimKiemDocGia.DataSource = XemDL("select * from DOCGIAS where HOTEN like '%" + txtTu.Text.Trim() + "%'");
            }
            if (cbbDocGia.Text == "Số Điện Thoại")
            {
                dataGridViewTimKiemDocGia.DataSource = XemDL("select * from DOCGIAS where SDT like '%" + txtTu.Text.Trim() + "%'");
            }
            if (cbbDocGia.Text == "Email")
            {
                dataGridViewTimKiemDocGia.DataSource = XemDL("select * from DOCGIAS where EMAIL like '%" + txtTu.Text.Trim() + "%'");
            }
          
        }

        private void dataGridViewTimKiemDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTimKiemDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowAllDocGia();
        }

        private void FrmTimKiemDocGia_Load(object sender, EventArgs e)
        {
            this.ShowAllDocGia();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            this.txtTu.ResetText();
        }
    }
}
