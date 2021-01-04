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
    public partial class FrmTacGia : Form
    {
        TacGiaNXBBLL bll;
        DataConnection dc;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        SqlConnection conn;
        public FrmTacGia()
        {
            dc = new DataConnection();
            bll = new TacGiaNXBBLL();
            InitializeComponent();
        }
        public void ShowAllTacGia()
        {
            DataTable dt = bll.getAllTacGia();
            dataGridViewTacGia.DataSource = dt;

        }
        public void ShowAllNXB()
        {
            DataTable dt = bll.getAllNXB();
            dataGridViewNXB.DataSource = dt;

        }
        private void txtThemC_Click(object sender, EventArgs e)
        {

        }

        private void FrmTacGia_Load(object sender, EventArgs e)
        {
            this.ShowAllTacGia();
            this.ShowAllNXB();
        }
    }
}
