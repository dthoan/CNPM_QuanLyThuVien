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
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void btnTKSach_Click(object sender, EventArgs e)
        {
            FrmReportSachcs f = new FrmReportSachcs();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void btnTKDocGia_Click(object sender, EventArgs e)
        {
            FrmReportDocGia f = new FrmReportDocGia();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }
    }
}
