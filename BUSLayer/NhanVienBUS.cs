using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

using System.Data.Linq;

namespace BUSLayer
{
    public class NhanVienBUS
    {
        QLSPDataContext qlSPCN = new QLSPDataContext();

        // Kiem tra dang nhap tai khoan 
        public bool kiemTraDangNhap(string tendangnhap, string matkhau)
        {
            //Dung LinQ dem so luong tk khi nhap ten dang nhap va mat khau
            int ktdangnhap = (from tk in qlSPCN.NHANVIENs
                             where tk.TenDangNhap == tendangnhap && tk.MatKhau == matkhau
                            select tk).Count();
            if (ktdangnhap == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Dang ky mot nhan vien moi 
        public void dangKyNhanVien(string tennguoidung, string taikhoan, string matkhau, string email, string diachi, string sodienthoai, Binary hinhanh)
        {
            NHANVIEN nhanvien = new NHANVIEN();
            nhanvien.HoTen = tennguoidung;
            nhanvien.TenDangNhap = taikhoan;
            nhanvien.MatKhau = matkhau;
            nhanvien.Email = email;
            nhanvien.SDT = sodienthoai;
            nhanvien.HinhAnh = hinhanh;
            qlSPCN.NHANVIENs.InsertOnSubmit(nhanvien);
            qlSPCN.SubmitChanges();
        }

        // kiem tra dang ky tai khoan trung vs tai khoan khac
        public bool kiemTraDangKy(string tendangnhap, string email)
        {
            // dung linQ dem so luong trung ten dang nhap va email
            int ktDangKy = (from tk in qlSPCN.NHANVIENs
                            where tk.TenDangNhap == tendangnhap || tk.Email == email
                            select tk).Count();

            if (ktDangKy >= 1)// Da bi trung ten dang nhap hoac mat khau.
            {
                return false;
            }
            else // Thai khan nay co the dung duoc
            {
                return true;
            }
        }

        // Kiem tra viec lay mat khau
        public bool kiemTraLayMatKhau(string tendangnhap, string email)
        {
            // dung linQ dem so luong trung ten dang nhap va email
            int demnhanvien = (from tk in qlSPCN.NHANVIENs
                            where tk.TenDangNhap == tendangnhap && tk.Email == email
                            select tk).Count();

            // chon dung nhan vien can lay mat khau
            if (demnhanvien == 1)
            {
                return true;
            }
            else // khong chon dung nhan vien
            {
                return false;
            }
        }

        // Kiem tra doi mat khau 
        public bool kiemTraDoiMatKhau(string tendangnhap, string matkhauhientai)
        {
            // Dem soluong tai khoan trung trong csdl 
            int ktDoiMatKhau = (from tk in qlSPCN.NHANVIENs
                                where tk.TenDangNhap == tendangnhap || tk.MatKhau == matkhauhientai
                                select tk).Count();

            if (ktDoiMatKhau == 1) // tai khoan nay la duy nhat va co the cap nhat mat khau
            {
                return true;
            }
            else // khong co tai khoan nao hoac co nhieu tai khhoan bi trung ten tai khoan hoac trung mat khau
            {
                return false;
            }
        }

        // Thay doi mat khau moi.
        public void doiMaTKhau(string tendangnhap, string matkhaumoi)
        {
            NHANVIEN suanhanvien = (from nv in qlSPCN.NHANVIENs
                                    select nv).Single(tk => tk.TenDangNhap == tendangnhap);

            suanhanvien.MatKhau = matkhaumoi;
            qlSPCN.SubmitChanges();
        }

        int chonquyenNV ;
        public int kiemtraQuyenNV(string tendangnhap)
        {
            var quyennhanvien = (from nv in qlSPCN.NHANVIENs
                                 join phanquyen in qlSPCN.PHANQUYENs on nv.MaNV equals phanquyen.MaNV
                                 join quyen in qlSPCN.QUYENs on phanquyen.IDQUYEN equals quyen.IDQUYEN
                                 where  nv.TenDangNhap == tendangnhap
                                 select new
                                 {
                                     tennhanvien = nv.HoTen,
                                     quyenvn = quyen.TenQuyen,
                                 }).Single();
            if (quyennhanvien.quyenvn == "Admin")
            {
                chonquyenNV = 1;
            }
            if (quyennhanvien.quyenvn == "QLSP")
            {
                chonquyenNV = 2;
            }
            if (quyennhanvien.quyenvn == "KT")
            {
                chonquyenNV = 3;
            }
            return chonquyenNV;
        }
    }
}
