using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSLayer;
using DAL;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Linq;


namespace Demo
{
    public partial class ucQLSanPham : UserControl
    {
        public ucQLSanPham()
        {
            InitializeComponent();
        }

        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        QLSPDataContext qlsp = new QLSPDataContext();

        string loaiSanPham = "";

        private void ucQLSanPham_Load(object sender, EventArgs e)
        {
            grctrlSanPham.DataSource = sanPhamBUS.loadSanPham();
            Localizer.Active = new showMessageBox("&hủy bỏ", "&Hủy", "&Chấp nhận", "&Không", "&Được", "&Thử lại", "&Đồng ý");

            //picSanPham.Image = imageCollection.Images["close_16x16.png"];

            grctrlCauHinh.Enabled = false;
            grctrlTTSanPham.Enabled = false;


            lbThongBao.Text = "Chào mừng bạn đến với from quản lý sản phẩm.";
            lbThongBao.ForeColor = Color.Green;

            // tắt button thêm. xóa, sửa, mở file ảnh.
            btXoaSP.Enabled = false;
            btThemSamPham.Enabled = false;
            btSua.Enabled = false;
            btOpenFileImage.Enabled = false;
            cmbLoadLoaiSP.Text = "";

            // Sow loại sản phẩm lên Combobox
            loadComboboxLoaiSP();

            // Load tinh trang
            //loadTinhTrang();
        }

        public void loadTinhTrang()
        {
            var loadTT = from sanpham in qlsp.SANPHAMs
                         select new
                         {
                             idsp = sanpham.MaSP,
                             tenTingTrang = sanpham.TinhTrang,
                         };
            cmbTinhTrang.DataSource = loadTT.ToList();
            cmbTinhTrang.DisplayMember = "tenTingTrang";
            cmbTinhTrang.ValueMember = "idsp";
        }

        public void doitenColumns()
        {
        }

        private void grvwSanPham_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu as GridViewMenu;
                menu.Items.Clear();

                DXMenuItem itemEdit = new DXMenuItem("Sửa");
               
                itemEdit.Click += new EventHandler(itemEdit_Click);
                menu.Items.Add(itemEdit);

                DXMenuItem itemDelete = new DXMenuItem("Xóa");
                
                itemDelete.Click += new EventHandler(itemDelete_Click);
                menu.Items.Add(itemDelete);

                DXMenuItem itemAdd = new DXMenuItem("Thêm");
                itemAdd.Click += new EventHandler(itemAdd_Click);
                menu.Items.Add(itemAdd);

                txtTenSP.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmTenSP);
                string tinhtrang = grviewSanPham.GetFocusedRowCellDisplayText(grclmTinhTrang);


                // Kiểm tra 2 colum tenSP và Tình trạng có Trống hay không.
                if (txtTenSP.Text == "" || tinhtrang == "")
                {
                    XtraMessageBox.Show(" còn để trống, bạn hãy sửa nó.", "Thêm dữ liệu", MessageBoxButtons.OK);
                    lbThongBao.ForeColor = Color.Red;
                }
                else
                {
                    lbThongBao.ForeColor = Color.Green;
                }

                // Set lại enable cho các button (Thêm, Sửa, Mở file ảnh) Sản phẩm
                btThemSamPham.Enabled = false;
                btSua.Enabled = false;
                btOpenFileImage.Enabled = false;

                // Gọi hàm show thông tin SP lên các textBox và picture
                laythongtintrongRow();
            }
        }


        bool chonSua = false;
        // Gọi sự kiện click vào itemEdit của popup
        void itemEdit_Click(object sender, EventArgs e)
        {
            if (chonSua == false)
            {
                lb.Text = "THÔNG BÁO: ";
                lbThongBao.Text = "Nhân viên kế toán thì không thể (Thêm, Xóa, Sửa) TT sản phẩm.";
            }
            else
            {
                editSanPham();
            }
        }

        // Hàm Sửa TT Sản phẩm
        public void editSanPham()
        {
            lbThongBao.Text = "Sau khi sửa xong hãy nhấn vào nút (Đã sửa) để hoàn tất bạn nhé.";
            groupCctrlSanPham.Enabled = false;
            lbThongBao.ForeColor = Color.Green;
            grctrlTTSanPham.Enabled = true;

            btSua.Enabled = true;

            btThemSamPham.Enabled = false;
            btOpenFileImage.Enabled = true;

            //loadComboboxSP();
        }

        bool chonXoa = false;
        // Gọi sự kiện click vào itemDelete của popup
        void itemDelete_Click(object sender, EventArgs e)
        {
            // tùy theo quyền mà mình sẽ cho chọ quyền xóa.
            if (chonXoa == false)
            {
                lb.Text = "THÔNG BÁO: ";
                lbThongBao.Text = "Nhân viên kế toán thì không thể (Thêm, Xóa, Sửa) TT sản phẩm.";
            }
            else
            {
                lbThongBao.Text = "Nhấn nút đã xóa để hoàn tất xóa.";
                btXoaSP.Enabled = true;
                btSua.Enabled = false;
                btThemSamPham.Enabled = false;
                btOpenFileImage.Enabled = false;

                groupCctrlSanPham.Enabled = false;
                grctrlTTSanPham.Enabled = true;
                grctrlCauHinh.Enabled = true;
                //loadComboboxSP();
                //deleteSanPham();
            }
        }

        //Hàm Xóa row
        public void deleteSanPham()
        {
            // Đổi mã 
            try
            {
                int masanpham = Int32.Parse(txtMaSP.Text);
                DialogResult dialog = XtraMessageBox.Show("Bạn muốn xóa Sản phẩm : {0}.", "Xóa sản phẩm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                        sanPhamBUS.xoaSanPham(masanpham);
                        lbThongBao.Text = "Bạn đã xóa thành công sản phẩm này.";
                  
                }
                else
                {
                    lbThongBao.Text = "Bạn đã không quá sản phẩm này.";
                    resetTextBox();
                    grctrlSanPham.Enabled = true;
                }
            }
            catch
            {
                XtraMessageBox.Show("Sản phẩm : {0} vẫn còn trong bảng xuất sản phẩm.");
            }
            
            grctrlTTSanPham.Enabled = false;

            btThemSamPham.Enabled = false;
            btSua.Enabled = false;

            btOpenFileImage.Enabled = true;
            grctrlSanPham.DataSource = sanPhamBUS.loadSanPham();
            //loadComboboxSP();
        }

        bool chonThem = false;
        // Xự kiện Click vào item Add
        void itemAdd_Click(object sender, EventArgs e)
        {
            if (chonThem == false)
            {
                lb.Text = "THÔNG BÁO:";
                lbThongBao.Text = "Nhân viên kế toán thì không thể (Thêm, Xóa, Sửa) TT sản phẩm.";
            }
            else
            {
                AddSanPham();
            }
        }

        // Hàm thêm row
        public void AddSanPham()
        {
            resetTextBox();
            picSanPham.Image = imageCollection.Images["close_16x16.png"];
            lbThongBao.Text = "Bạn hãy điền đầy đủ thông sản phẩm mà bạn muốn thêm vào, sau đó nhấn vào nút (Đã thêm).";
            grctrlTTSanPham.Enabled = true;


            btThemSamPham.Enabled = true;

            btSua.Enabled = false;

            btOpenFileImage.Enabled = true;

            //loadComboboxSP();
        }


        



        private void btLoa_Click(object sender, EventArgs e)
        {
            loaiSanPham = "Loa";
            grctrlSanPham.DataSource = sanPhamBUS.loadLoaiSanPham(loaiSanPham);

            setVisibleChoColumns(false);

            cmbLoadLoaiSP.Text = btLoa.Text;
        }

        private void btLapTop_Click(object sender, EventArgs e)
        {
            loaiSanPham = "Laptop";
            grctrlSanPham.DataSource = sanPhamBUS.loadLoaiSanPham(loaiSanPham);

            setVisibleChoColumns(true);

            grviewSanPham.Columns["ManHinh"].Visible = true;
            grviewSanPham.Columns["Ram"].Visible = true;
            grviewSanPham.Columns["BoXuLy"].Visible = true;
            grviewSanPham.Columns["DoHoa"].Visible = true;

            grctrlTTSanPham.Enabled = false;
            grctrlCauHinh.Enabled = false;

            cmbLoadLoaiSP.Text = btLapTop.Text;
        }

        private void btManHinh_Click(object sender, EventArgs e)
        {
            loaiSanPham = "Màn hình";
            grctrlSanPham.DataSource = sanPhamBUS.loadLoaiSanPham(loaiSanPham);

            setVisibleChoColumns(false);
            grviewSanPham.Columns["ManHinh"].Visible = true;

            grctrlTTSanPham.Enabled = false;
            grctrlCauHinh.Enabled = false;

            cmbLoadLoaiSP.Text = btManHinh.Text;
        }

        public void setVisibleChoColumns(bool giatri)
        {
            grviewSanPham.Columns["ManHinh"].Visible = giatri;
            grviewSanPham.Columns["Ram"].Visible = giatri;
            grviewSanPham.Columns["BoXuLy"].Visible = giatri;
            grviewSanPham.Columns["DoHoa"].Visible = giatri;
        }

        private void grviewSanPham_RowClick(object sender, RowClickEventArgs e)
        {

        }

        string fileName = "";

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            moHinhAnh();
            btSua.Enabled = true;
        }

        private void grctrlSanPham_Click(object sender, EventArgs e)
        {
            laythongtintrongRow();
            // txtMaNhanVien.Text = grvwNhanVien.GetFocusedRowCellDisplayText(gridColumn1);

            // load ảnh sản phẩm lên picturebox
            kiemtraAnhSanPham();
            lbThongBao.Text = "Bạn không thể sửa j ở trong này. vui lòng click chuột phải và chọn 'sửa'.";
        }

        // Hàm kiểm tra ảnh sản phẩm đã có chưa.
        public void kiemtraAnhSanPham()
        {
            try
            {
                var sanpham = (from sp in qlsp.SANPHAMs
                               where sp.MaSP == int.Parse(txtMaSP.Text)
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

        // Hàm mở HÌnh ảnh
        private void moHinhAnh()
        {
            OpenFileDialog openfile = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };
            try
            {
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    fileName = openfile.FileName;
                    //lbFilename.Text = filename;
                    picSanPham.Image = Image.FromFile(fileName);
                    Image image = Image.FromFile(fileName);
                    if (image.Width < picSanPham.Width && image.Height < picSanPham.Height)
                    {
                        picSanPham.SizeMode = PictureBoxSizeMode.Normal;
                    }
                    else
                    {
                        picSanPham.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            // File chọn ko phải là file ảnh (jpg, ....)
            catch
            {
                XtraMessageBox.Show(string.Format("File : {0} Không phải là file hình ảnh, hãy chọn file khác(.ipg)", fileName), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int co;
        // Hàm xử lý các textBox cac san pham khac ngoai LapTop
        int kiemtraTextBoxRong()
        {
            // Kiểm tra cho SP Loa và máy chiếu
            if (cmbTinhTrang.Text == "" || txtTenSP.Text == "" || txtSoLuong.Text == "" || txtGiaThue.Text == "" || txtNhaSX.Text == "" || txtMoTa.Text == "")
            {
                co = 3;
            }
            else
            {
                co = 0;
            }

            // Kiểm tra SP Màn Hình
            if (cmbTinhTrang.Text == "" || txtTenSP.Text == "" || txtSoLuong.Text == "" || txtGiaThue.Text == "" || txtNhaSX.Text == "" || txtMoTa.Text == "" || txtManHinh.Text == "")
            {
                co = 2;
            }
            else
            {
                co = 0;
            }

            // Kiểm tra SP Laptop
            if (cmbTinhTrang.Text == "" || txtTenSP.Text == "" || txtSoLuong.Text == "" || txtGiaThue.Text == "" || txtNhaSX.Text == "" || txtMoTa.Text == "" || txtManHinh.Text == "" || txtRam.Text == "" || txtBoXuLy.Text == "" || txtDoHoa.Text == "")
            {
                co = 1;
            }
            else
            {
                co = 0;
            }
            return co;
        }

        void kiemtrachonLoaiSP()
        {
            string loaisanpham = "";
            cmbLoadLoaiSP.Text = loaisanpham;

            try
            {
                switch (loaisanpham)
                {
                    case "Laptop":
                        if (kiemtraTextBoxRong() == 1)
                        {
                            lbThongBao.Text = "Bạn chưa điền đủ thông tin.";
                        }
                        break;
                    case "Màn hình":
                        if (kiemtraTextBoxRong() == 2)
                        {
                            lbThongBao.Text = "Bạn chưa điền đủ thông tin.";
                        }
                        break;
                    case "Loa":
                        if (kiemtraTextBoxRong() == 3)
                        {
                            lbThongBao.Text = "Bạn chưa điền đủ thông tin.";
                        }
                        break;
                    case "Máy chiếu":
                        if (kiemtraTextBoxRong() == 3)
                        {
                            lbThongBao.Text = "Bạn chưa điền đủ thông tin.";
                        }
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                lbThongBao.Text = "?";
            }

        }

        void setHinhErrorTextBoxRong()
        {
            if (txtTenSP.Text == "")
            {
                dxErrorProvider.SetError(txtTenSP, "Chưa nhập tên sản phẩm....");
            }
            else
            {
                lbThongBao.Text = "Bạn đã thay đổi.";
            }

            if (txtSoLuong.Text == "")
            {
                dxErrorProvider.SetError(txtSoLuong, "Chưa nhập số lượng....");
            }
            else
            {
                lbThongBao.Text = "Bạn đã thay đổi.";
            }

            if (txtGiaThue.Text == "")
            {
                dxErrorProvider.SetError(txtGiaThue, "Chưa nhập giá thuê...");
            }
            else
            {
                lbThongBao.Text = "Bạn đã thay đổi.";
            }

            if (txtNhaSX.Text == "")
            {
                dxErrorProvider.SetError(txtNhaSX, "Chưa nhập Nhà sản xuất...");
            }
            else
            {
                lbThongBao.Text = "Bạn đã thay đổi.";
            }

            if (txtMoTa.Text == "")
            {
                dxErrorProvider.SetError(txtMoTa, "Chưa nhập mô tả...");
            }
            else
            {
                lbThongBao.Text = "Bạn đã thay đổi.";
            }

            if (txtManHinh.Text == "")
            {
                dxErrorProvider.SetError(txtManHinh, "Chưa nhập màn hình...");
            }
            else
            {
                lbThongBao.Text = "Bạn đã thay đổi.";
            }

            if (txtRam.Text == "")
            {
                dxErrorProvider.SetError(txtRam, "Chưa nhập Ram...");
            }
            else
            {
                lbThongBao.Text = "Bạn đã thay đổi.";
            }

            if (txtBoXuLy.Text == "")
            {
                dxErrorProvider.SetError(txtBoXuLy, "Chưa nhập bộ xử lý...");
            }
            else
            {
                lbThongBao.Text = "Bạn đã thay đổi.";
            }

            // 
            if (txtDoHoa.Text == "")
            {
                dxErrorProvider.SetError(txtDoHoa, "Chưa nhập đồ họa...");
            }
            else
            {
                lbThongBao.Text = "Bạn đã thay đổi.";
            }
        }

        // Hàm load Combobox Loai SP
        public void loadComboboxLoaiSP()
        {
            // Chọn ra 2 thuộc tính tên loại mà mã loại 
            var loaiSP = from loai in qlsp.LOAISPs
                         select new
                         {
                             tenloai = loai.TenLoaiSP,
                             maloai = loai.MaLoaiSP,
                         };

            cmbLoadLoaiSP.DataSource = loaiSP.ToList();
            cmbLoadLoaiSP.DisplayMember = "tenloai";
            cmbLoadLoaiSP.ValueMember = "maloai";
        }

        // Đưa thông tin từ data gridview lên textbox
        public void laythongtintrongRow()
        {
            //Hiển thị lên group Control Thông tin sản phẩm
            txtMaSP.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmMaSP);
            cmbLoadLoaiSP.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmLoaiSP);
            cmbTinhTrang.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmTinhTrang);
            txtTenSP.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmTenSP);
            txtGiaThue.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmGiaThue);
            txtSoLuong.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmSoLuong);
            txtNhaSX.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmNhaSX);

            // Hiển thi thông tin lên group Control Cấu hình
            txtManHinh.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmManHinh);
            txtRam.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmRam);
            txtBoXuLy.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmBoXuLy);
            txtDoHoa.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmDoHoa);
            txtMoTa.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmMoTa);


            //txtTTSanPham.Text = grviewSanPham.GetFocusedRowCellDisplayText(grclmMoTa);
            //picSanPham.Image = imageCollection.Images["close_16x16.png"];
        }

        private void btThemSamPham_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = XtraMessageBox.Show(string.Format("Bạn muốn thêm sản phẩm: {0} trong danh sách.", txtTenSP.Text), "Thêm sản phẩm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (cmbTinhTrang.Text == "" || cmbLoadLoaiSP.Text == "")
                    {
                        lbThongBao.Text = "Tình trạng Chưa có giá gị.";
                    }
                    else
                    {
                        setHinhErrorTextBoxRong();
                        kiemtrachonLoaiSP();
                        themSanPham();
                    }
                }
                else
                {
                    lbThongBao.Text = "Bạn đã không thêm sản thẩm vào danh sách.";
                    resetTextBox();
                    grctrlSanPham.Enabled = true;
                }
            }
            catch
            {
                XtraMessageBox.Show("Thông tin hoặc hình ảnh còn thiếu.", "Thêm ảnh", MessageBoxButtons.OK);
            }
            grctrlSanPham.DataSource = sanPhamBUS.loadSanPham();
        }


        // Hàm Thêm sản phẩm
        public void themSanPham()
        {
            int giathue = Int32.Parse(txtGiaThue.Text);
            int soluong = int.Parse(txtSoLuong.Text);
            string maloai = cmbLoadLoaiSP.SelectedValue.ToString();
            int ml = int.Parse(maloai);
            if (sanPhamBUS.kiemTraSanPhamTrung(txtTenSP.Text) == true)
            {
                // Chuyển imgage => Binary thoogn qua Byte[]
                byte[] file_Image = ImageToByteArray(picSanPham.Image);
                Binary file_Binary = new Binary(file_Image);

                DialogResult dialog = XtraMessageBox.Show("Bạn muốn giữ ảnh này cho sản phẩm?", "Thêm ảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    sanPhamBUS.themSanPham(txtTenSP.Text, txtMoTa.Text, cmbTinhTrang.Text, giathue, soluong, txtNhaSX.Text, txtManHinh.Text, txtRam.Text, txtBoXuLy.Text, txtDoHoa.Text, file_Binary, ml);
                }
                else
                {
                    lbThongBao.Text = "Bạn hãy thay đổi hình ảnh trước khi thêm vào.";
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = XtraMessageBox.Show(string.Format("Bạn có muốn sửa thông tin sản phẩm {0}.", txtTenSP.Text), "Sửa sản phẩm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    // Gọi lại hàm sửa sản phẩm
                    suaSanPham();

                    //picSanPham.Image = imageCollection.Images["close_16x16.png"];
                    lbThongBao.Text = "Bạn hãy chọn một dòng sản phẩm để làm việc.";
                    btSua.Enabled = false;
                    btOpenFileImage.Enabled = false;
                    grctrlCauHinh.Enabled = false;
                    grctrlTTSanPham.Enabled = false;
                    groupCctrlSanPham.Enabled = true;
                }
                else
                {
                    lbThongBao.Text = "Bạn đã ko sửa sản phẩm này. Bạn hãy chọn một dòng sản phẩm để làm việc.";
                    resetTextBox();
                    btSua.Enabled = false;
                    btOpenFileImage.Enabled = false;
                    grctrlCauHinh.Enabled = false;
                    grctrlTTSanPham.Enabled = false;
                    groupCctrlSanPham.Enabled = true;
                }
            }
            catch
            {
                XtraMessageBox.Show("Chưa có hình ảnh.");
            }
            grctrlSanPham.DataSource = sanPhamBUS.loadSanPham();
        }

        // Hàm sửa sản phẩm
        public void suaSanPham()
        {
            int masp = int.Parse(txtMaSP.Text);
            int giathue = int.Parse(txtGiaThue.Text);
            int soluong = int.Parse(txtSoLuong.Text);

            DialogResult suaAnh = XtraMessageBox.Show("Bạn vẫn muốn giữ ảnh này lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (suaAnh == DialogResult.Yes)
            {
                //Chuyển image thành binary thông qua byte[]
                byte[] file_Byte = ImageToByteArray(picSanPham.Image);
                Binary file_Binary = new Binary(file_Byte);

                sanPhamBUS.suaSanPham(masp, txtTenSP.Text, txtMoTa.Text, cmbTinhTrang.Text, giathue, soluong, txtNhaSX.Text, txtManHinh.Text, txtRam.Text, txtBoXuLy.Text, txtDoHoa.Text, file_Binary);
            }
            else
            {
                // set enable của 2 buuton Mở file ảnh và Sửa
                btOpenFileImage.Enabled = true;
                btSua.Enabled = false;
            }
        }

        // Hàm dùng để chuyển image => byte[]
        private byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        // Hàm reset lại các textbox
        private void resetTextBox()
        {
            txtBoXuLy.Text = "";
            txtDoHoa.Text = "";
            txtGiaThue.Text = "";
            txtManHinh.Text = "";
            txtMaSP.Text = "";
            txtMoTa.Text = "";
            txtNhaSX.Text = "";
            txtRam.Text = "";
            txtSoLuong.Text = "";
            txtTenSP.Text = "";

            //txtTTSanPham.Text = "";
        }

        private void grviewSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            lbThongBao.Text = "Bạn không thể sửa j ở trong này. vui lòng click chuột phải và click vào sửa.";
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lbThongBao.Text = "không thể nhập ký tự khác ngoài số trong ô (số lượng).";
            }
            if (txtSoLuong.Text.Length >= 2)
            {
                e.Handled = true;
                lbThongBao.Text = "Giới hạn số lượng < 100.";
            }
        }



        private void txtGiaThue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lbThongBao.Text = "không thể nhập ký tự khác ngoài số trong ô (Giá thuê).";
            }

            if (txtGiaThue.Text.Length > 6)
            {
                e.Handled = true;
                lbThongBao.Text = "Giá không vượt quá 6 con số";
            }
            else
            {
                e.Handled = false;
            }
        }



        private void cmbLoadLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoadLoaiSP.Text == "Laptop")
            {
                grctrlCauHinh.Enabled = true;
            }
            else if (cmbLoadLoaiSP.Text == "Màn hình")
            {
                grctrlCauHinh.Enabled = true;

                txtManHinh.Enabled = true;

                txtRam.Enabled = false;
                txtBoXuLy.Enabled = false;
                txtDoHoa.Enabled = false;
            }
            else
            {
                grctrlCauHinh.Enabled = false;
            }
        }

        private void panelControl3_MouseHover(object sender, EventArgs e)
        {
            lbTenSP.ForeColor = Color.Blue;
        }

        private void panelControl3_MouseLeave(object sender, EventArgs e)
        {
            lbTenSP.ForeColor = Color.Black;
        }

        private void lbDoHoa_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            lbTenSP.Text = txtTenSP.Text;
        }

        private void txtRam_TextChanged(object sender, EventArgs e)
        {
            lbRam.Text = "Ram:        " + txtRam.Text;
        }

        private void txtBoXuLy_TextChanged(object sender, EventArgs e)
        {
            lbBoXuLy.Text = "Bộ xử lý:   " + txtBoXuLy.Text;
        }

        private void txtDoHoa_TextChanged(object sender, EventArgs e)
        {
            lbDoHoa.Text = "Đồ họa:     " + txtDoHoa.Text;
        }

        private void txtManHinh_TextChanged(object sender, EventArgs e)
        {
            lbManHinh.Text = "Màn hình:  " + txtManHinh.Text;
        }

        private void cmbLoadLoaiSP_TextChanged(object sender, EventArgs e)
        {
            loaiSanPham = cmbLoadLoaiSP.Text;

            if (loaiSanPham == "Laptop")
            {
                grctrlCauHinh.Enabled = true;
                txtBoXuLy.Enabled = true;
                txtManHinh.Enabled = true;
                txtRam.Enabled = true;
                txtDoHoa.Enabled = true;
            }
            else if (loaiSanPham == "Màn hình")
            {
                grctrlCauHinh.Enabled = true;

                txtManHinh.Enabled = true;

                txtRam.Enabled = false;
                txtRam.Text = " ";
                txtBoXuLy.Enabled = false;
                txtBoXuLy.Text = " ";
                txtDoHoa.Enabled = false;
                txtDoHoa.Text = " ";
            }
            else
            {
                grctrlCauHinh.Enabled = false;
                txtManHinh.Text = " ";
                txtRam.Text = " ";
                txtBoXuLy.Text = " ";
                txtDoHoa.Text = " ";
            }
        }



        private void btLoadTatCa_Click(object sender, EventArgs e)
        {
            grctrlSanPham.DataSource = sanPhamBUS.loadSanPham();
            setVisibleChoColumns(true);
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {
            lbMota.Text = "Mô tả:        " + txtMoTa.Text;
        }

        private void grctrlSanPham_MouseClick(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInFo = new DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo();
            //if ( !hitInFo.InColumn || hitInFo.Column.Name = "grclmMaSP" || )
        }

        private void grctrlSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            lbThongBao.Text = "Bạn không thể sửa j ở trong này. vui lòng click chuột phải và click vào sửa.";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lbThongBao.Text = "Bạn đã lỡ tay chọn nhầm.";

            grctrlTTSanPham.Enabled = false;
            grctrlCauHinh.Enabled = false;

            groupCctrlSanPham.Enabled = true;

            btThemSamPham.Enabled = false;
            btSua.Enabled = false;
            btXoaSP.Enabled = false;
            btOpenFileImage.Enabled = false;
        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {
            //dxErrorProvider.SetError(txtTinhTrang, "");
        }

        private void btMayChieu_Click(object sender, EventArgs e)
        {
            loaiSanPham = "Máy chiếu";
            grctrlSanPham.DataSource = sanPhamBUS.loadLoaiSanPham(loaiSanPham);

            setVisibleChoColumns(false);
            grviewSanPham.Columns["ManHinh"].Visible = false;
            grviewSanPham.Columns["Ram"].Visible = false;
            grviewSanPham.Columns["BoXuLy"].Visible = false;
            grviewSanPham.Columns["DoHoa"].Visible = false;

            grctrlTTSanPham.Enabled = false;
            grctrlCauHinh.Enabled = false;

            cmbLoadLoaiSP.Text = btMayChieu.Text;
        }

        private void cmbLoadLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbTinhTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtGiaThue_TextChanged(object sender, EventArgs e)
        {
            lbGiaThue.Text = txtGiaThue.Text + "   Đồng/1SP";

        }

        private void txtGiaThue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtGiaThue.Text = "";
            }
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtSoLuong.Text = "";
            }
        }

        private void txtNhaSX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void QuyennhanvienQLThue()
        {
            chonXoa = true;
            chonSua = true;
            chonThem = true;
            panelControl4.Visible = true;
            pnctrlEdit.Visible = true;
        }

        // QLSP theo nhân viên kế toán
        public void QLSPofnhanvienKeToan()
        {
            // Tắc đi 2 pannel thông tin sản phẩm và pannel cấu hình
            panelControl4.Visible = false;
            pnctrlEdit.Visible = false;
            // Thêm xóa sửa Sản phẩm sẽ bị false
            chonThem = false;
            chonXoa = false;
            chonSua = false;

            
        }

        public void QuyenAdminQLSP()
        {
            // Tắc đi 2 pannel thông tin sản phẩm và pannel cấu hình
            panelControl4.Visible = true;
            pnctrlEdit.Visible = true;
            // Thêm xóa sửa Sản phẩm sẽ bị false
            chonThem = true;
            chonXoa = true;
            chonSua = true;
        }

        private void btXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                int masanpham = Int32.Parse(txtMaSP.Text);
                DialogResult dialog = XtraMessageBox.Show("Bạn muốn xóa Sản phẩm", "Xóa sản phẩm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    sanPhamBUS.xoaSanPham(masanpham);
                    lbThongBao.Text = "Bạn đã xóa thành công sản phẩm này.";

                }
                else
                {
                    lbThongBao.Text = "Bạn đã không quá sản phẩm này.";
                    resetTextBox();
                    grctrlSanPham.Enabled = true;
                }
            }
            catch
            {
                XtraMessageBox.Show("Sản phẩm :  vẫn còn trong bảng xuất sản phẩm.");
            }

            //tắt group TT Sản phẩm và TT Cấu hình 
            // bất group của các sản phẩm.
            grctrlCauHinh.Enabled = false;
            grctrlTTSanPham.Enabled = false;
            groupCctrlSanPham.Enabled = true;

            //Tắt các button thêm xóa sửa, mở ảnh
            btThemSamPham.Enabled = false;
            btSua.Enabled = false;
            btXoaSP.Enabled = false;
            btOpenFileImage.Enabled = false;

            // load lại grid control sản phẩm
            grctrlSanPham.DataSource = sanPhamBUS.loadSanPham();
        }
    }
}
