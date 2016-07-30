namespace Demo
{
    partial class frmTimMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimMatKhau));
            this.grctrlLayMatKhau = new DevExpress.XtraEditors.GroupControl();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.btLMKCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lbLMKEmail = new System.Windows.Forms.Label();
            this.btLayMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.txtLMKTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.lbLMK = new System.Windows.Forms.Label();
            this.lbLMKTaiKhoan = new System.Windows.Forms.Label();
            this.txtLMKEmail = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grctrlLayMatKhau)).BeginInit();
            this.grctrlLayMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLMKTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLMKEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grctrlLayMatKhau
            // 
            this.grctrlLayMatKhau.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grctrlLayMatKhau.CaptionImage")));
            this.grctrlLayMatKhau.Controls.Add(this.lbMatKhau);
            this.grctrlLayMatKhau.Controls.Add(this.btLMKCancel);
            this.grctrlLayMatKhau.Controls.Add(this.lbLMKEmail);
            this.grctrlLayMatKhau.Controls.Add(this.btLayMatKhau);
            this.grctrlLayMatKhau.Controls.Add(this.txtLMKTaiKhoan);
            this.grctrlLayMatKhau.Controls.Add(this.lbLMK);
            this.grctrlLayMatKhau.Controls.Add(this.lbLMKTaiKhoan);
            this.grctrlLayMatKhau.Controls.Add(this.txtLMKEmail);
            this.grctrlLayMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grctrlLayMatKhau.Location = new System.Drawing.Point(0, 0);
            this.grctrlLayMatKhau.Name = "grctrlLayMatKhau";
            this.grctrlLayMatKhau.Size = new System.Drawing.Size(187, 254);
            this.grctrlLayMatKhau.TabIndex = 3;
            this.grctrlLayMatKhau.Text = "Lấy mật khẩu";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(115, 169);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(0, 19);
            this.lbMatKhau.TabIndex = 5;
            // 
            // btLMKCancel
            // 
            this.btLMKCancel.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLMKCancel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btLMKCancel.Appearance.Options.UseFont = true;
            this.btLMKCancel.Appearance.Options.UseForeColor = true;
            this.btLMKCancel.Location = new System.Drawing.Point(103, 209);
            this.btLMKCancel.Name = "btLMKCancel";
            this.btLMKCancel.Size = new System.Drawing.Size(60, 25);
            this.btLMKCancel.TabIndex = 4;
            this.btLMKCancel.Text = "Hủy";
            this.btLMKCancel.Click += new System.EventHandler(this.btLMKCancel_Click);
            // 
            // lbLMKEmail
            // 
            this.lbLMKEmail.AutoSize = true;
            this.lbLMKEmail.Location = new System.Drawing.Point(16, 113);
            this.lbLMKEmail.Name = "lbLMKEmail";
            this.lbLMKEmail.Size = new System.Drawing.Size(31, 13);
            this.lbLMKEmail.TabIndex = 0;
            this.lbLMKEmail.Text = "Email";
            // 
            // btLayMatKhau
            // 
            this.btLayMatKhau.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLayMatKhau.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btLayMatKhau.Appearance.Options.UseFont = true;
            this.btLayMatKhau.Appearance.Options.UseForeColor = true;
            this.btLayMatKhau.Location = new System.Drawing.Point(10, 209);
            this.btLayMatKhau.Name = "btLayMatKhau";
            this.btLayMatKhau.Size = new System.Drawing.Size(86, 25);
            this.btLayMatKhau.TabIndex = 3;
            this.btLayMatKhau.Text = "Lấy mật khẩu";
            this.btLayMatKhau.Click += new System.EventHandler(this.btLayMatKhau_Click);
            // 
            // txtLMKTaiKhoan
            // 
            this.txtLMKTaiKhoan.Location = new System.Drawing.Point(16, 83);
            this.txtLMKTaiKhoan.Name = "txtLMKTaiKhoan";
            this.txtLMKTaiKhoan.Size = new System.Drawing.Size(126, 20);
            this.txtLMKTaiKhoan.TabIndex = 1;
            // 
            // lbLMK
            // 
            this.lbLMK.AutoSize = true;
            this.lbLMK.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbLMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbLMK.Location = new System.Drawing.Point(13, 171);
            this.lbLMK.Name = "lbLMK";
            this.lbLMK.Size = new System.Drawing.Size(0, 13);
            this.lbLMK.TabIndex = 3;
            // 
            // lbLMKTaiKhoan
            // 
            this.lbLMKTaiKhoan.AutoSize = true;
            this.lbLMKTaiKhoan.Location = new System.Drawing.Point(16, 64);
            this.lbLMKTaiKhoan.Name = "lbLMKTaiKhoan";
            this.lbLMKTaiKhoan.Size = new System.Drawing.Size(53, 13);
            this.lbLMKTaiKhoan.TabIndex = 0;
            this.lbLMKTaiKhoan.Text = "Tài khoản";
            // 
            // txtLMKEmail
            // 
            this.txtLMKEmail.Location = new System.Drawing.Point(16, 132);
            this.txtLMKEmail.Name = "txtLMKEmail";
            this.txtLMKEmail.Size = new System.Drawing.Size(126, 20);
            this.txtLMKEmail.TabIndex = 2;
            // 
            // frmTimMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 254);
            this.Controls.Add(this.grctrlLayMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimMatKhau";
            this.Load += new System.EventHandler(this.frmTimMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grctrlLayMatKhau)).EndInit();
            this.grctrlLayMatKhau.ResumeLayout(false);
            this.grctrlLayMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLMKTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLMKEmail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grctrlLayMatKhau;
        private DevExpress.XtraEditors.SimpleButton btLMKCancel;
        private System.Windows.Forms.Label lbLMKEmail;
        private DevExpress.XtraEditors.SimpleButton btLayMatKhau;
        private DevExpress.XtraEditors.TextEdit txtLMKTaiKhoan;
        private System.Windows.Forms.Label lbLMK;
        private System.Windows.Forms.Label lbLMKTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtLMKEmail;
        private System.Windows.Forms.Label lbMatKhau;
    }
}