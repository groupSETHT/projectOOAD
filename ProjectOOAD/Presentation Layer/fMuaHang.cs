using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using BUS;
using DTO;

namespace Presentation_Layer
{
    public partial class fMuaHang : DevExpress.XtraEditors.XtraForm
    {
        NhaCungCapBUS objNhaCungCapBUS = new NhaCungCapBUS();
        DataTable dtNhaCungCap;
        public fMuaHang()
        {
            InitializeComponent();
        }

        private void panelControl9_Paint(object sender, PaintEventArgs e)
        {
            
        }



        public void LoadData()
        {
            try
            {
                dtNhaCungCap = objNhaCungCapBUS.GetAllNhaCungCap();
                dataGridView1.DataSource = dtNhaCungCap;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns["TenNhaCungCap"].HeaderText = "Nhà Cung Cấp";
                dataGridView1.Columns["MaNhaCungCap"].Visible = false;
                dataGridView1.Columns["SDT"].Visible = false;
                dataGridView1.Columns["DiaChi"].Visible = false;
                
            }
            catch
            {
                MessageBox.Show("Kết nối dữ liệu thất bại!!!","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fMuaHang_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("Kết nối dữ liệu thất bại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}