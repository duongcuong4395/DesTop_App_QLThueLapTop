using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUSLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Demo
{
    public partial class frmDoiMatKhau : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (nhanVienBUS.kiemTraDoiMatKhau(txtDMKTaiKhoan.Text, txtDMKHienTai.Text) == true)
            {
                if (txtDMKMoi.Text == txtDMKNhapLai.Text)
                {
                    nhanVienBUS.doiMaTKhau(txtDMKTaiKhoan.Text, txtDMKMoi.Text);
                    XtraMessageBox.Show("Bạn đã đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    btHuy_Click(sender, e);
                }
                else
                {
                    XtraMessageBox.Show("MK mới và MK nhập lại không trùng khớp.", "Nhập lại MK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show("Tài khoản và mật khẩu hiện tại ko đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void txtDMKNhapLai_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn muốn trở lại màn hình chính?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form oform in Application.OpenForms)
                {
                    if (oform is frmChinh)
                    {
                        oform.Enabled = true;
                        break;
                    }
                }
                this.Close();
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            Localizer.Active = new showMessageBox("&hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Được", "&Thử lại", "&Đồng ý");
        }
    }
}
