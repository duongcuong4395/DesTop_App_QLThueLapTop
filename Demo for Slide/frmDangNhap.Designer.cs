namespace Demo
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.grcntrDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.picSeePass = new DevExpress.XtraEditors.PictureEdit();
            this.picChange2 = new DevExpress.XtraEditors.PictureEdit();
            this.picChange1 = new DevExpress.XtraEditors.PictureEdit();
            this.btMinimize = new DevExpress.XtraEditors.SimpleButton();
            this.btExit = new DevExpress.XtraEditors.SimpleButton();
            this.lbDNTaiKhoan = new System.Windows.Forms.Label();
            this.btDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.lbDNQuenMatKhau = new System.Windows.Forms.Label();
            this.txtDNMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.lbDNMatKhau = new System.Windows.Forms.Label();
            this.txtDNTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcntrDangNhap)).BeginInit();
            this.grcntrDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChange2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChange1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNTaiKhoan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("fullstackedsplinearea_32x32.png", "images/chart/fullstackedsplinearea_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/fullstackedsplinearea_32x32.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "fullstackedsplinearea_32x32.png");
            this.imageCollection.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "apply_16x16.png");
            this.imageCollection.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "cancel_16x16.png");
            this.imageCollection.Images.SetKeyName(3, "Cancel-30.png");
            // 
            // grcntrDangNhap
            // 
            this.grcntrDangNhap.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grcntrDangNhap.Appearance.Options.UseBackColor = true;
            this.grcntrDangNhap.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcntrDangNhap.AppearanceCaption.FontSizeDelta = 2;
            this.grcntrDangNhap.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.grcntrDangNhap.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.grcntrDangNhap.AppearanceCaption.Options.UseFont = true;
            this.grcntrDangNhap.AppearanceCaption.Options.UseForeColor = true;
            this.grcntrDangNhap.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grcntrDangNhap.CaptionImage")));
            this.grcntrDangNhap.Controls.Add(this.picSeePass);
            this.grcntrDangNhap.Controls.Add(this.picChange2);
            this.grcntrDangNhap.Controls.Add(this.picChange1);
            this.grcntrDangNhap.Controls.Add(this.btMinimize);
            this.grcntrDangNhap.Controls.Add(this.btExit);
            this.grcntrDangNhap.Controls.Add(this.lbDNTaiKhoan);
            this.grcntrDangNhap.Controls.Add(this.btDangNhap);
            this.grcntrDangNhap.Controls.Add(this.lbDNQuenMatKhau);
            this.grcntrDangNhap.Controls.Add(this.txtDNMatKhau);
            this.grcntrDangNhap.Controls.Add(this.lbDNMatKhau);
            this.grcntrDangNhap.Controls.Add(this.txtDNTaiKhoan);
            this.grcntrDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcntrDangNhap.Location = new System.Drawing.Point(0, 0);
            this.grcntrDangNhap.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.grcntrDangNhap.LookAndFeel.SkinName = "Valentine";
            this.grcntrDangNhap.Name = "grcntrDangNhap";
            this.grcntrDangNhap.Size = new System.Drawing.Size(291, 217);
            this.grcntrDangNhap.TabIndex = 0;
            this.grcntrDangNhap.Text = "Đăng nhập";
            this.grcntrDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.grcntrDangNhap_Paint);
            // 
            // picSeePass
            // 
            this.picSeePass.EditValue = ((object)(resources.GetObject("picSeePass.EditValue")));
            this.picSeePass.Location = new System.Drawing.Point(218, 114);
            this.picSeePass.Name = "picSeePass";
            this.picSeePass.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picSeePass.Properties.Appearance.Options.UseBackColor = true;
            this.picSeePass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picSeePass.Properties.MouseHover += new System.EventHandler(this.pictureEdit1_Properties_MouseHover);
            this.picSeePass.Properties.MouseLeave += new System.EventHandler(this.pictureEdit1_Properties_MouseLeave);
            this.picSeePass.Size = new System.Drawing.Size(27, 27);
            this.picSeePass.TabIndex = 9;
            this.picSeePass.MouseHover += new System.EventHandler(this.picSeePass_MouseHover);
            // 
            // picChange2
            // 
            this.picChange2.Location = new System.Drawing.Point(253, 116);
            this.picChange2.Name = "picChange2";
            this.picChange2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picChange2.Properties.Appearance.Options.UseBackColor = true;
            this.picChange2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picChange2.Size = new System.Drawing.Size(24, 27);
            this.picChange2.TabIndex = 8;
            // 
            // picChange1
            // 
            this.picChange1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picChange1.Location = new System.Drawing.Point(251, 60);
            this.picChange1.Name = "picChange1";
            this.picChange1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picChange1.Properties.Appearance.Options.UseBackColor = true;
            this.picChange1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picChange1.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("picChange1.Properties.InitialImage")));
            this.picChange1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picChange1.Size = new System.Drawing.Size(24, 27);
            this.picChange1.TabIndex = 7;
            // 
            // btMinimize
            // 
            this.btMinimize.Location = new System.Drawing.Point(192, 0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(48, 18);
            this.btMinimize.TabIndex = 4;
            this.btMinimize.Text = "Thu nhỏ";
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click_1);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(241, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(50, 18);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbDNTaiKhoan
            // 
            this.lbDNTaiKhoan.AutoSize = true;
            this.lbDNTaiKhoan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNTaiKhoan.ForeColor = System.Drawing.Color.Yellow;
            this.lbDNTaiKhoan.Location = new System.Drawing.Point(12, 68);
            this.lbDNTaiKhoan.Name = "lbDNTaiKhoan";
            this.lbDNTaiKhoan.Size = new System.Drawing.Size(75, 19);
            this.lbDNTaiKhoan.TabIndex = 0;
            this.lbDNTaiKhoan.Text = "Tài khoản";
            // 
            // btDangNhap
            // 
            this.btDangNhap.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btDangNhap.Appearance.Options.UseFont = true;
            this.btDangNhap.Appearance.Options.UseForeColor = true;
            this.btDangNhap.Location = new System.Drawing.Point(148, 166);
            this.btDangNhap.LookAndFeel.SkinName = "Dark Side";
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(131, 39);
            this.btDangNhap.TabIndex = 3;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // lbDNQuenMatKhau
            // 
            this.lbDNQuenMatKhau.AutoSize = true;
            this.lbDNQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDNQuenMatKhau.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNQuenMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbDNQuenMatKhau.Location = new System.Drawing.Point(90, 150);
            this.lbDNQuenMatKhau.Name = "lbDNQuenMatKhau";
            this.lbDNQuenMatKhau.Size = new System.Drawing.Size(97, 15);
            this.lbDNQuenMatKhau.TabIndex = 0;
            this.lbDNQuenMatKhau.Text = "Quên mật khẩu?";
            this.lbDNQuenMatKhau.Click += new System.EventHandler(this.lbDNQuenMatKhau_Click);
            // 
            // txtDNMatKhau
            // 
            this.txtDNMatKhau.Location = new System.Drawing.Point(93, 121);
            this.txtDNMatKhau.Name = "txtDNMatKhau";
            this.txtDNMatKhau.Properties.PasswordChar = '*';
            this.txtDNMatKhau.Properties.Enter += new System.EventHandler(this.txtDNMatKhau_Properties_Enter);
            this.txtDNMatKhau.Properties.Leave += new System.EventHandler(this.txtDNMatKhau_Properties_Leave);
            this.txtDNMatKhau.Size = new System.Drawing.Size(152, 20);
            this.txtDNMatKhau.TabIndex = 2;
            this.txtDNMatKhau.Enter += new System.EventHandler(this.txtDNMatKhau_Properties_Enter);
            // 
            // lbDNMatKhau
            // 
            this.lbDNMatKhau.AutoSize = true;
            this.lbDNMatKhau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNMatKhau.ForeColor = System.Drawing.Color.Yellow;
            this.lbDNMatKhau.Location = new System.Drawing.Point(12, 124);
            this.lbDNMatKhau.Name = "lbDNMatKhau";
            this.lbDNMatKhau.Size = new System.Drawing.Size(75, 19);
            this.lbDNMatKhau.TabIndex = 0;
            this.lbDNMatKhau.Text = "Mật khẩu";
            // 
            // txtDNTaiKhoan
            // 
            this.txtDNTaiKhoan.Location = new System.Drawing.Point(93, 69);
            this.txtDNTaiKhoan.Name = "txtDNTaiKhoan";
            this.txtDNTaiKhoan.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDNTaiKhoan.Properties.Appearance.Options.UseBackColor = true;
            this.txtDNTaiKhoan.Size = new System.Drawing.Size(152, 20);
            this.txtDNTaiKhoan.TabIndex = 1;
            this.txtDNTaiKhoan.EditValueChanged += new System.EventHandler(this.txtDNTaiKhoan_EditValueChanged);
            this.txtDNTaiKhoan.Leave += new System.EventHandler(this.txtDNTaiKhoan_Leave);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 217);
            this.Controls.Add(this.grcntrDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcntrDangNhap)).EndInit();
            this.grcntrDangNhap.ResumeLayout(false);
            this.grcntrDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChange2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChange1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNTaiKhoan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDNTaiKhoan;
        private System.Windows.Forms.Label lbDNMatKhau;
        private DevExpress.XtraEditors.TextEdit txtDNTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtDNMatKhau;
        private DevExpress.XtraEditors.SimpleButton btDangNhap;
        private System.Windows.Forms.Label lbDNQuenMatKhau;
        private DevExpress.XtraEditors.GroupControl grcntrDangNhap;
        private DevExpress.XtraEditors.SimpleButton btExit;
        private DevExpress.XtraEditors.SimpleButton btMinimize;
        private DevExpress.XtraEditors.PictureEdit picChange1;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.PictureEdit picChange2;
        private DevExpress.XtraEditors.PictureEdit picSeePass;
    }
}