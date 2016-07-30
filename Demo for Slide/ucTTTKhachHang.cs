using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using BUSLayer;

using DevExpress.XtraEditors;

namespace Demo
{
    public partial class ucTTTKhachHang : UserControl
    {
        public ucTTTKhachHang()
        {
            InitializeComponent();
        }

        QLSPDataContext qlsp = new QLSPDataContext();
        KhachHangBUS khBUS = new KhachHangBUS();

        private void ucTTTKhachHang_Load(object sender, EventArgs e)
        {
            loadKhachHang();
        }


        //Hàm load danh sách khách Hàng
        public void loadKhachHang()
        {
            SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=QLSPCN;Integrated Security=True");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from KHACHHANG", connect);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            dtgridKhachHang.Rows.Clear();

            foreach (DataRow item in table.Rows)
            {
                int n = dtgridKhachHang.Rows.Add();
                dtgridKhachHang.Rows[n].Cells[0].Value = false;
                dtgridKhachHang.Rows[n].Cells[1].Value = item["TenKH"].ToString();
                dtgridKhachHang.Rows[n].Cells[2].Value = item["DiaChi"].ToString();
                dtgridKhachHang.Rows[n].Cells[3].Value = item["SDT"].ToString();
            }
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btTimKH_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
