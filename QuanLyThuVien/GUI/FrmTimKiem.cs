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
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {

            FrmTimKiemDocGia f = new FrmTimKiemDocGia();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            FrmTimKiemSach f = new FrmTimKiemSach();
            this.Hide(); // ẩn form login
            f.ShowDialog();
            this.Show();
        }
    }
}
