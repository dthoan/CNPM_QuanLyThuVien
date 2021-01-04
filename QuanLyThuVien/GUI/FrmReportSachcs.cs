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
    public partial class FrmReportSachcs : Form
    {
        DataConnection dc;

        private SqlDataAdapter da;
        private SqlCommand cmd;
        SqlConnection conn;
        public FrmReportSachcs()
        {
            InitializeComponent(); dc = new DataConnection();
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
        private void FrmReportSachcs_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dc.GetConnection();
            dt = XemDL("select * from SACH");
            CrystalReportSach rpt = new CrystalReportSach();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
