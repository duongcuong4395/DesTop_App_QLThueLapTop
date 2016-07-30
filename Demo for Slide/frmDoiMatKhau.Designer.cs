namespace Demo
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.grctrlDoiMatKhau = new DevExpress.XtraEditors.GroupControl();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.lbDMKNhapLai = new System.Windows.Forms.Label();
            this.lbDMKHienTai = new System.Windows.Forms.Label();
            this.lbDMKMoi = new System.Windows.Forms.Label();
            this.lbDMKTaiKhoan = new System.Windows.Forms.Label();
            this.txtDMKHienTai = new DevExpress.XtraEditors.TextEdit();
            this.txtDMKNhapLai = new DevExpress.XtraEditors.TextEdit();
            this.txtDMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtDMKTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrlDoiMatKhau)).BeginInit();
            this.grctrlDoiMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDMKHienTai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDMKNhapLai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDMKTaiKhoan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grctrlDoiMatKhau
            // 
            this.grctrlDoiMatKhau.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grctrlDoiMatKhau.CaptionImage")));
            this.grctrlDoiMatKhau.Controls.Add(this.btHuy);
            this.grctrlDoiMatKhau.Controls.Add(this.btDoiMatKhau);
            this.grctrlDoiMatKhau.Controls.Add(this.lbDMKNhapLai);
            this.grctrlDoiMatKhau.Controls.Add(this.lbDMKHienTai);
            this.grctrlDoiMatKhau.Controls.Add(this.lbDMKMoi);
            this.grctrlDoiMatKhau.Controls.Add(this.lbDMKTaiKhoan);
            this.grctrlDoiMatKhau.Controls.Add(this.txtDMKHienTai);
            this.grctrlDoiMatKhau.Controls.Add(this.txtDMKNhapLai);
            this.grctrlDoiMatKhau.Controls.Add(this.txtDMKMoi);
            this.grctrlDoiMatKhau.Controls.Add(this.txtDMKTaiKhoan);
            this.grctrlDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grctrlDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.grctrlDoiMatKhau.Name = "grctrlDoiMatKhau";
            this.grctrlDoiMatKhau.Size = new System.Drawing.Size(200, 301);
            this.grctrlDoiMatKhau.TabIndex = 4;
            this.grctrlDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // btHuy
            // 
            this.btHuy.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btHuy.Appearance.Options.UseFont = true;
            this.btHuy.Appearance.Options.UseForeColor = true;
            this.btHuy.Location = new System.Drawing.Point(34, 260);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(61, 29);
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btDoiMatKhau
            // 
            this.btDoiMatKhau.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiMatKhau.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btDoiMatKhau.Appearance.Options.UseFont = true;
            this.btDoiMatKhau.Appearance.Options.UseForeColor = true;
            this.btDoiMatKhau.Location = new System.Drawing.Point(101, 251);
            this.btDoiMatKhau.Name = "btDoiMatKhau";
            this.btDoiMatKhau.Size = new System.Drawing.Size(87, 38);
            this.btDoiMatKhau.TabIndex = 4;
            this.btDoiMatKhau.Text = "Đổi mật khẩu";
            this.btDoiMatKhau.Click += new System.EventHandler(this.btDoiMatKhau_Click);
            // 
            // lbDMKNhapLai
            // 
            this.lbDMKNhapLai.AutoSize = true;
            this.lbDMKNhapLai.Location = new System.Drawing.Point(20, 209);
            this.lbDMKNhapLai.Name = "lbDMKNhapLai";
            this.lbDMKNhapLai.Size = new System.Drawing.Size(111, 13);
            this.lbDMKNhapLai.TabIndex = 5;
            this.lbDMKNhapLai.Text = "Nhập lại mật khẩu mới";
            // 
            // lbDMKHienTai
            // 
            this.lbDMKHienTai.AutoSize = true;
            this.lbDMKHienTai.Location = new System.Drawing.Point(20, 114);
            this.lbDMKHienTai.Name = "lbDMKHienTai";
            this.lbDMKHienTai.Size = new System.Drawing.Size(89, 13);
            this.lbDMKHienTai.TabIndex = 4;
            this.lbDMKHienTai.Text = "Mật khẩu hiện tại";
            // 
            // lbDMKMoi
            // 
            this.lbDMKMoi.AutoSize = true;
            this.lbDMKMoi.Location = new System.Drawing.Point(20, 162);
            this.lbDMKMoi.Name = "lbDMKMoi";
            this.lbDMKMoi.Size = new System.Drawing.Size(70, 13);
            this.lbDMKMoi.TabIndex = 4;
            this.lbDMKMoi.Text = "Mật khẩu mới";
            // 
            // lbDMKTaiKhoan
            // 
            this.lbDMKTaiKhoan.AutoSize = true;
            this.lbDMKTaiKhoan.Location = new System.Drawing.Point(20, 64);
            this.lbDMKTaiKhoan.Name = "lbDMKTaiKhoan";
            this.lbDMKTaiKhoan.Size = new System.Drawing.Size(54, 13);
            this.lbDMKTaiKhoan.TabIndex = 3;
            this.lbDMKTaiKhoan.Text = "Tài Khoản";
            // 
            // txtDMKHienTai
            // 
            this.txtDMKHienTai.Location = new System.Drawing.Point(20, 132);
            this.txtDMKHienTai.Name = "txtDMKHienTai";
            this.txtDMKHienTai.Properties.PasswordChar = '*';
            this.txtDMKHienTai.Size = new System.Drawing.Size(144, 20);
            this.txtDMKHienTai.TabIndex = 1;
            // 
            // txtDMKNhapLai
            // 
            this.txtDMKNhapLai.Location = new System.Drawing.Point(20, 225);
            this.txtDMKNhapLai.Name = "txtDMKNhapLai";
            this.txtDMKNhapLai.Properties.PasswordChar = '*';
            this.txtDMKNhapLai.Size = new System.Drawing.Size(144, 20);
            this.txtDMKNhapLai.TabIndex = 3;
            this.txtDMKNhapLai.EditValueChanged += new System.EventHandler(this.txtDMKNhapLai_EditValueChanged);
            // 
            // txtDMKMoi
            // 
            this.txtDMKMoi.Location = new System.Drawing.Point(20, 178);
            this.txtDMKMoi.Name = "txtDMKMoi";
            this.txtDMKMoi.Properties.PasswordChar = '*';
            this.txtDMKMoi.Size = new System.Drawing.Size(144, 20);
            this.txtDMKMoi.TabIndex = 2;
            // 
            // txtDMKTaiKhoan
            // 
            this.txtDMKTaiKhoan.Location = new System.Drawing.Point(20, 83);
            this.txtDMKTaiKhoan.Name = "txtDMKTaiKhoan";
            this.txtDMKTaiKhoan.Size = new System.Drawing.Size(144, 20);
            this.txtDMKTaiKhoan.TabIndex = 0;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 301);
            this.Controls.Add(this.grctrlDoiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grctrlDoiMatKhau)).EndInit();
            this.grctrlDoiMatKhau.ResumeLayout(false);
            this.grctrlDoiMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDMKHienTai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDMKNhapLai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDMKTaiKhoan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grctrlDoiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btDoiMatKhau;
        private System.Windows.Forms.Label lbDMKNhapLai;
        private System.Windows.Forms.Label lbDMKHienTai;
        private System.Windows.Forms.Label lbDMKMoi;
        private System.Windows.Forms.Label lbDMKTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtDMKHienTai;
        private DevExpress.XtraEditors.TextEdit txtDMKNhapLai;
        private DevExpress.XtraEditors.TextEdit txtDMKMoi;
        private DevExpress.XtraEditors.TextEdit txtDMKTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btHuy;
    }
}