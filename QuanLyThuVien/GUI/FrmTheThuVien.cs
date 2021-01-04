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
    public partial class FrmTheThuVien : Form
    {
        public FrmTheThuVien()
        {
            dc = new DataConnection();
            bllTheThuVien = new TheThuVienBLL();
            InitializeComponent();
        }
        TheThuVienBLL bllTheThuVien;
        DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        SqlConnection conn;
       
        public void ShowAllTheThuVien()
        {
            DataTable dt = bllTheThuVien.getAllTheThuVien();
            dataGridViewTheThuVien.DataSource = dt;

        }


        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMaThe.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã thẻ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaThe.Focus();
                return false;
            }
        
            
            return true;
        }
        public void showComboBoxDocGia()
        {
            conn = dc.GetConnection();
            conn.Open();
            cmd = new SqlCommand("select * from DOCGIAS", conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            cbbDocGia.DataSource = table;
            cbbDocGia.DisplayMember = "HOTEN";
            cbbDocGia.ValueMember = "MADOCGIA";
        }
        public void showComboBoxCTMuonTra()
        {
            conn = dc.GetConnection();
            conn.Open();
            cmd = new SqlCommand("select * from CTMUONTRA", conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            cbbCTMuonTra.DataSource = table;
            cbbCTMuonTra.DisplayMember = "MACTMUONTRA";
            cbbCTMuonTra.ValueMember = "MACTMUONTRA";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblTheThuVien Sach = new tblTheThuVien();
                Sach.MATHE = int.Parse(txtMaThe.Text);
                Sach.NGAYLAPTHE = dateNgayLapThe.Value.ToString("yyyy-MM-dd");
                Sach.NGAYHETHAN = dateNgayHetHan.Value.ToString("yyyy-MM-dd");
               
                // Tên Đọc giả
                if (cbbDocGia.SelectedIndex == 1)
                {
                    Sach.MADOCGIA = 1;
                }
                else if (cbbDocGia.SelectedIndex == 2)
                {
                    Sach.MADOCGIA = 2;
                }
                else if (cbbDocGia.SelectedIndex == 3)
                {
                    Sach.MADOCGIA = 3;
                }
                else if (cbbDocGia.SelectedIndex == 4)
                {
                    Sach.MADOCGIA = 4;
                }
                else 
                {
                    Sach.MADOCGIA = 5;
                }

                // CHI TIẾT MƯỢN TRẢ\
                if (cbbCTMuonTra.SelectedIndex == 1)
                {
                    Sach.CTMUONTRA = 1;
                }
                else if (cbbCTMuonTra.SelectedIndex == 2)
                {
                    Sach.CTMUONTRA = 2;
                }
                //ShowAllKhachHang();
                if (bllTheThuVien.InsertTheThuVien(Sach))
                {
                    ShowAllTheThuVien();
                    this.ResetText();
                    MessageBox.Show("Bạn đã thêm Sách thành công!", "Thông Báo!");

                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void FrmTheThuVien_Load(object sender, EventArgs e)
        {
            this.ShowAllTheThuVien();
            this.showComboBoxDocGia();
            this.showComboBoxCTMuonTra();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblTheThuVien Sach = new tblTheThuVien();
                Sach.MATHE = int.Parse(txtMaThe.Text);
                Sach.NGAYLAPTHE = dateNgayLapThe.Value.ToString("yyyy-MM-dd");
                Sach.NGAYHETHAN = dateNgayHetHan.Value.ToString("yyyy-MM-dd");

                // Tên Đọc giả
                if (cbbDocGia.SelectedIndex == 1)
                {
                    Sach.MADOCGIA = 1;
                }
                else if (cbbDocGia.SelectedIndex == 2)
                {
                    Sach.MADOCGIA = 2;
                }
                else if (cbbDocGia.SelectedIndex == 3)
                {
                    Sach.MADOCGIA = 3;
                }
                else if (cbbDocGia.SelectedIndex == 4)
                {
                    Sach.MADOCGIA = 4;
                }
                else
                {
                    Sach.MADOCGIA = 5;
                }

                Sach.CTMUONTRA = int.Parse(cbbCTMuonTra.Text);
                //ShowAllKhachHang();
                if (bllTheThuVien.UpdateTheThuVien(Sach))
                {
                    ShowAllTheThuVien();
                    this.ResetText();
                    MessageBox.Show("Bạn đã sửa thẻ thư viện thành công!", "Thông Báo!");

                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridViewTheThuVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTheThuVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            if (Index >= 0)
            {

                txtMaThe.Text = dataGridViewTheThuVien.Rows[Index].Cells["MATHE"].Value.ToString();
              
                dateNgayLapThe.Text = dataGridViewTheThuVien.Rows[Index].Cells["NGAYLAPTHE"].Value.ToString();
                dateNgayHetHan.Text = dataGridViewTheThuVien.Rows[Index].Cells["NGAYHETHANJ"].Value.ToString();
                cbbDocGia.Text = dataGridViewTheThuVien.Rows[Index].Cells["NGAYHETHAN"].Value.ToString();
                cbbCTMuonTra.Text = dataGridViewTheThuVien.Rows[Index].Cells["CTMUONTRA"].Value.ToString();
            



            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                tblTheThuVien Sach = new tblTheThuVien();
                Sach.MATHE = int.Parse(txtMaThe.Text);
               
                if (bllTheThuVien.DeleteTheThuVien(Sach))
                {
                    ShowAllTheThuVien();
                    this.ResetText();
                    MessageBox.Show("Bạn đã xóa thẻ thư viện thành công!", "Thông Báo!");

                }
                else
                    MessageBox.Show("Đã có lỗi sảy ra xin thử lại sau", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            this.ResetText();
        }
    }
}
