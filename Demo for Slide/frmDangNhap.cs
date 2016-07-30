using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using BUSLayer;
using System.IO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;


namespace Demo
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        NhanVienBUS nhanVienBus = new NhanVienBUS();
        QLSPDataContext qlsp = new QLSPDataContext();
        
        public int QuyenHanNhanVien;
        

        public frmDangNhap()
        {
            InitializeComponent();
            //Gallery Skin
            //DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbiGallery, true);
            //UserLookAndFeel.Default.SetSkinStyle("Default");
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (nhanVienBus.kiemTraDangNhap(txtDNTaiKhoan.Text, txtDNMatKhau.Text) == false || txtDNMatKhau.Text == "" || txtDNTaiKhoan.Text == "")
                {
                    XtraMessageBox.Show("Tài khoản và mật khẩu không đúng, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frmChinh formChinh = new frmChinh();
                    formChinh.Show();
                    this.Hide();


                    string tenNV = qlsp.NHANVIENs.Single(nv => nv.TenDangNhap == txtDNTaiKhoan.Text).HoTen.ToString();
                    // Nhân viên đó là Admin
                    if (nhanVienBus.kiemtraQuyenNV(txtDNTaiKhoan.Text) == 1)
                    {
                        formChinh.Admin();
                        XtraMessageBox.Show(string.Format("CHÀO ADMIN!!! Chúc Admin: {0} Ngày mới làm việc tốt đẹp.", tenNV), "Thông báo quyền VN", MessageBoxButtons.OK);
                    }

                    //Nhân viên quản lý sản phẩm
                    if (nhanVienBus.kiemtraQuyenNV(txtDNTaiKhoan.Text) == 2)
                    {
                        XtraMessageBox.Show(string.Format(" CHÀO NV CHO THUÊ!!! Chúc {0} ngày mới làm việc tốt đẹp.", tenNV), "Thông báo quyền VN", MessageBoxButtons.OK);

                        formChinh.nhanVienQLSP();
                    }

                    //Nhân viên kế toán
                    if (nhanVienBus.kiemtraQuyenNV(txtDNTaiKhoan.Text) == 3)
                    {
                        XtraMessageBox.Show(string.Format(" CHÀO NV KẾ TOÁN!!! Chúc {0} ngày mới làm việc tốt đẹp.", tenNV), "Thông báo quyền VN", MessageBoxButtons.OK);
                        formChinh.nhanVienKeToan();
                    }
                    
                }
            }
            catch
            {
                XtraMessageBox.Show("Xin Lỗi bạn ko thuộc nhân viên trong Công ty ABC.", "NHẮC NHỞ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        
        private void btMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Chương trình sẽ đóng lại, đóng(Yes)/không(No)", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbDNQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTimMatKhau frmTimMatKhau = new frmTimMatKhau();
            frmTimMatKhau.Show();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Localizer.Active = new showMessageBox("&hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Được", "&Thử lại", "&Đồng ý");
        }

        //Hàm để chuyển byte[] => image
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image image = Image.FromStream(ms);
            return image;
        }

        private void txtDNTaiKhoan_Leave(object sender, EventArgs e)
        {

        }

        private void txtDNTaiKhoan_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void grcntrDangNhap_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtMatKhauChange()
        {
            try
            {
                int matKhauNhanVien = (from nhanvien in qlsp.NHANVIENs
                                          where nhanvien.TenDangNhap == txtDNTaiKhoan.Text && nhanvien.MatKhau == txtDNMatKhau.Text
                                          select nhanvien).Count();
                if (matKhauNhanVien == 1)
                {
                    picChange2.Image = imageCollection.Images["apply_16x16.png"];
                    picChange1.Image = imageCollection.Images["apply_16x16.png"];
                }
                else
                {
                    picChange1.Image = imageCollection.Images["cancel_16x16.png"];
                    picChange2.Image = imageCollection.Images["cancel_16x16.png"];
                }
            }
            catch
            {
                picChange1.Image = imageCollection.Images["cancel_16x16.png"];
                picChange2.Image = imageCollection.Images["cancel_16x16.png"];
            }
        }

        private void txtDNMatKhau_Properties_Leave(object sender, EventArgs e)
        {
            txtMatKhauChange();
        }

        private void txtDNMatKhau_Properties_Enter(object sender, EventArgs e)
        {
           
        }

        private void picSeePass_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureEdit1_Properties_MouseHover(object sender, EventArgs e)
        {
            txtDNMatKhau.Properties.PasswordChar = (char)0;
        }

        private void pictureEdit1_Properties_MouseLeave(object sender, EventArgs e)
        {
            txtDNMatKhau.Properties.PasswordChar = '*';
        }

        private void picNhanVien_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void picNhanVien_Paint_1(object sender, PaintEventArgs e)
        {
    
        }

        public string laytennhanvien()
        {
            
            var manhanvien = (from nhanvien in qlsp.NHANVIENs
                              where nhanvien.TenDangNhap == txtDNTaiKhoan.Text
                              select  nhanvien.HoTen).FirstOrDefault().ToString();
            return manhanvien;
        }
    }
}
