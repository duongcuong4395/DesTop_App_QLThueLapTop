using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUSLayer
{
    public class HoaDonBUS
    {
        QLSPDataContext qlsp = new QLSPDataContext();
        HD Hoadon = new HD();

        // Thêm Thông tin cho hóa đơn
        public void AddHoaDon(DateTime ngaythue, DateTime ngaytra, int manv, string cmnd)
        {
            HD hoadon = new HD();
            hoadon.NgayThue = ngaythue;
            hoadon.NgayTra = ngaytra;
            hoadon.MaNV = manv;
            hoadon.CMND = cmnd;
            qlsp.HDs.InsertOnSubmit(hoadon);
            qlsp.SubmitChanges();
        }

        // hàm sửa hóa đơn.
        public void EditHoaDon(int sohoadon, DateTime ngaythue, DateTime ngaytra, int manv, string cmnd)
        {
            // lấy ra 1 dòng đơn nhất
            HD suaHoaDon = (from hoadon in qlsp.HDs
                            select hoadon).Single(hd => hd.SoHD == sohoadon);
            //Những Thông tin cần sửa
            suaHoaDon.SoHD = sohoadon;
            suaHoaDon.NgayThue = ngaythue;
            suaHoaDon.NgayTra = ngaytra;
            suaHoaDon.MaNV = manv;
            suaHoaDon.CMND = cmnd;
            // Thay đổi giá trị trong Database
            qlsp.SubmitChanges();
        }

        CT_HD cthd = new CT_HD();
        // Xóa hóa đơn
        public void deleteHoaDon(string cmnd)
        {
            HD xoaHoaDon = (from hoadon in qlsp.HDs
                            join kh in qlsp.KHACHHANGs on hoadon.CMND equals kh.CMND
                            where hoadon.CMND == cmnd
                            select hoadon).SingleOrDefault();
            qlsp.HDs.DeleteOnSubmit(xoaHoaDon);
            qlsp.SubmitChanges();
        }
    }
}
