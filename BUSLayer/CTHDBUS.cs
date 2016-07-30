using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUSLayer
{
    public class CTHDBUS
    {
        QLSPDataContext qlsp = new QLSPDataContext();
        CT_HD cthd = new CT_HD();

        public void AddCTHD(int masp, int sohd, int soluong, int dongia, int thanhtien)
        {
            CT_HD themCTHD = new CT_HD();

            themCTHD.MaSP = masp;
            themCTHD.SoHD = sohd;
            themCTHD.SoLuong = soluong;
            themCTHD.DonGia = dongia;
            themCTHD.ThanhTien = thanhtien;

            qlsp.CT_HDs.InsertOnSubmit(themCTHD);
            qlsp.SubmitChanges();
        }

        public void editCTHD(int masp, int sohd, int soluong, int dongia, int thanhtien)
        {
            CT_HD suaCTHD = (from cthd in qlsp.CT_HDs
                             where cthd.MaSP == masp && cthd.SoHD == sohd
                             select cthd).Single();

            suaCTHD.MaSP = masp;
            suaCTHD.SoHD = sohd;
            suaCTHD.SoLuong = soluong;
            suaCTHD.DonGia = dongia;
            suaCTHD.ThanhTien = thanhtien;

            qlsp.SubmitChanges();
        }

        public void deleteCTHD(int sohd)
        {
            CT_HD xoaCTHD = (from cthd in qlsp.CT_HDs
                             join sp in qlsp.SANPHAMs on cthd.MaSP equals sp.MaSP
                             where cthd.SoHD == sohd
                             select cthd).Single();

            qlsp.CT_HDs.DeleteOnSubmit(xoaCTHD);
            qlsp.SubmitChanges();
        }
    }
}
