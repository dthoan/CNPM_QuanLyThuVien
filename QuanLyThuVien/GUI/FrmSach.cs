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
    public partial class FrmSach : Form
    {
        SachBLL bllSach;
        DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        SqlConnection conn;
        public FrmSach()
        {
          
            dc = new DataConnection();
            bllSach = new SachBLL();
            InitializeComponent();
        }

        public void ShowAllSach()
        {
            DataTable dt = bllSach.getAllSach();
            dataGridViewSach.DataSource = dt;

        }


        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtTenSach.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtSoTrang.Text))
            {
                MessageBox.Show("Bạn chưa nhập sô trang", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTrang.Focus();
                return false;
            }
            return true;
        }
        public void showComboBoxTheLoai()
        {
            conn = dc.GetConnection();
            conn.Open();
            cmd = new SqlCommand("select * from THELOAI", conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            cbbTheLoai.DataSource = table;
            cbbTheLoai.DisplayMember = "TENTHELOAI";
            cbbTheLoai.ValueMember = "MATHELOAI";
        }
        public void showComboBoxNXB()
        {
            conn = dc.GetConnection();
            conn.Open();
            cmd = new SqlCommand("select * from NXB", conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            cbbNXB.DataSource = table;
            cbbNXB.DisplayMember = "TEBNXB";
            cbbNXB.ValueMember = "MANXB";
        }
        public void showComboBoxTacGia()
        {
            conn = dc.GetConnection();
            conn.Open();
            cmd = new SqlCommand("select * from TACGIA", conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            cbbTacGia.DataSource = table;
            cbbTacGia.DisplayMember = "TENTACGIA";
            cbbTacGia.ValueMember = "MATACGIA";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tlbSach Sach = new tlbSach();
                Sach.MASACH = int.Parse(txtMaSach.Text);
                Sach.TENSACH = txtTenSach.Text;
                Sach.NAMXUATBAN= dateTimePickerNamXuatBan.Value.ToString("yyyy-MM-dd");
            
                // thể Loại
                if (cbbTheLoai.SelectedIndex == 1)
                {
                    Sach.THELOAI = 1;
                }
                else if (cbbTheLoai.SelectedIndex == 2)
                {
                    Sach.THELOAI = 2;
                }
                else if (cbbTheLoai.SelectedIndex == 3)
                {
                    Sach.THELOAI = 3;
                }
                else if (cbbTheLoai.SelectedIndex == 4)
                {
                    Sach.THELOAI = 4;
                }
                else 
                {
                    Sach.THELOAI = 5;
                }
                // Nhà Xuất Bản
                if (cbbNXB.SelectedIndex == 1)
                {
                    Sach.NXB = 1;
                }
                else if (cbbNXB.SelectedIndex == 2)
                {
                    Sach.NXB = 2;
                }
                else if (cbbNXB.SelectedIndex == 3)
                {
                    Sach.NXB = 3;
                }
                else if (cbbNXB.SelectedIndex == 4)
                {
                    Sach.NXB = 4;
                }
               
                // Tác Giả
                if (cbbTacGia.SelectedIndex == 1)
                {
                    Sach.TACGIA = 1;
                }
                else if (cbbTacGia.SelectedIndex == 2)
                {
                    Sach.TACGIA = 2;
                }
                else if (cbbTacGia.SelectedIndex == 3)
                {
                    Sach.TACGIA = 3;
                }
                else if (cbbTacGia.SelectedIndex == 4)
                {
                    Sach.TACGIA = 4;
                }
                else  
                {
                    Sach.TACGIA = 5;
                }
                Sach.SOTRANG = int.Parse(txtSoTrang.Text);

                //ShowAllKhachHang();
                if (bllSach.InsertSach(Sach))
                {
                    ShowAllSach();
                    this.ResetText();
                    MessageBox.Show("Bạn đã thêm Sách thành công!", "Thông Báo!");
                  
                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void ResetText()
        {
            txtMaSach.ResetText();
            txtSoTrang.ResetText();
            txtTenSach.ResetText();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            this.ShowAllSach();
            this.showComboBoxNXB();
            this.showComboBoxTacGia();
            this.showComboBoxTheLoai();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tlbSach Sach = new tlbSach();
                Sach.MASACH = int.Parse(txtMaSach.Text);
                Sach.TENSACH = txtTenSach.Text;
                Sach.NAMXUATBAN = dateTimePickerNamXuatBan.Value.ToString("yyyy-MM-dd");
                //// thể Loại
                if (cbbTheLoai.SelectedIndex == 1) { Sach.THELOAI = 1; }
                else if (cbbTheLoai.SelectedIndex == 2) { Sach.THELOAI = 2; }
                else if (cbbTheLoai.SelectedIndex == 3) { Sach.THELOAI = 3; }
                else if (cbbTheLoai.SelectedIndex == 4) { Sach.THELOAI = 4; }
                else { Sach.THELOAI = 5; }
                // Nhà Xuất Bản
                if (cbbNXB.SelectedIndex == 1) { Sach.NXB = 1; }
                else if (cbbNXB.SelectedIndex == 2) { Sach.NXB = 2; }
                else if (cbbNXB.SelectedIndex == 3) { Sach.NXB = 3; }
                else if (cbbNXB.SelectedIndex == 4) { Sach.NXB = 4; }
                // Tác Giả
                if (cbbTacGia.SelectedIndex == 1) { Sach.TACGIA = 1; }
                else if (cbbTacGia.SelectedIndex == 2) { Sach.TACGIA = 2; }
                else if (cbbTacGia.SelectedIndex == 3) { Sach.TACGIA = 3; }
                else if (cbbTacGia.SelectedIndex == 4) { Sach.TACGIA = 4; }
                else { Sach.TACGIA = 5; }
                Sach.SOTRANG = int.Parse(txtSoTrang.Text);
                //ShowAllKhachHang();
                if (bllSach.UpdateSach(Sach))
                {
                    ShowAllSach();
                    this.ResetText();
                    MessageBox.Show("Bạn đã Sửa Sách thành công!", "Thông Báo!");
                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Xóa ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tlbSach Sach = new tlbSach();
                Sach.MASACH = int.Parse(txtMaSach.Text);
                if (bllSach.DeleteSach(Sach))
                {
                    ShowAllSach();
                    this.ResetText();
                    MessageBox.Show("Bạn đã xóa thành công");

                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMaSach.ResetText();
            txtSoTrang.ResetText();
            txtTenSach.ResetText();
            cbbNXB.ResetText();
            cbbTacGia.ResetText();
            cbbTheLoai.ResetText();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            if (Index >= 0)
            {

                txtMaSach.Text = dataGridViewSach.Rows[Index].Cells["MASACH"].Value.ToString();
                txtTenSach.Text = dataGridViewSach.Rows[Index].Cells["TENSACH"].Value.ToString();
                dateTimePickerNamXuatBan.Text = dataGridViewSach.Rows[Index].Cells["NAMXUATBAN"].Value.ToString();
               
                cbbNXB.Text = dataGridViewSach.Rows[Index].Cells["NXB"].Value.ToString();
                cbbTheLoai.Text = dataGridViewSach.Rows[Index].Cells["THELOAI"].Value.ToString();
                cbbTacGia.Text = dataGridViewSach.Rows[Index].Cells["TACGIA"].Value.ToString();
                txtSoTrang.Text = dataGridViewSach.Rows[Index].Cells["SOTRANG"].Value.ToString();

              

            }
        }

        private void dataGridViewSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tlbSach Sach = new tlbSach();
                Sach.MASACH = int.Parse(txtMaSach.Text);
                Sach.TENSACH = txtTenSach.Text;
                Sach.NAMXUATBAN = dateTimePickerNamXuatBan.Value.ToString("yyyy-MM-dd");
                // thể Loại
                if (cbbTheLoai.SelectedIndex == 1){ Sach.THELOAI = 1;}
                else if (cbbTheLoai.SelectedIndex == 2){Sach.THELOAI = 2;}
                else if (cbbTheLoai.SelectedIndex == 3){Sach.THELOAI = 3;}
                else if (cbbTheLoai.SelectedIndex == 4){Sach.THELOAI = 4;}
                else{Sach.THELOAI = 5;}
                // Nhà Xuất Bản
                if (cbbNXB.SelectedIndex == 1) { Sach.NXB = 1;}
                else if (cbbNXB.SelectedIndex == 2){ Sach.NXB = 2; }
                else if (cbbNXB.SelectedIndex == 3) {  Sach.NXB = 3; }
                else if (cbbNXB.SelectedIndex == 4) { Sach.NXB = 4;}
                // Tác Giả
                if (cbbTacGia.SelectedIndex == 1)  {  Sach.TACGIA = 1; }
                else if (cbbTacGia.SelectedIndex == 2)  {   Sach.TACGIA = 2;   }
                else if (cbbTacGia.SelectedIndex == 3)   { Sach.TACGIA = 3;  }
                else if (cbbTacGia.SelectedIndex == 4)  {  Sach.TACGIA = 4;  }
                else  {  Sach.TACGIA = 5; }
                Sach.SOTRANG = int.Parse(txtSoTrang.Text);
                if (bllSach.InsertSach(Sach))
                {
                    ShowAllSach();
                    this.ResetText();
                    MessageBox.Show("Bạn đã Thêm Sách thành công!", "Thông Báo!");
                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tlbSach Sach = new tlbSach();
                Sach.MASACH = int.Parse(txtMaSach.Text);
                Sach.TENSACH = txtTenSach.Text;
                Sach.NAMXUATBAN = dateTimePickerNamXuatBan.Value.ToString("yyyy-MM-dd");
                //// thể Loại
                if (cbbTheLoai.SelectedIndex == 1) { Sach.THELOAI = 1; }
                else if (cbbTheLoai.SelectedIndex == 2) { Sach.THELOAI = 2; }
                else if (cbbTheLoai.SelectedIndex == 3) { Sach.THELOAI = 3; }
                else if (cbbTheLoai.SelectedIndex == 4) { Sach.THELOAI = 4; }
                else { Sach.THELOAI = 5; }
                // Nhà Xuất Bản
                if (cbbNXB.SelectedIndex == 1) { Sach.NXB = 1; }
                else if (cbbNXB.SelectedIndex == 2) { Sach.NXB = 2; }
                else if (cbbNXB.SelectedIndex == 3) { Sach.NXB = 3; }
                else if (cbbNXB.SelectedIndex == 4) { Sach.NXB = 4; }
                // Tác Giả
                if (cbbTacGia.SelectedIndex == 1) { Sach.TACGIA = 1; }
                else if (cbbTacGia.SelectedIndex == 2) { Sach.TACGIA = 2; }
                else if (cbbTacGia.SelectedIndex == 3) { Sach.TACGIA = 3; }
                else if (cbbTacGia.SelectedIndex == 4) { Sach.TACGIA = 4; }
                else { Sach.TACGIA = 5; }
                Sach.SOTRANG = int.Parse(txtSoTrang.Text);
                //ShowAllKhachHang();
                if (bllSach.UpdateSach(Sach))
                {
                    ShowAllSach();
                    this.ResetText();
                    MessageBox.Show("Bạn đã Sửa Sách thành công!", "Thông Báo!");
                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Xóa ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tlbSach Sach = new tlbSach();
                Sach.MASACH = int.Parse(txtMaSach.Text);
                if (bllSach.DeleteSach(Sach))
                {
                    ShowAllSach();
                    this.ResetText();
                    MessageBox.Show("Bạn đã xóa thành công");

                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
