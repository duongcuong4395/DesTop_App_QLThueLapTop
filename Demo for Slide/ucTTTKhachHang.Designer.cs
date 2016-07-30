namespace Demo
{
    partial class ucTTTKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTTTKhachHang));
            this.dtgridKhachHang = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpctrlLoadKH = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lbThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpctrlLoadKH)).BeginInit();
            this.grpctrlLoadKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgridKhachHang
            // 
            this.dtgridKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgridKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgridKhachHang.Location = new System.Drawing.Point(5, 43);
            this.dtgridKhachHang.Name = "dtgridKhachHang";
            this.dtgridKhachHang.Size = new System.Drawing.Size(791, 328);
            this.dtgridKhachHang.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "Số điện thoại";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenKH";
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CMND";
            this.Column2.HeaderText = "CMND";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Chọn";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grpctrlLoadKH
            // 
            this.grpctrlLoadKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpctrlLoadKH.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpctrlLoadKH.CaptionImage")));
            this.grpctrlLoadKH.Controls.Add(this.dtgridKhachHang);
            this.grpctrlLoadKH.Location = new System.Drawing.Point(13, 148);
            this.grpctrlLoadKH.Name = "grpctrlLoadKH";
            this.grpctrlLoadKH.Size = new System.Drawing.Size(801, 375);
            this.grpctrlLoadKH.TabIndex = 0;
            this.grpctrlLoadKH.Text = "Load khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông báo :";
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.ForeColor = System.Drawing.Color.Orange;
            this.lbThongBao.Location = new System.Drawing.Point(106, 112);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(28, 33);
            this.lbThongBao.TabIndex = 5;
            this.lbThongBao.Text = "?";
            // 
            // ucTTTKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpctrlLoadKH);
            this.Name = "ucTTTKhachHang";
            this.Size = new System.Drawing.Size(824, 526);
            this.Load += new System.EventHandler(this.ucTTTKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpctrlLoadKH)).EndInit();
            this.grpctrlLoadKH.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridKhachHang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private DevExpress.XtraEditors.GroupControl grpctrlLoadKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThongBao;
    }
}
