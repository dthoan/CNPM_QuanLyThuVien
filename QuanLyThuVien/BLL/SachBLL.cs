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
    class SachBLL
    {
        SachDAL daBLL;
        public SachBLL()
        {
            daBLL = new SachDAL();

        }
        public DataTable getAllSach()
        {
            return daBLL.getAllSach();
        }
        public bool InsertSach(tlbSach kh)
        {
            return daBLL.InsertSach(kh);
        }
        public bool UpdateSach(tlbSach kh)
        {
            return daBLL.UpdateSach(kh);
        }
        public bool DeleteSach(tlbSach kh)
        {
            return daBLL.DeleteSach(kh);
        } 
    }
}
