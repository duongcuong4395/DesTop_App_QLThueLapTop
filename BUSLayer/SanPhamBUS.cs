using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

using System.Data.Linq;

namespace BUSLayer
{
    public class SanPhamBUS
    {
        QLSPDataContext qlsp = new QLSPDataContext();

        // Load San Pham
        public IQueryable loadSanPham()
        {
            var loadSP = (from sp in qlsp.SANPHAMs
                          from loaisp in qlsp.LOAISPs
                          where sp.MaLoaiSP == loaisp.MaLoaiSP
                          select new { sp.MaSP, sp.TinhTrang, sp.TenSP, sp.GiaThue, sp.SoLuong, sp.NhaSX, sp.ManHinh, sp.Ram, sp.BoXuLy, sp.DoHoa, sp.MoTa, sp.AnhMoTa,
                                       loaisp.TenLoaiSP });
            return loadSP;
        }

        // Xóa Sản phẩm
        public void xoaSanPham(int masp)
        {
            SANPHAM xoaSP = (from sanpham in qlsp.SANPHAMs
                             where sanpham.MaSP == masp
                             select sanpham).FirstOrDefault();

                qlsp.SANPHAMs.DeleteOnSubmit(xoaSP);
                qlsp.SubmitChanges();
        }

        // Load Loại sản phẩm lên;
        public IQueryable loadLoaiSanPham(string tenloaisp)
        {
            var loadloa = (from sp in qlsp.SANPHAMs
                          from loaisp in qlsp.LOAISPs
                          where sp.MaLoaiSP == loaisp.MaLoaiSP && loaisp.TenLoaiSP == tenloaisp
                          orderby sp.MaSP
                          select new
                          {
                              sp.MaSP,
                              sp.TinhTrang,
                              sp.TenSP,
                              sp.GiaThue,
                              sp.SoLuong,
                              sp.NhaSX,
                              sp.ManHinh,
                              sp.Ram,
                              sp.BoXuLy,
                              sp.DoHoa,
                              sp.MoTa,
                              sp.AnhMoTa,
                              loaisp.TenLoaiSP,
                          });
            return loadloa;
        }

        // Sua thong tin Sản phẩm
        public void suaSanPham(int maSP, string tenSP, string mota, string tinhtrang, int giathue, int soluong, string nhaSX, string manhinh, string ram, string boxuly, string dohoa, Binary anhmota)
        {
            // Lay khach hang da da co ten dc tim thay
            SANPHAM suaSP = (from sanpham in qlsp.SANPHAMs
                             select sanpham).Single(sp => sp.MaSP == maSP);
            // Nhung thong tin can dc sua cua sanpham
            suaSP.TenSP = tenSP;
            suaSP.MoTa = mota;
            suaSP.TinhTrang = tinhtrang;
            suaSP.GiaThue = giathue;
            suaSP.SoLuong = soluong;
            suaSP.NhaSX = nhaSX;
            suaSP.ManHinh = manhinh;
            suaSP.Ram = ram;
            suaSP.BoXuLy = boxuly;
            suaSP.DoHoa = dohoa;
            suaSP.AnhMoTa = anhmota;

            //thay doi csdl trong SQL
            qlsp.SubmitChanges();
        }


        // kiem tra Thêm sản phẩm trùng vs sản phẩm khác
        public bool kiemTraSanPhamTrung(string tensanpham)
        {
            // dung linQ dem so luong trung ten dang nhap va email
            int ktThemSP = (from sp in qlsp.SANPHAMs
                            where sp.TenSP == tensanpham
                            select sp).Count();
            // Da bi trung ten san pham
            if (ktThemSP >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Thêm sản phẩm
        public void themSanPham(string tenSP, string mota, string tinhtrang, int giathue, int soluong, string nhaSX, string manhinh, string ram, string boxuly, string dohoa, Binary anhmota, int maloai)
        {
            SANPHAM sanphamMoi = new SANPHAM();
            sanphamMoi.TenSP = tenSP;
            sanphamMoi.MoTa = mota;
            sanphamMoi.TinhTrang = tinhtrang;
            sanphamMoi.GiaThue = giathue;
            sanphamMoi.SoLuong = soluong;
            sanphamMoi.NhaSX = nhaSX;
            sanphamMoi.ManHinh = manhinh;
            sanphamMoi.Ram = ram;
            sanphamMoi.BoXuLy = boxuly;
            sanphamMoi.DoHoa = dohoa;
            sanphamMoi.AnhMoTa = anhmota;
            sanphamMoi.MaLoaiSP = maloai;
            qlsp.SANPHAMs.InsertOnSubmit(sanphamMoi);
            qlsp.SubmitChanges();
        }
    }
}
