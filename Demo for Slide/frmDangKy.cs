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
using System.Data.Linq;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace Demo
{
    public partial class frmDangKy : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        string fileName;
        QLSPDataContext qlsp = new QLSPDataContext();

        public frmDangKy()
        {
            InitializeComponent();
            Localizer.Active = new showMessageBox("&hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Được", "&Thử lại", "&Đồng ý");
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            btDangKy.Visible = false;
            txtThongBao.Visible = false;
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("bạn thật sự muốn lưu tài khoản này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (nhanVienBUS.kiemTraDangKy(txtDKTaiKhoan.Text, txtDKEmail.Text) == true)
            {
                if(dialog ==  DialogResult.Yes)
                {
                    // chuyển kiểu image thành kiểu binary
                    byte[] file_Byte = ImageToByteArray(picNhanVien.Image);
                    Binary file_Binary = new Binary(file_Byte);
                    // Gọi hàm đăng ký trong lớp BUS
                    nhanVienBUS.dangKyNhanVien(txtDKTenNguoiDung.Text, txtDKTaiKhoan.Text, txtDKMatKhau.Text, txtDKEmail.Text, txtDKDiaChi.Text, txtDKSDT.Text, file_Binary);
                    XtraMessageBox.Show("Bạn đã đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    enaBleCacTextBox(true);
                }
                btHuyDangKy_Click(sender, e);
            }
            else
            {
                XtraMessageBox.Show("Tài khoản này đã có người sử dụng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btHuyDangKy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn muốn trở lại trang chính?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            else
            {
                enaBleCacTextBox(true);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };
            try
            {
                if(sukiencactexbox() == true)
                {
                    if (openfile.ShowDialog() == DialogResult.OK)
                    {
                        fileName = openfile.FileName;
                        //lbFilename.Text = filename;
                        picNhanVien.Image = Image.FromFile(fileName);
                        Image image = Image.FromFile(fileName);
                        if (image.Width < picNhanVien.Width && image.Height < picNhanVien.Height)
                        {
                            picNhanVien.SizeMode = PictureBoxSizeMode.Normal;
                        }
                        else
                        {
                            picNhanVien.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    btDangKy.Visible = true;
                    enaBleCacTextBox(false);
                }
                else
                {
                    txtThongBao.Visible = true;
                }
            }
            catch
            {
                XtraMessageBox.Show("Bạn đã chọn nhầm file hình ảnh rồi, bạn có thể lấy file .jgp để làm ảnh đại diện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool sukiencactexbox()
        {
            if(txtDKTenNguoiDung.Text == "" || txtDKTaiKhoan.Text == "" || txtDKSDT.Text == "" || txtDKMatKhau.Text == "" || txtDKEmail.Text =="" || txtDKDiaChi.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void enaBleCacTextBox(bool chon)
        {
            txtDKDiaChi.Enabled = chon;
            txtDKEmail.Enabled = chon;
            txtDKMatKhau.Enabled = chon;
            txtDKSDT.Enabled = chon;
            txtDKTaiKhoan.Enabled = chon;
            txtDKTenNguoiDung.Enabled = chon;
        }

        // Hàm dùng để chuyển image => byte[]
        private byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void grctrlDangKy_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void picNhanVien_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //Hàm để chuyển byte[] => image
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image image = Image.FromStream(ms);
            return image;
        }
    }
}
