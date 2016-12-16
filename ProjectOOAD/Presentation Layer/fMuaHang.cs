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

using DTO;
using BUS;

namespace Presentation_Layer
{
        public partial class fMuaHang : DevExpress.XtraEditors.XtraForm
        {
            NhaCungCapBUS objNhaCungCapBUS = new NhaCungCapBUS();
            HangHoaBUS objHangHoaBUS = new HangHoaBUS();
            DataTable dtNhaCungCap;
            DataTable dtHangHoa;
            public fMuaHang()
            {
                InitializeComponent();
            }



            public void LoadData()
            {
                try
                {
                    dtNhaCungCap = objNhaCungCapBUS.GetAllNhaCungCap();
                    dgvDSNhaCungCap.DataSource = dtNhaCungCap;
                    dgvDSNhaCungCap.RowHeadersVisible = false;
                    dgvDSNhaCungCap.Columns["TenNhaCungCap"].HeaderText = "Nhà Cung Cấp";
                    dgvDSNhaCungCap.Columns["MaNhaCungCap"].Visible = false;
                    dgvDSNhaCungCap.Columns["SDT"].Visible = false;
                    dgvDSNhaCungCap.Columns["DiaChi"].Visible = false;

                }
                catch
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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