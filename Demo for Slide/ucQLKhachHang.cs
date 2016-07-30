using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress;
using DAL;
using BUSLayer;
using DevExpress.XtraEditors.Repository;
using System.Data.Sql;
using System.Data.Linq;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;

namespace Demo
{
    public partial class ucQLKhachHang : UserControl
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();

        public ucQLKhachHang()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucQLKhachHang_Load(object sender, EventArgs e)
        {
            grctrlKhachHang.DataSource = khachhangBUS.hienThiKhachHang();
            Localizer.Active = new showMessageBox("&hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Được", "&Thử lại", "&Đồng ý");

            lbThongBao.Text = "Chào mừng bạn đến với from quản lý khách hàng.";
            lbThongBao.ForeColor = Color.Green;

            grctrlThongTin.Enabled = false;
            
            btXoaKH.Enabled = true;
            btThemKhachHang.Enabled = true;
            btSuaKhachHang.Enabled = true;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void txtCMND_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNganHang_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhachHang_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTaiKhoan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridctrlQLKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void grctrl_QLKH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            lbThongBao.Text = "Bạn không thể sửa j ở trong này. vui lòng click chuột phải và click vào sửa.";
        }

        private void grctrlKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            lbThongBao.Text = "Bạn không thể sửa j ở trong này. vui lòng click chuột phải và click vào sửa.";
        }

        private void btThemKhachHang_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Chúng tôi sẽ thêm khách hàng khi bạn đã thuê sản phẩm của chúng tôi");
        }

        private void btSuaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = XtraMessageBox.Show(string.Format( "Bạn có muốn sửa thông tin của {0}.",txtTenKhachHang.Text), "Sửa thông tin", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    khachhangBUS.suaKhachHang(txtCMND.Text ,txtTenKhachHang.Text, txtDiaChi.Text, txtSDT.Text);

                    lbThongBao.Text = "Chúc mừng bạn đã sửa thành công. hãy chọn dòng TT để làm việc";
                    
                    groupctrlKhachHang.Enabled = true;
                    btSuaKhachHang.Enabled = false;
                }
                else
                {
                    lbThongBao.Text = "Bạn đã ko sửa TT KH này. Bạn hãy chọn một dòng sản phẩm để làm việc.";
                    btSuaKhachHang.Enabled = false;
                    resetTextBox();
                    groupctrlKhachHang.Enabled = true;
                }
            }
            catch
            {
                lbThongBao.Text = "??";
            }
            grctrlKhachHang.DataSource = khachhangBUS.hienThiKhachHang();
        }

        private void thayDoiTTKhachHang()
        {

        }

        private void btXoaKhachHang_Click(object sender, EventArgs e)
        {
            //lbThongBao.Text = "Bạn đã lỡ tay chọn nhầm.";

            //grctrlThongTin.Enabled = true;

            //groupctrlKhachHang.Enabled = true;

            //btThemKhachHang.Enabled = false;
            //btSuaKhachHang.Enabled = false;
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                // Tạo một menu of grid
                GridViewMenu menu = e.Menu as GridViewMenu;
                menu.Items.Clear();

                // Cài đặt item Sửa
                DXMenuItem itemEdit = new DXMenuItem("Sửa");
                itemEdit.Image = imageCollection.Images["edit_16x16.png"];
                itemEdit.Click += new EventHandler(itemEdit_Click);
                menu.Items.Add(itemEdit);

                // Cài đặt item Xóa
                DXMenuItem itemDelete = new DXMenuItem("Xóa");
                itemDelete.Image = imageCollection.Images["delete_16x16.png"];
                itemDelete.Click += new EventHandler(itemDelete_Click);
                menu.Items.Add(itemDelete);

                // Cai đặt item Thêm
                DXMenuItem itemAdd = new DXMenuItem("Thêm");
                itemAdd.Image = imageCollection.Images["add_16x16.png"];
                itemAdd.Click += new EventHandler(itemAdd_Click);
                menu.Items.Add(itemAdd);

                string tenKH = grviewKhachHang.GetFocusedRowCellDisplayText(grclmTenKhachHang);
                string diachi = grviewKhachHang.GetFocusedRowCellDisplayText(grclmDiaChi);
                string sodienthoai = grviewKhachHang.GetFocusedRowCellDisplayText(grclmSoDienthoai);

                // Kiểm tra 2 colum Tên khách hàng và Địa chỉ và số Điện thoại có Trống hay không.
                if (tenKH == "" || diachi == "" || sodienthoai == "")
                {
                    XtraMessageBox.Show("Tên KH, địa chỉ, hoặc số điện thoại này còn để trống, bạn hãy sửa nó.", "Sửa TT Khách hàng", MessageBoxButtons.OK);
                    lbThongBao.ForeColor = Color.Red;
                }
                else
                {
                    lbThongBao.ForeColor = Color.Green;
                }

                // Set lại enable cho các button (Thêm, Sửa) Khách hàng
                btThemKhachHang.Enabled = false;
                btSuaKhachHang.Enabled = false;

                // Gọi hàm show thông tin SP lên các textBox và picture
                laythongtintrongRow();
            }
        }

        bool chonSua = false;
        // Xự kiện click cho item Sửa
        private void itemEdit_Click(object sender, EventArgs e)
        {
            if (chonSua == false)
            {
                lb.Text = "THÔNG BÁO";
                lbThongBao.Text = "Nhân viên kế toán thì không thể (Thêm, Xóa, Sửa) TT sản phẩm.";
            }
            else
            {
                editKhachHang();
            }
        }

        // Hàm sửa TT Khách hàng
        private void editKhachHang()
        {
            lbThongBao.Text = "Sau khi sửa xong hãy nhấn vào nút (Sửa khách hàng) để hoàn tất bạn nhé.";
            groupctrlKhachHang.Enabled = false;
            lbThongBao.ForeColor = Color.Green;
            grctrlThongTin.Enabled = true;

            // chỉ hiện button sửa, 2 buuton xóa vs thêm sẽ ẩn đi
            btSuaKhachHang.Enabled = true;
            btXoaKH.Enabled = false;
            btThemKhachHang.Enabled = false;
        }


        bool chonXoa = false;
        // Xự kiện click cho item xóa
        private void itemDelete_Click(object sender, EventArgs e)
        {
            if (chonXoa == false)
            {
                lb.Text = "THÔNG BÁO: ";
                lbThongBao.Text = "Nhân viên kế toán thì không thể (Thêm, Xóa, Sửa) TT sản phẩm.";
            }
            else
            {
                lbThongBao.Text = "hãy bấm nút xóa Khách hàng để hoàn tất.";

                //group hiên thông tin xóa hiện lên, ẩn group hiện các khách hàng khác
                groupctrlKhachHang.Enabled = false;
                grctrlThongTin.Enabled = true;
                // cicl item xóa thì 2 button thêm và sửa bị ẩn đi

                btSuaKhachHang.Enabled = false;
                btThemKhachHang.Enabled = false;

                btXoaKH.Enabled = true;
            }
        }

        public void deleteKhachHang()
        {
            
        }

        bool chonThem = false;
        // Xự kiện click cho item thêm
        private void itemAdd_Click(object sender, EventArgs e)
        {
            
            if (chonThem == false)
            {
                lb.Text = "THÔNG BÁO";
                lbThongBao.Text = "Nhân viên kế toán thì không thể (Thêm, Xóa, Sửa) TT sản phẩm.";
            }
            else
            {
                AddKhachHang();
            }
            
        }

        // Hàm Thêm TT Khách hàng
        private void AddKhachHang()
        {
            // picSanPham.Image = imageCollection.Images["close_16x16.png"];
            lbThongBao.Text = "Bạn hãy điền đầy đủ thông khách hàng mà bạn muốn thêm vào, sau đó nhấn vào nút (Thêm khách hàng).";
            grctrlThongTin.Enabled = true;

            groupctrlKhachHang.Enabled = false;

            resetTextBox();
            // chỉ buuton thêm hiện lên, 2 button xóa và sửa bị ẩn đi
            btThemKhachHang.Enabled = true;
            btXoaKH.Enabled = false;
            btSuaKhachHang.Enabled = false;
        }
        // Hàm reset lại các textbox
        private void resetTextBox()
        {
            txtCMND.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void grctrlKhachHang_Click(object sender, EventArgs e)
        {
            // Gọi hàm load thông tin lên textbox



            lbThongBao.Text = "Bạn không thể sửa j ở trong này. vui lòng click chuột phải và chọn 'sửa'.";
        }

        private void loadTextBox()
        {
            txtCMND.Text = grviewKhachHang.GetFocusedRowCellDisplayText(grclmCMND);
            
        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Giới hạn giá trị nhập vào kể cả số và một số ký tự đặc biệt khác
            if (e.KeyChar.ToString().IndexOfAny(@"0123456789!@#$%^&*()_+=|\{}[]?><.,';:".ToCharArray()) != -1)  // chỉ nhận 2 giá trị 0 và -1
            {
                e.Handled = true;
                lbThongBao.Text = "Tên 'Khách hàng' không có ký tự dặc biệt, và ký tự số.";
            }
            else
            {
                e.Handled = false;
                lbThongBao.Text = "";
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập chữ và ký tự đặc biệt
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lbThongBao.Text = "không thể nhập ký tự khác ngoài số trong ô (Số điện thoại).";
            }
            else if (txtSDT.Text.Length > 11)
            {
                e.Handled = true;
                lbThongBao.Text = "Số Điện Thoại hiện hành là 11 chữ số.";
            }
            else
            {
                e.Handled = false;
                lbThongBao.Text = "";
            }
        }

        public void laythongtintrongRow()
        {
            // Đẩy thông tin lên các textbox
            txtCMND.Text = grviewKhachHang.GetFocusedRowCellDisplayText(grclmCMND);
            txtTenKhachHang.Text = grviewKhachHang.GetFocusedRowCellDisplayText(grclmTenKhachHang);
            txtDiaChi.Text = grviewKhachHang.GetFocusedRowCellDisplayText(grclmDiaChi);
            txtSDT.Text = grviewKhachHang.GetFocusedRowCellDisplayText(grclmSoDienthoai);
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Không cho nhập chữ và ký tự đặc biệt
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{}[]?><.,';:".ToCharArray()) != -1)  // chổ nầy ko hiểu tại sao lại !=-1
            {
                e.Handled = true;
                lbThongBao.Text = "CMND là chuỗi số và không có ký tự khác";
            }
            else
            {
                e.Handled = false;
            }

            if (txtCMND.Text.Length >= 11)
            {
                e.Handled = true;
                lbThongBao.Text = "Số CMND hiện hành là 12 chữ số.";
            }
            else
            {
                e.Handled = false;
                lbThongBao.Text = "";
            }
        }

        private void btHuy_Click_1(object sender, EventArgs e)
        {
            //3 button thêm, xóa, sửa bị ẩn đi
            btThemKhachHang.Enabled = true;
            btSuaKhachHang.Enabled = true;
            btXoaKH.Enabled = true;
            //hiện các khách hngaf khác
            groupctrlKhachHang.Enabled = true;

            lbThongBao.Text = "Bạn hãy chọn công việc cần làm.";
        }

        public void QuyennhanvienQLThue()
        {
            chonSua = true;
            chonThem = true;
            chonXoa = true;
            grctrlThongTin.Visible = true;
            grctrlChucNang.Visible = true;
        }

        // Hàm QLKH theo nhân viên kế toán
        public void QLKHOfNhanVienKeToan()
        {
            // Tắt đi 2 cái group Chức năng và thoogn tin
            grctrlThongTin.Visible = false;
            grctrlChucNang.Visible = false;
            // Thêm, xóa, Sửa là false
            chonThem = false;
            chonXoa = false;
            chonSua = false;
            
        }

        public void QuyenAdminQLKH()
        {

            // bật đi 2 cái group Chức năng và thoogn tin
            grctrlThongTin.Visible = true;
            grctrlChucNang.Visible = true;
            // Thêm, xóa, Sửa là true
            chonThem = true;
            chonXoa = true;
            chonSua = true;
        }
        HoaDonBUS hoadonBUS =  new HoaDonBUS();
        CTHDBUS cthdBUS = new CTHDBUS();
        QLSPDataContext qlsp = new QLSPDataContext();
        

        private void btXoaKH_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult dialog = XtraMessageBox.Show("Bạn muốn xóa khách hàng này.", "Xóa khách hàng", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    hoadonBUS.deleteHoaDon(txtCMND.Text);
                    khachhangBUS.xoaKhachHang(txtCMND.Text);
                    lbThongBao.Text = "Bạn đã xóa thành công khách hàng: " + txtTenKhachHang.Text;
                }
                else
                {
                    lbThongBao.Text = "Bạn đã không quá sản phẩm này.";
                    resetTextBox();
                    grctrlKhachHang.Enabled = true;
                }
            }
            catch
            {
                XtraMessageBox.Show("khách hàng này không tồn tại trong hóa đơn");
            }

            grctrlKhachHang.DataSource = khachhangBUS.hienThiKhachHang();
            // reset lại các ô textbox
            resetTextBox();

            // xóa xong thì groupcontrol thông tin ẩn đi group khách hàng hiện lên
            grctrlThongTin.Enabled = false;

            groupctrlKhachHang.Enabled = true;

            // sau khi xóa xong thì các button ẩn đi
            btXoaKH.Enabled = false;
            btThemKhachHang.Enabled = false;
            btSuaKhachHang.Enabled = false;
            //deleteKhachHang();
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btKHVIP_Click(object sender, EventArgs e)
        {

        }
    }
}
