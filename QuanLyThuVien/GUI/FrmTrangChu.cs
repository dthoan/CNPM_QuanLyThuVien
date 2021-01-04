using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            FrmDocGia f = new FrmDocGia();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            FrmSach f = new FrmSach();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            FrmMuonTra f = new FrmMuonTra();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimKiem f = new FrmTimKiem();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void tbnTroGiup_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chua co man hinh");
            FrmTroGiup f = new FrmTroGiup();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chua co man hinh");
            FrmThongKe f = new FrmThongKe();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void btnTacGiaNXB_Click(object sender, EventArgs e)
        {
            FrmTacGia f = new FrmTacGia();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void btnQuanLyThe_Click(object sender, EventArgs e)
        {
            FrmTheThuVien f = new FrmTheThuVien();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gọi cho chúng tôi để được trợ giúp xxx1235485");
           
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông Báo!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
