using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BLL
{
    class TheThuVienBLL
    {
        TheThuVienDAL daBLL;
        public TheThuVienBLL()
        {
            daBLL = new TheThuVienDAL();

        }
        public DataTable getAllTheThuVien()
        {
            return daBLL.getAllTheThuVien();
        }
        public bool InsertTheThuVien(tblTheThuVien kh)
        {
            return daBLL.InsertTheThuVien(kh);
        }
        public bool UpdateTheThuVien(tblTheThuVien kh)
        {
            return daBLL.UpdateTheThuVien(kh);
        }
        public bool DeleteTheThuVien(tblTheThuVien kh)
        {
            return daBLL.DeleteTheThuVien(kh);
        }
    }
}
