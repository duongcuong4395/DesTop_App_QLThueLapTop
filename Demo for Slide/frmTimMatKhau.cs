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
using DevExpress.XtraEditors.Controls;

namespace Demo
{
    public partial class frmTimMatKhau : Form
    {
        QLSPDataContext qlsp = new QLSPDataContext();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();

        public frmTimMatKhau()
        {
            InitializeComponent();
        }

        private void btLayMatKhau_Click(object sender, EventArgs e)
        {
            if (nhanVienBUS.kiemTraLayMatKhau(txtLMKTaiKhoan.Text, txtLMKEmail.Text)== true)
            {
                string matkhau = qlsp.NHANVIENs.Single(nv => nv.TenDangNhap == txtLMKTaiKhoan.Text).MatKhau;
                lbLMK.Text = "Mật khẩu của bạn:";
                lbMatKhau.Text = matkhau;
            }
            else
            {
                lbLMK.Text = "Bạn đã nhập sai vui lòng nhập lại.";
                lbMatKhau.Text = "";
            }
        }

        private void btLMKCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn muốn trở lại trang Đăng nhập?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form oform in Application.OpenForms)
                {
                    if (oform is frmDangNhap)
                    {
                        oform.Show();
                        break;
                    }
                }
                this.Close();
            }
        }

        private void frmTimMatKhau_Load(object sender, EventArgs e)
        {
            Localizer.Active = new showMessageBox("&hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Được", "&Thử lại", "&Đồng ý");
            foreach (Form oform in Application.OpenForms)
            {
                if (oform is frmChinh)
                {
                    oform.Enabled = false;
                    break;
                }
            }
        }
    }
}
