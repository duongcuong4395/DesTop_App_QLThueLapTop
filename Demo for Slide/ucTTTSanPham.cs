using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using BUSLayer;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.IO;
using System.Globalization;

namespace Demo
{
    public partial class ucTTTSanPham : UserControl
    {
        public ucTTTSanPham()
        {
            InitializeComponent();
        }
        QLSPDataContext qlsp = new QLSPDataContext();
        KhachHangBUS khachhangBUS = new KhachHangBUS();
        ucQLKhachHang QLKH = new ucQLKhachHang();
        ucTTTKhachHang thongtinthueKH = new ucTTTKhachHang();

        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=QLSPCN;Integrated Security=True");

        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            loadFormPreLoad();
            //thongtinthueKH.Dock = DockStyle.Fill;
            //pnctrlKhachHang.Controls.Add(thongtinthueKH);
            tabctrlKhachHang.Show();
        }

        private void tabctrlSanPham_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabctrlKhachHang_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btTiepTucKhachKhang_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = XtraMessageBox.Show("Bạn muốn thuê thay đổi điều j trước khi lập phiếu.", "THUÊ SP", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.No)
                {
                    tabctrlTTThue.Show();
                    ThemKHVaoHD();
                    lbThongBao1.Text = "Bây giờ tới phần Chi tiết thông tin thuê.";
                }
                else
                {
                    lbThongBao1.Text = "Bạn muốn thay đổi điều gì khác?";
                }
            }
            catch
            {
                lbThongBao.Text = ".Không có gì ở trang này.";
            }
        }

        //Hàm  thêm vào phiếu thuê
        private void ThemKHVaoHD()
        {
            dataKhachHangSP.Rows.Clear();
            foreach (DataGridViewRow item in dtgridSanPham.Rows)
            {
                int n = dataKhachHangSP.Rows.Add();
                dataKhachHangSP.Rows[n].Cells[0].Value = txtTenKH.Text;
                dataKhachHangSP.Rows[n].Cells[1].Value = item.Cells[1].Value.ToString();
                dataKhachHangSP.Rows[n].Cells[2].Value = item.Cells[10].Value.ToString();
            }
        }

        // Làm Load Form đợi, và design các thuộc tính cho form
        private void loadFormPreLoad()
        {
            frmPreLoad formPreLoad = new frmPreLoad();
            formPreLoad.thoigianhienthi = 3;
            formPreLoad.Show();
        }
        int co = 1;

        private void btTimKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKH.Text == "")
                {
                    lbThongBao.Text = "Ô tìm Kiếm vẫn còn để trống bạn hãy điền vào.";
                }
                else
                {
                    if (KiemtraKh(txtTimKH.Text) == false)
                    {
                        lbThongBao.Text = "Khách hàng này đã tồn tại. hãy click vào tôi để Xem thử";
                        lbThongBao.Cursor = Cursors.Hand;
                        co = 1;
                    }
                    else
                    {
                        lbThongBao.Text = "DS KH vẫn chưa có vị khách này. Hãy click vào tôi để thêm khách hàng.";
                        lbThongBao.Cursor = Cursors.Hand;
                        co = 2;
                    }
                }
            }
            catch
            {
                lbThongBao.Text = "Bạn không tìm thấy điều bạn cần?";
            }
            
        }

        public bool KiemtraKh(string chuoiNhapVao)
        {
            // Đếm khách hàng nhập vào đã có trong DataBase.
            var timKiemKhachHang = (from kh in qlsp.KHACHHANGs
                                     where kh.CMND == chuoiNhapVao || kh.SDT == chuoiNhapVao || kh.TenKH == chuoiNhapVao
                                     select kh).Count();
            // khach hàng đã có khi đếm . hoặc = 1
            if (timKiemKhachHang >= 1)
            {
                return false;
            }
            // Khác hàng này là Khách hàng mới.
            else
            {
                return true;
            }
        }

        

        private void txtTimKH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (rdbtCMND.Checked == true)
            {
                // Kiểu chữ và ký tự đặc biệt
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    lbThongBao.Text = "Số CMND của 'Khách hàng' đã nhập ko đúng kiểu ký tự.";
                }
                else
                {
                    e.Handled = false;
                    lbThongBao.Text = "";
                }

                if (txtTimKH.Text.Length >= 0 || txtTimKH.Text.Length <= 11)
                {
                    btTimKH.Enabled = false;
                    lbThongBao.Text = "Số CMND phải > 9 số và < 12 số";
                }
                if (txtTimKH.Text.Length >11)
                {
                    e.Handled = true;
                    btTimKH.Enabled = true;
                    lbThongBao.Text = "Đã đủ 11 số rồi bạn";
                }

            }
            if (rdbtSDT.Checked == true)
            {
                // Kiểu chữ và ký tự đặc biệt sẽ ko dc nhập
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    lbThongBao.Text = "Số ĐT của 'Khách hàng' đã nhập ko đúng kiểu ký tự.";
                }

                else
                {
                    e.Handled = false;
                    lbThongBao.Text = "";
                }
            }
            if(rdbtTenKH.Checked == true)
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
        }

        private void lbThongBao_Click(object sender, EventArgs e)
        {
            pnctrlKhachHang.Controls.Clear();
            loadFormPreLoad();
            QLKH.Dock = DockStyle.Fill;
            pnctrlKhachHang.Controls.Add(QLKH);
            QLKH.Visible = true;
        }

        private void rdbtTenKH_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKH.Text = "";
            if (btTimKH.Enabled == false)
            {
                btTimKH.Enabled = true;
            }
            else
            {
                lbThongBao.Text = "";
            }
        }

        private void rdbtCMND_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKH.Text = "";
        }

        private void rdbtSDT_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKH.Text = "";
            if (btTimKH.Enabled == false)
            {
                btTimKH.Enabled = true;
            }
            else
            {
                lbThongBao.Text = "";
            }
        }

        private void groupControl2_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKH_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtTimKH_Properties_Enter(object sender, EventArgs e)
        {
         
        }

        private void txtTimKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtTimKH.Text = "";
            }
        }

        private void lbThongBao_Click_1(object sender, EventArgs e)
        {
            switch(co)
            {
                // Khách hàng này đã tồn tại. hãy click vào tôi để Xem thử
                case 1:
                    var loadkh = (from kh in qlsp.KHACHHANGs
                                  where kh.SDT == txtTimKH.Text || kh.TenKH == txtTimKH.Text || kh.CMND == txtTimKH.Text
                                  select new
                                  {
                                      cmnd = kh.CMND,
                                      tenkh = kh.TenKH,
                                      soDT = kh.SDT,
                                      dc = kh.DiaChi
                                  }).FirstOrDefault();
                    lbThongBao.Text = "Thông tin Khách hàng nằm ở trong Group này.";
                    txtCMND.Text = loadkh.cmnd;
                    txtTenKH.Text = loadkh.tenkh;
                    txtSDT.Text = loadkh.soDT;
                    txtDiaChi.Text = loadkh.dc;
                    groupDangKyKH.Enabled = false;
                    grpctrlKhachHang.Enabled = true;
                    btTiepTucKhachKhang.Enabled = true;
                    break;
                // DS KH vẫn chưa có vị khách này. Hãy click vào tôi để thêm khách hàng.
                case 2:
                    loadFormPreLoad();
                    grpctrlTimKhachHang.Enabled = false;
                    grpctrlKhachHang.Enabled = false;
                    groupctrlShowSPChon.Enabled = false;
                    btTiepTucKhachKhang.Enabled = false;
                    groupDangKyKH.Enabled = true;
                    break;
                case 3:
                    pnctrlKhachHang.Controls.Clear();
                    pnctrlKhachHang.Visible = false;
                    grpctrlTimKhachHang.Enabled = true;
                    break;
                default:
                    lbThongBao.Text = "";
                    break;
            }
        }

        private void lbGiaThue_Click(object sender, EventArgs e)
        {

        }

        private void ucTTTSanPham_Load(object sender, EventArgs e)
        {
           
            LoadDanhSachSP();
            btTiepTucSanPham.Enabled = false;
        }

        // Hàm load Danh sách sản phẩm lên datagridview
        public void LoadDanhSachSP()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from SANPHAM", connect);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            dtgridSanPham.Rows.Clear();

            foreach (DataRow item in table.Rows)
            {
                int n = dtgridSanPham.Rows.Add();
                dtgridSanPham.Rows[n].Cells[0].Value = false;
                dtgridSanPham.Rows[n].Cells[1].Value = item["TenSP"].ToString();
                dtgridSanPham.Rows[n].Cells[2].Value = item["MoTa"].ToString();
                dtgridSanPham.Rows[n].Cells[3].Value = item["TinhTrang"].ToString();
                dtgridSanPham.Rows[n].Cells[4].Value = item["GiaThue"].ToString();
                dtgridSanPham.Rows[n].Cells[5].Value = item["SoLuong"].ToString();
                dtgridSanPham.Rows[n].Cells[6].Value = item["NhaSX"].ToString();
                dtgridSanPham.Rows[n].Cells[7].Value = item["ManHinh"].ToString();
                dtgridSanPham.Rows[n].Cells[8].Value = item["Ram"].ToString();
                dtgridSanPham.Rows[n].Cells[9].Value = item["BoXuLy"].ToString();
                dtgridSanPham.Rows[n].Cells[10].Value = item["DoHoa"].ToString();
            }
        }

        private void tabctrlTTThue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgridSanPham_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btThue_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = XtraMessageBox.Show("Bạn muốn thuê những sản phẩm này.", "THUÊ SP", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    themvaoSanPhamChon();
                    lbThongBao1.Text = "Bây giờ tới phần điền thông tin khách hàng.";
                    btThue.Enabled = false;
                }
                else
                {
                    lbThongBao1.Text = "Bạn muốn thay đổi điều gì khác?";
                }
            }
            catch
            {
                lbThongBao1.Text = "Không Thuê sản phẩm được.";
            }
            
        }

        // Hàm Kiểm tra thêm Sản phẩm Được chọn.
        public void themvaoSanPhamChon()
        {
            dataShowSPChon.Rows.Clear();
            foreach (DataGridViewRow item in dtgridSanPham.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataShowSPChon.Rows.Add();
                    dataShowSPChon.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataShowSPChon.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataShowSPChon.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    dataShowSPChon.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                    dataShowSPChon.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
                    dataShowSPChon.Rows[n].Cells[5].Value = item.Cells[6].Value.ToString();
                    dataShowSPChon.Rows[n].Cells[6].Value = item.Cells[7].Value.ToString();
                    dataShowSPChon.Rows[n].Cells[7].Value = item.Cells[8].Value.ToString();
                    dataShowSPChon.Rows[n].Cells[8].Value = item.Cells[9].Value.ToString();
                    dataShowSPChon.Rows[n].Cells[9].Value = item.Cells[10].Value.ToString();
                }
            }
        }

        private void dtgridSanPham_MouseClick_1(object sender, MouseEventArgs e)
        {
            if ((bool)dtgridSanPham.SelectedRows[0].Cells[0].Value == false)
            {
                dtgridSanPham.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dtgridSanPham.SelectedRows[0].Cells[0].Value = false;
            }


        }

        private void dtgridSanPham_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataRow = dtgridSanPham.SelectedRows[0];
            lbTenSP.Text = dataRow.Cells["TenSP"].Value.ToString();
            lbGiaThue.Text = dataRow.Cells["GiaThue"].Value.ToString() + "Đồng/SP";
            lbManHinh.Text =dataRow.Cells["ManHinh"].Value.ToString();
            lbRam.Text =dataRow.Cells["Ram"].Value.ToString();
            lbBoXuLy.Text =dataRow.Cells["BoXuLy"].Value.ToString();
            lbMoTa.Text = dataRow.Cells["MoTa"].Value.ToString();
            lbNhaSX.Text = dataRow.Cells["NhaSX"].Value.ToString();
            lbDoHoa.Text = dataRow.Cells["DoHoa"].Value.ToString();
           
            
            if (bool.Parse(dataRow.Cells["Chon"].Value.ToString()) == false)
            {
                chkChon.Checked = true;
            }
            else
            {
                chkChon.Checked = false;
            }
            kiemtraAnhSanPham();
        }

        private void chkChon_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataRow = dtgridSanPham.SelectedRows[0];
            if (chkChon.Checked == false)
            {
                dataRow.Cells["Chon"].Value = true;
            }
            else
            {
                dataRow.Cells["Chon"].Value = false;
            }
        }

        // Hàm kiểm tra ảnh sản phẩm đã có chưa.
        public void kiemtraAnhSanPham()
        {
            try
            {
                var sanpham = (from sp in qlsp.SANPHAMs
                               where sp.TenSP == lbTenSP.Text
                               select sp).Single();
                picSanPham.Image = ByteArrayToImage(sanpham.AnhMoTa.ToArray());
            }
            catch
            {
                lbThongBao.Text = "Sản phẩm này vẫn chưa có Hình ảnh. bạn hãy thêm ảnh cho sản phẩm này.";
            }
        }

        //Hàm để chuyển byte[] => image
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image image = Image.FromStream(ms);
            return image;
        }

        private void lbThongBao1_TextChanged(object sender, EventArgs e)
        {
            if (lbThongBao1.Text == "Bây giờ tới phần điền thông tin khách hàng.")
            {
                btTiepTucSanPham.Enabled = true;
            }
            else
            {
                btTiepTucSanPham.Enabled = false;
            }
        }

        private void btDangKyKH_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = XtraMessageBox.Show(string.Format("Bạn có muốn Đăng Ký khách hàng {0} vào danh sách.", txtThemTenKH.Text), "THÊM KHÁCH HÀNG", MessageBoxButtons.YesNo);
                {
                    if (dialog == DialogResult.Yes)
                    {
                        khachhangBUS.dangKyKhachHang(txtThemTenKH.Text, txtThemCMND.Text, txtThemDiaChi.Text, txtSDT.Text);
                        txtTenKH.Text = txtThemTenKH.Text;
                        txtDiaChi.Text = txtThemDiaChi.Text;
                        txtCMND.Text = txtThemCMND.Text;
                        txtSDT.Text = txtThemSDT.Text;
                        btTiepTucKhachKhang.Enabled = true;
                    }
                    else
                    {
                        lbThongBao.Text = "Bạn đã không đăng ký khách hàng: " + txtThemTenKH.Text;
                    }
                }
            }
            catch
            {
                lbThongBao.Text = "KHÁCH HÀNG LÀ THƯỢNG ĐẾ.";
            }

            //try
            //{
            //    DialogResult dialog = XtraMessageBox.Show(string.Format( "Bạn có muốn Đăng Ký khách hàng {0} vào danh sách.", txtTenKhachHang.Text),"THÊM KHÁCH HÀNG", MessageBoxButtons.YesNo);
            //    {
            //        if (dialog == DialogResult.Yes)
            //        {
            //            if (khachhangBUS.kiemTraKhachHang(txtSDT.Text, txtCMND.Text) == true)
            //            {
            //                if (txtCMND.Text == "" || txtTenKhachHang.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            //                {
            //                    lbThongBao.Text = "Bạn đã để trống một vài ô.";
            //                }
            //                else
            //                {
            //                    khachhangBUS.dangKyKhachHang(txtTenKhachHang.Text, txtCMND.Text, txtDiaChi.Text, txtSDT.Text);
            //                }
            //            }
            //            else
            //            {
            //                lbThongBao.Text = "Khách hàng có : " + txtCMND.Text + " hoặc " + txtSDT.Text + " Đã có người khác dùng";
            //            }
            //        }
            //        else
            //        {
            //            lbThongBao.Text = "Bạn đã không đăng ký khách hàng: " + txtTenKhachHang.Text;
            //        }
            //    }
            //}
            //catch
            //{
            //    lbThongBao.Text = "????";
            //}
        }

        private void btHuyDangKy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn muốn hủy đăng ký khách hàng ", "HỦY ĐĂNG KÝ", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                groupDangKyKH.Enabled = false;
                grpctrlTimKhachHang.Enabled = true;
            }
            else
            {
                lbThongBaoDK.Text = "Bạn hãy sửa đổi thông tin khách hàng.";
                grpctrlKhachHang.Enabled = false;
            }
        }

        private void tabpageTTThue_Click(object sender, EventArgs e)
        {

        }

        private void btLapHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                Themhoadon();
                themCTHD();
                XtraMessageBox.Show("Bạn đã Lập hóa đơn thành công.");
            }
            catch
            {
                lbThongBaoLapHD.Text = "không thể lập hóa đơn nếu thiếu thông tin.";
            }
        }
        
        HoaDonBUS hoadonBUS = new HoaDonBUS();
        //Ham thêm hóa đơn
        private void Themhoadon()
        {
            DateTime today = DateTime.Now;
            string xau = string.Format("{0:MM/dd/yyyy}", timeNgayTraSP.Value);
            DateTime ngaytraSanPham = Convert.ToDateTime(xau);
           
          hoadonBUS.AddHoaDon(today, ngaytraSanPham, 1, txtCMND.Text);
        }

        CTHDBUS chitiethoadonBUS = new CTHDBUS();
        // Hàm thêm Chi tiết hóa đơn 
        private void themCTHD()
        {
            string xau = string.Format("{0:MM/dd/yyyy}", timeNgayThue.Value);
            DateTime ngaythueSanPham = Convert.ToDateTime(xau);
            DateTime today = DateTime.Now;


            var laysohoadon = qlsp.HDs.Single(hd => hd.CMND == txtCMND.Text).SoHD;
            int sohoadon = laysohoadon;
            
            for (int dong = 0; dong < dataKhachHangSP.Rows.Count; dong ++)
            {
                int masp = (from sanpham in qlsp.SANPHAMs
                            where sanpham.TenSP == dataKhachHangSP.Rows[dong].Cells[1].Value.ToString()
                            select sanpham).Single().MaSP;

                var giasp = (from sanpham in qlsp.SANPHAMs
                             where sanpham.TenSP == dataKhachHangSP.Rows[dong].Cells[1].Value.ToString()
                             select sanpham).Single().GiaThue;
                int giasanpham = int.Parse(giasp.ToString());
                chitiethoadonBUS.AddCTHD(masp, sohoadon,3,4,giasanpham);
            }
        }

        private void btXoaHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void txtThemCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txtThemCMND.Text.Length > 11)
            {
                e.Handled = true;
                lbThongBao.Text = "không thể nhập ký tự khác ngoài số trong ô (số lượng).";
            }

            if (txtCMND.Text.Length >9 && txtCMND.Text.Length < 10)
            {
                
                btDangKyKH.Enabled = true;
            }
            else
            {
                btDangKyKH.Enabled = true;
            }
        }

        private void txtThemTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"0123456789!@#$%^&*()_+=|\{}[]?><.,';:".ToCharArray()) != -1)  // chỉ nhận 2 giá trị 0 và -1
            {
                e.Handled = true;
                lbThongBaoDK.Text = "Tên Khách hàng Là một chuỗi các ký tự chữ cái trong hệ.";
            }

            else
            {
                e.Handled = false;
                lbThongBaoDK.Text = "";
            }

            if (txtTenKH.Text.Length >20 )
            {
                e.Handled = true;
                lbThongBaoDK.Text = "Tên của bạn thật sự khá dài";
            }
            else
            {
                e.Handled = false;
                lbThongBaoDK.Text = "KHÁCH HÀNG LÀ THƯỢNG ĐẾ.";
            }
        }

        private void txtThemSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txtThemSDT.Text.Length > 11)
            {
                e.Handled = true;
                lbThongBao.Text = "không thể nhập ký tự khác ngoài số trong ô (SDT).";
            }

            if (txtSDT.Text.Length > 9 && txtSDT.Text.Length < 12)
            {

                btDangKyKH.Enabled = true;
            }
            else
            {
                btDangKyKH.Enabled = true;
            }
        }

        private void txtThemDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*_+=|\{}[]?><';:".ToCharArray()) != -1)  // chỉ nhận 2 giá trị 0 và -1
            {
                e.Handled = true;
                lbThongBaoDK.Text = "Địa chỉ Là một chuỗi số và chữ không có khý tự khác.";
            }

            else
            {
                e.Handled = false;
                lbThongBaoDK.Text = "";
            }
        }

        private void btLoadLapTop_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select sp.TenSP, sp.MoTa, sp.TinhTrang, sp.GiaThue, sp.SoLuong, sp.NhaSX, sp.ManHinh, sp.Ram, sp.BoXuLy, sp.DoHoa  from SANPHAM sp inner join LOAISP l on l.MaLoaiSP = sp.MaLoaiSP where l.TenLoaiSP = 'Laptop'", connect);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                dtgridSanPham.Rows.Clear();

                foreach (DataRow item in table.Rows)
                {
                    int n = dtgridSanPham.Rows.Add();
                    dtgridSanPham.Rows[n].Cells[0].Value = false;
                    dtgridSanPham.Rows[n].Cells[1].Value = item["TenSP"].ToString();
                    dtgridSanPham.Rows[n].Cells[2].Value = item["MoTa"].ToString();
                    dtgridSanPham.Rows[n].Cells[3].Value = item["TinhTrang"].ToString();
                    dtgridSanPham.Rows[n].Cells[4].Value = item["GiaThue"].ToString();
                    dtgridSanPham.Rows[n].Cells[5].Value = item["SoLuong"].ToString();
                    dtgridSanPham.Rows[n].Cells[6].Value = item["NhaSX"].ToString();
                    dtgridSanPham.Rows[n].Cells[7].Value = item["ManHinh"].ToString();
                    dtgridSanPham.Rows[n].Cells[8].Value = item["Ram"].ToString();
                    dtgridSanPham.Rows[n].Cells[9].Value = item["BoXuLy"].ToString();
                    dtgridSanPham.Rows[n].Cells[10].Value = item["DoHoa"].ToString();
                }
            }
            catch
            {
                lbThongBao1.Text = "Sản phẩm laptop không có trong kho.";
            }
           
        }

        private void btLoadAll_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDanhSachSP();
            }
            catch
            {
                lbThongBao1.Text = "Không có sản phẩm nào trong Kho.";
            }
        }

        private void btLoadManHinh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select sp.TenSP, sp.MoTa, sp.TinhTrang, sp.GiaThue, sp.SoLuong, sp.NhaSX, sp.ManHinh, sp.Ram, sp.BoXuLy, sp.DoHoa  from SANPHAM sp inner join LOAISP l on l.MaLoaiSP = sp.MaLoaiSP where l.TenLoaiSP = 'Màn hình'", connect);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                dtgridSanPham.Rows.Clear();

                foreach (DataRow item in table.Rows)
                {
                    int n = dtgridSanPham.Rows.Add();
                    dtgridSanPham.Rows[n].Cells[0].Value = false;
                    dtgridSanPham.Rows[n].Cells[1].Value = item["TenSP"].ToString();
                    dtgridSanPham.Rows[n].Cells[2].Value = item["MoTa"].ToString();
                    dtgridSanPham.Rows[n].Cells[3].Value = item["TinhTrang"].ToString();
                    dtgridSanPham.Rows[n].Cells[4].Value = item["GiaThue"].ToString();
                    dtgridSanPham.Rows[n].Cells[5].Value = item["SoLuong"].ToString();
                    dtgridSanPham.Rows[n].Cells[6].Value = item["NhaSX"].ToString();
                    dtgridSanPham.Rows[n].Cells[7].Value = item["ManHinh"].ToString();
                    dtgridSanPham.Rows[n].Cells[8].Value = item["Ram"].ToString();
                    dtgridSanPham.Rows[n].Cells[9].Value = item["BoXuLy"].ToString();
                    dtgridSanPham.Rows[n].Cells[10].Value = item["DoHoa"].ToString();
                }
            }
            catch
            {
                lbThongBao1.Text = "Sản phẩm màn hình không có trong kho.";
            }
            
        }

        private void btLoadLoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select sp.TenSP, sp.MoTa, sp.TinhTrang, sp.GiaThue, sp.SoLuong, sp.NhaSX, sp.ManHinh, sp.Ram, sp.BoXuLy, sp.DoHoa  from SANPHAM sp inner join LOAISP l on l.MaLoaiSP = sp.MaLoaiSP where l.TenLoaiSP = 'Loa'", connect);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                dtgridSanPham.Rows.Clear();

                foreach (DataRow item in table.Rows)
                {
                    int n = dtgridSanPham.Rows.Add();
                    dtgridSanPham.Rows[n].Cells[0].Value = false;
                    dtgridSanPham.Rows[n].Cells[1].Value = item["TenSP"].ToString();
                    dtgridSanPham.Rows[n].Cells[2].Value = item["MoTa"].ToString();
                    dtgridSanPham.Rows[n].Cells[3].Value = item["TinhTrang"].ToString();
                    dtgridSanPham.Rows[n].Cells[4].Value = item["GiaThue"].ToString();
                    dtgridSanPham.Rows[n].Cells[5].Value = item["SoLuong"].ToString();
                    dtgridSanPham.Rows[n].Cells[6].Value = item["NhaSX"].ToString();
                    dtgridSanPham.Rows[n].Cells[7].Value = item["ManHinh"].ToString();
                    dtgridSanPham.Rows[n].Cells[8].Value = item["Ram"].ToString();
                    dtgridSanPham.Rows[n].Cells[9].Value = item["BoXuLy"].ToString();
                    dtgridSanPham.Rows[n].Cells[10].Value = item["DoHoa"].ToString();
                }
            }
            catch
            {
                lbThongBao1.Text = "Sản phẩm Loa không có trong kho.";
            }
            
        }

        private void btLoadMayChieu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select sp.TenSP, sp.MoTa, sp.TinhTrang, sp.GiaThue, sp.SoLuong, sp.NhaSX, sp.ManHinh, sp.Ram, sp.BoXuLy, sp.DoHoa  from SANPHAM sp inner join LOAISP l on l.MaLoaiSP = sp.MaLoaiSP where l.TenLoaiSP = 'Máy chiếu'", connect);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                dtgridSanPham.Rows.Clear();

                foreach (DataRow item in table.Rows)
                {
                    int n = dtgridSanPham.Rows.Add();
                    dtgridSanPham.Rows[n].Cells[0].Value = false;
                    dtgridSanPham.Rows[n].Cells[1].Value = item["TenSP"].ToString();
                    dtgridSanPham.Rows[n].Cells[2].Value = item["MoTa"].ToString();
                    dtgridSanPham.Rows[n].Cells[3].Value = item["TinhTrang"].ToString();
                    dtgridSanPham.Rows[n].Cells[4].Value = item["GiaThue"].ToString();
                    dtgridSanPham.Rows[n].Cells[5].Value = item["SoLuong"].ToString();
                    dtgridSanPham.Rows[n].Cells[6].Value = item["NhaSX"].ToString();
                    dtgridSanPham.Rows[n].Cells[7].Value = item["ManHinh"].ToString();
                    dtgridSanPham.Rows[n].Cells[8].Value = item["Ram"].ToString();
                    dtgridSanPham.Rows[n].Cells[9].Value = item["BoXuLy"].ToString();
                    dtgridSanPham.Rows[n].Cells[10].Value = item["DoHoa"].ToString();
                }
            }
            catch
            {
                lbThongBao1.Text = "Sản phẩm máy chiếu không có trong kho.";
            }
            
        }

        private void txtThemCMND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtThemCMND.Text = "";
            }
        }

        private void txtThemTenKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtThemTenKH.Text = "";
            }
        }

        private void txtThemSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtThemSDT.Text = "";
            }
        }

        private void txtThemDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtThemDiaChi.Text = "";
            }
        }

        private void dataShowSPChon_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbThongBao.Text = "Tìm kiếm khách hàng đã có trong danh sách.";
            }
           catch
            {
                lbThongBao.Text = "Tìm Kiếm khách hàng.";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                lbThongBaoLapHD.Text = "Bạn chưa làm cho chức năng này.";
            }
            catch
            {
                lbThongBaoLapHD.Text = "Không thể xem hóa đơn khi chưa có lập hóa đơn.";
            }
        }

        private void btHuyLapHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                lbThongBaoLapHD.Text = "Bạn chưa code cho chức năng này.";
            }
            catch
            {
                lbThongBaoLapHD.Text = "";
            }
        }
    }
}
