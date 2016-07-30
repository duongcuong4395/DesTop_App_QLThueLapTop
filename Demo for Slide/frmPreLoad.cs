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

namespace Demo
{
    public partial class frmPreLoad : DevExpress.XtraEditors.XtraForm
    {
        public int thoigianhienthi = 5;
        public frmPreLoad()
        {
            
            InitializeComponent();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            // Giảm thời gian đợi sau mỗi giây
            if (thoigianhienthi <= 5 && thoigianhienthi > 0)
            {
                thoigianhienthi = thoigianhienthi - 1;
                lbTime.Text = thoigianhienthi.ToString() + " Giây";
            }

            // Thời gian == 0 thì đóng form PreLoad
            if (thoigianhienthi == 0)
            {
                this.Close();
            }
        }

        private void frmPreLoad_Load(object sender, EventArgs e)
        {

        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
