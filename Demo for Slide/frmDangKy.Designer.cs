namespace Demo
{
    partial class frmDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.grctrlDangKy = new DevExpress.XtraEditors.GroupControl();
            this.txtThongBao = new System.Windows.Forms.TextBox();
            this.btOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.lbDKDiaChi = new System.Windows.Forms.Label();
            this.lbDKEmail = new System.Windows.Forms.Label();
            this.btHuyDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.txtDKDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.btDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.txtDKEmail = new DevExpress.XtraEditors.TextEdit();
            this.lbDKTenNguoiDung = new System.Windows.Forms.Label();
            this.txtDKTenNguoiDung = new DevExpress.XtraEditors.TextEdit();
            this.lbDKMatKhau = new System.Windows.Forms.Label();
            this.lbDKSDT = new System.Windows.Forms.Label();
            this.txtDKMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtDKSDT = new DevExpress.XtraEditors.TextEdit();
            this.lbDKTaiKhoan = new System.Windows.Forms.Label();
            this.txtDKTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrlDangKy)).BeginInit();
            this.grctrlDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKTenNguoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKTaiKhoan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grctrlDangKy
            // 
            this.grctrlDangKy.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grctrlDangKy.CaptionImage")));
            this.grctrlDangKy.Controls.Add(this.txtThongBao);
            this.grctrlDangKy.Controls.Add(this.btOpenFile);
            this.grctrlDangKy.Controls.Add(this.picNhanVien);
            this.grctrlDangKy.Controls.Add(this.lbDKDiaChi);
            this.grctrlDangKy.Controls.Add(this.lbDKEmail);
            this.grctrlDangKy.Controls.Add(this.btHuyDangKy);
            this.grctrlDangKy.Controls.Add(this.txtDKDiaChi);
            this.grctrlDangKy.Controls.Add(this.btDangKy);
            this.grctrlDangKy.Controls.Add(this.txtDKEmail);
            this.grctrlDangKy.Controls.Add(this.lbDKTenNguoiDung);
            this.grctrlDangKy.Controls.Add(this.txtDKTenNguoiDung);
            this.grctrlDangKy.Controls.Add(this.lbDKMatKhau);
            this.grctrlDangKy.Controls.Add(this.lbDKSDT);
            this.grctrlDangKy.Controls.Add(this.txtDKMatKhau);
            this.grctrlDangKy.Controls.Add(this.txtDKSDT);
            this.grctrlDangKy.Controls.Add(this.lbDKTaiKhoan);
            this.grctrlDangKy.Controls.Add(this.txtDKTaiKhoan);
            this.grctrlDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grctrlDangKy.Location = new System.Drawing.Point(0, 0);
            this.grctrlDangKy.Name = "grctrlDangKy";
            this.grctrlDangKy.Size = new System.Drawing.Size(389, 415);
            this.grctrlDangKy.TabIndex = 2;
            this.grctrlDangKy.Text = "Đăng ký";
            this.grctrlDangKy.Paint += new System.Windows.Forms.PaintEventHandler(this.grctrlDangKy_Paint);
            // 
            // txtThongBao
            // 
            this.txtThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtThongBao.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtThongBao.Location = new System.Drawing.Point(280, 197);
            this.txtThongBao.Multiline = true;
            this.txtThongBao.Name = "txtThongBao";
            this.txtThongBao.ReadOnly = true;
            this.txtThongBao.Size = new System.Drawing.Size(104, 152);
            this.txtThongBao.TabIndex = 9;
            this.txtThongBao.Text = "Chúng tôi chỉ hiện button Đăng ký\r\n khi bạn điền đủ thông tin và có ảnh đại diện." +
    "";
            // 
            // btOpenFile
            // 
            this.btOpenFile.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenFile.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btOpenFile.Appearance.Options.UseFont = true;
            this.btOpenFile.Appearance.Options.UseForeColor = true;
            this.btOpenFile.Location = new System.Drawing.Point(290, 357);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(87, 46);
            this.btOpenFile.TabIndex = 8;
            this.btOpenFile.Text = "Open file";
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // picNhanVien
            // 
            this.picNhanVien.Location = new System.Drawing.Point(12, 208);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(247, 193);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 7;
            this.picNhanVien.TabStop = false;
            this.picNhanVien.Click += new System.EventHandler(this.picNhanVien_Click);
            this.picNhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.picNhanVien_Paint);
            // 
            // lbDKDiaChi
            // 
            this.lbDKDiaChi.AutoSize = true;
            this.lbDKDiaChi.Location = new System.Drawing.Point(141, 166);
            this.lbDKDiaChi.Name = "lbDKDiaChi";
            this.lbDKDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lbDKDiaChi.TabIndex = 0;
            this.lbDKDiaChi.Text = "Địa chỉ:";
            // 
            // lbDKEmail
            // 
            this.lbDKEmail.AutoSize = true;
            this.lbDKEmail.Location = new System.Drawing.Point(144, 113);
            this.lbDKEmail.Name = "lbDKEmail";
            this.lbDKEmail.Size = new System.Drawing.Size(31, 13);
            this.lbDKEmail.TabIndex = 0;
            this.lbDKEmail.Text = "Email";
            // 
            // btHuyDangKy
            // 
            this.btHuyDangKy.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuyDangKy.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btHuyDangKy.Appearance.Options.UseFont = true;
            this.btHuyDangKy.Appearance.Options.UseForeColor = true;
            this.btHuyDangKy.Location = new System.Drawing.Point(290, 145);
            this.btHuyDangKy.Name = "btHuyDangKy";
            this.btHuyDangKy.Size = new System.Drawing.Size(87, 46);
            this.btHuyDangKy.TabIndex = 6;
            this.btHuyDangKy.Text = "Hủy";
            this.btHuyDangKy.Click += new System.EventHandler(this.btHuyDangKy_Click);
            // 
            // txtDKDiaChi
            // 
            this.txtDKDiaChi.Location = new System.Drawing.Point(147, 182);
            this.txtDKDiaChi.Name = "txtDKDiaChi";
            this.txtDKDiaChi.Size = new System.Drawing.Size(112, 20);
            this.txtDKDiaChi.TabIndex = 4;
            // 
            // btDangKy
            // 
            this.btDangKy.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangKy.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btDangKy.Appearance.Options.UseFont = true;
            this.btDangKy.Appearance.Options.UseForeColor = true;
            this.btDangKy.Location = new System.Drawing.Point(290, 86);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(87, 40);
            this.btDangKy.TabIndex = 5;
            this.btDangKy.Text = "Đăng ký";
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // txtDKEmail
            // 
            this.txtDKEmail.Location = new System.Drawing.Point(147, 131);
            this.txtDKEmail.Name = "txtDKEmail";
            this.txtDKEmail.Size = new System.Drawing.Size(112, 20);
            this.txtDKEmail.TabIndex = 4;
            // 
            // lbDKTenNguoiDung
            // 
            this.lbDKTenNguoiDung.AutoSize = true;
            this.lbDKTenNguoiDung.Location = new System.Drawing.Point(12, 64);
            this.lbDKTenNguoiDung.Name = "lbDKTenNguoiDung";
            this.lbDKTenNguoiDung.Size = new System.Drawing.Size(82, 13);
            this.lbDKTenNguoiDung.TabIndex = 0;
            this.lbDKTenNguoiDung.Text = "Tên người dùng";
            // 
            // txtDKTenNguoiDung
            // 
            this.txtDKTenNguoiDung.Location = new System.Drawing.Point(12, 83);
            this.txtDKTenNguoiDung.Name = "txtDKTenNguoiDung";
            this.txtDKTenNguoiDung.Size = new System.Drawing.Size(117, 20);
            this.txtDKTenNguoiDung.TabIndex = 1;
            // 
            // lbDKMatKhau
            // 
            this.lbDKMatKhau.AutoSize = true;
            this.lbDKMatKhau.Location = new System.Drawing.Point(144, 64);
            this.lbDKMatKhau.Name = "lbDKMatKhau";
            this.lbDKMatKhau.Size = new System.Drawing.Size(51, 13);
            this.lbDKMatKhau.TabIndex = 0;
            this.lbDKMatKhau.Text = "Mật khẩu";
            // 
            // lbDKSDT
            // 
            this.lbDKSDT.AutoSize = true;
            this.lbDKSDT.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbDKSDT.Location = new System.Drawing.Point(12, 164);
            this.lbDKSDT.Name = "lbDKSDT";
            this.lbDKSDT.Size = new System.Drawing.Size(73, 13);
            this.lbDKSDT.TabIndex = 0;
            this.lbDKSDT.Text = "Số điện thoại:";
            // 
            // txtDKMatKhau
            // 
            this.txtDKMatKhau.Location = new System.Drawing.Point(144, 83);
            this.txtDKMatKhau.Name = "txtDKMatKhau";
            this.txtDKMatKhau.Properties.PasswordChar = '*';
            this.txtDKMatKhau.Size = new System.Drawing.Size(115, 20);
            this.txtDKMatKhau.TabIndex = 3;
            // 
            // txtDKSDT
            // 
            this.txtDKSDT.Location = new System.Drawing.Point(12, 182);
            this.txtDKSDT.Name = "txtDKSDT";
            this.txtDKSDT.Size = new System.Drawing.Size(117, 20);
            this.txtDKSDT.TabIndex = 2;
            // 
            // lbDKTaiKhoan
            // 
            this.lbDKTaiKhoan.AutoSize = true;
            this.lbDKTaiKhoan.Location = new System.Drawing.Point(12, 113);
            this.lbDKTaiKhoan.Name = "lbDKTaiKhoan";
            this.lbDKTaiKhoan.Size = new System.Drawing.Size(53, 13);
            this.lbDKTaiKhoan.TabIndex = 0;
            this.lbDKTaiKhoan.Text = "Tài khoản";
            // 
            // txtDKTaiKhoan
            // 
            this.txtDKTaiKhoan.Location = new System.Drawing.Point(12, 131);
            this.txtDKTaiKhoan.Name = "txtDKTaiKhoan";
            this.txtDKTaiKhoan.Size = new System.Drawing.Size(117, 20);
            this.txtDKTaiKhoan.TabIndex = 2;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 415);
            this.Controls.Add(this.grctrlDangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grctrlDangKy)).EndInit();
            this.grctrlDangKy.ResumeLayout(false);
            this.grctrlDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKTenNguoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDKTaiKhoan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grctrlDangKy;
        private System.Windows.Forms.Label lbDKEmail;
        private DevExpress.XtraEditors.SimpleButton btHuyDangKy;
        private DevExpress.XtraEditors.SimpleButton btDangKy;
        private DevExpress.XtraEditors.TextEdit txtDKEmail;
        private System.Windows.Forms.Label lbDKTenNguoiDung;
        private DevExpress.XtraEditors.TextEdit txtDKTenNguoiDung;
        private System.Windows.Forms.Label lbDKMatKhau;
        private DevExpress.XtraEditors.TextEdit txtDKMatKhau;
        private System.Windows.Forms.Label lbDKTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtDKTaiKhoan;
        private System.Windows.Forms.Label lbDKDiaChi;
        private DevExpress.XtraEditors.TextEdit txtDKDiaChi;
        private System.Windows.Forms.Label lbDKSDT;
        private DevExpress.XtraEditors.TextEdit txtDKSDT;
        private DevExpress.XtraEditors.SimpleButton btOpenFile;
        private System.Windows.Forms.PictureBox picNhanVien;
        private System.Windows.Forms.TextBox txtThongBao;
    }
}