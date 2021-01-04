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
    class TacGiaNXBBLL
    {
        TacGiaNXBDAL daBLL;
        public TacGiaNXBBLL()
        {
            daBLL = new TacGiaNXBDAL();

        }
        public DataTable getAllTacGia()
        {
            return daBLL.getAllTacGia();
        }
        public bool InsertTacGia(tblTacGia kh)
        {
            return daBLL.InsertTacGia(kh);
        }
        public bool UpdateTacGia(tblTacGia kh)
        {
            return daBLL.UpdateTacGia(kh);
        }
        public bool DeleteTacGia(tblTacGia kh)
        {
            return daBLL.DeleteTacGia(kh);
        }

        // NHA XUAT BAN
        public DataTable getAllNXB()
        {
            return daBLL.getAllNXB();
        }
        public bool InsertNXB(tblNXB kh)
        {
            return daBLL.InsertNXB(kh);
        }
        public bool UpdateNXB(tblNXB kh)
        {
            return daBLL.UpdateNXB(kh);
        }
        public bool DeleteNXB(tblNXB kh)
        {
            return daBLL.DeleteNXB(kh);
        }
    }
}
