namespace Demo
{
    partial class frmPreLoad
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreLoad));
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.progressPanel1.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.progressPanel1.Appearance.BorderColor = System.Drawing.Color.Red;
            this.progressPanel1.Appearance.Font = new System.Drawing.Font("Tahoma", 111.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.Appearance.FontSizeDelta = 5;
            this.progressPanel1.Appearance.Image = global::Demo.Properties.Resources._1212011_55035_PMlaptoplon;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Appearance.Options.UseBorderColor = true;
            this.progressPanel1.Appearance.Options.UseFont = true;
            this.progressPanel1.Appearance.Options.UseImage = true;
            this.progressPanel1.AppearanceCaption.BackColor = System.Drawing.Color.Yellow;
            this.progressPanel1.AppearanceCaption.BackColor2 = System.Drawing.Color.Blue;
            this.progressPanel1.AppearanceCaption.BorderColor = System.Drawing.Color.Red;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.AppearanceCaption.FontSizeDelta = 2;
            this.progressPanel1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.progressPanel1.AppearanceCaption.ForeColor = System.Drawing.Color.Yellow;
            this.progressPanel1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.progressPanel1.AppearanceCaption.Image = global::Demo.Properties.Resources._1212011_55035_PMlaptoplon;
            this.progressPanel1.AppearanceCaption.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Options.UseBorderColor = true;
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceCaption.Options.UseForeColor = true;
            this.progressPanel1.AppearanceCaption.Options.UseImage = true;
            this.progressPanel1.AppearanceDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressPanel1.AppearanceDescription.BackColor2 = System.Drawing.Color.Lime;
            this.progressPanel1.AppearanceDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.AppearanceDescription.FontSizeDelta = 2;
            this.progressPanel1.AppearanceDescription.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.progressPanel1.AppearanceDescription.ForeColor = System.Drawing.Color.Lime;
            this.progressPanel1.AppearanceDescription.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.progressPanel1.AppearanceDescription.Image = global::Demo.Properties.Resources.chon_laptop_hay_may_tinh_ban_2;
            this.progressPanel1.AppearanceDescription.Options.UseBackColor = true;
            this.progressPanel1.AppearanceDescription.Options.UseBorderColor = true;
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Options.UseForeColor = true;
            this.progressPanel1.AppearanceDescription.Options.UseImage = true;
            this.progressPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.progressPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progressPanel1.Caption = "Bạn hãy đợi trong giây lát";
            this.progressPanel1.CaptionToDescriptionDistance = 2;
            this.progressPanel1.Description = "Chúng tôi sẽ trở lại sau.....";
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel1.ImageHorzOffset = 10;
            this.progressPanel1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.progressPanel1.Location = new System.Drawing.Point(0, 0);
            this.progressPanel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Yellow;
            this.progressPanel1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressPanel1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.ShowToolTips = false;
            this.progressPanel1.Size = new System.Drawing.Size(330, 152);
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem1.Image")));
            toolTipItem1.LeftIndent = 6;
            toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
            toolTipTitleItem2.LeftIndent = 6;
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipTitleItem2);
            this.progressPanel1.SuperTip = superToolTip1;
            this.progressPanel1.TabIndex = 1;
            this.progressPanel1.Text = "không biết";
            this.progressPanel1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.progressPanel1.Click += new System.EventHandler(this.progressPanel1_Click);
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Black;
            this.lbTime.Location = new System.Drawing.Point(267, 84);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(40, 15);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPreLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 152);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.progressPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPreLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPreLoad";
            this.Load += new System.EventHandler(this.frmPreLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}