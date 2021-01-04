using QuanLyThuVien.BLL;
using QuanLyThuVien.DTO;
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
    public partial class FrmDocGia : Form
    {
        DocGiaBLL bllDocGia;
        DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        SqlConnection conn;
        public FrmDocGia()
        {
            dc = new DataConnection();
            bllDocGia = new DocGiaBLL();
            InitializeComponent();
        }
        public void ShowAllDocGia()
        {
            DataTable dt = bllDocGia.getAllDocGia();
            dataGridViewDocGia.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void Resetext()
        {
            this.txtSDT.ResetText();
            this.txtMaDoCGia.ResetText();
            this.TXTEmail.ResetText();
            this.txtHoTen.ResetText();
        }
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            this.ResetText();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMaDoCGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã thẻ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDoCGia.Focus();
                return false;
            }


            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblDocGia Sach = new tblDocGia();
                Sach.MADOCGIA = int.Parse(txtMaDoCGia.Text);
                Sach.HOTEN = txtHoTen.Text;
                Sach.SDT = txtSDT.Text;
                Sach.EMAIL = TXTEmail.Text;
                if (bllDocGia.InsertDocGia(Sach))
                {
                    this.ShowAllDocGia();
                    this.ResetText();
                    MessageBox.Show("Bạn đã thêm đọc giả  thành công!", "Thông Báo!");

                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblDocGia Sach = new tblDocGia();
                Sach.MADOCGIA = int.Parse(txtMaDoCGia.Text);
                Sach.HOTEN = txtHoTen.Text;
                Sach.SDT = txtSDT.Text;
                Sach.EMAIL = TXTEmail.Text;
                if (bllDocGia.UpdateDocGia(Sach))
                {
                    this.ShowAllDocGia();
                    this.ResetText();
                    MessageBox.Show("Bạn đã sửa đọc giả  thành công!", "Thông Báo!");

                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblDocGia Sach = new tblDocGia();
                Sach.MADOCGIA = int.Parse(txtMaDoCGia.Text);
                
                if (bllDocGia.DeleteDocGia(Sach))
                {
                    this.ShowAllDocGia();
                    this.ResetText();
                    MessageBox.Show("Bạn đã xóa đọc giả thành công!", "Thông Báo!");

                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            this.ShowAllDocGia();
        }

        private void dataGridViewDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            if (Index >= 0)
            {
                txtMaDoCGia.Text = dataGridViewDocGia.Rows[Index].Cells["MADOCGIA"].Value.ToString();
                txtHoTen.Text = dataGridViewDocGia.Rows[Index].Cells["HOTEN"].Value.ToString();
                txtSDT.Text = dataGridViewDocGia.Rows[Index].Cells["SDT"].Value.ToString();
                TXTEmail.Text = dataGridViewDocGia.Rows[Index].Cells["EMAIL"].Value.ToString();
            }
        }
    }
}
