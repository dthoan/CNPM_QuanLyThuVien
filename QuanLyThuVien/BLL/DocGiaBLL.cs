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
    class DocGiaBLL
    {
        DocGiaDAL daBLL;
        public DocGiaBLL()
        {
            daBLL = new DocGiaDAL();

        }
        public DataTable getAllDocGia()
        {
            return daBLL.getAllDocGia();
        }
        public bool InsertDocGia(tblDocGia DocGia)
        {
            return daBLL.InsertDocGia(DocGia);
        }
        public bool UpdateDocGia(tblDocGia DocGia)
        {
            return daBLL.UpdateDocGia(DocGia);
        }
        public bool DeleteDocGia(tblDocGia DocGia)
        {
            return daBLL.DeleteDocGia(DocGia);
        }
    }
}
