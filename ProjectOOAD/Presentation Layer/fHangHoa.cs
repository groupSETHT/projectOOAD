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
    public partial class fHangHoa : DevExpress.XtraEditors.XtraForm
    {
        HangHoaBUS objHangHoaBUS = new HangHoaBUS();
        DataTable dtHangHoa;
        public fHangHoa()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtHangHoa = objHangHoaBUS.GetAllHangHoa();
                dgvDSHangHoa.DataSource = dtHangHoa;
                dgvDSHangHoa.RowHeadersVisible = false;
                dgvDSHangHoa.Columns["TenHangHoa"].HeaderText = "Tên Hàng";
                //dgvDSHangHoa.Columns["MaNhaCungCap"].Visible = false;
                //dgvDSHangHoa.Columns["SDT"].Visible = false;
                //dgvDSHangHoa.Columns["DiaChi"].Visible = false;

            }
            catch
            {
                MessageBox.Show("Kết nối dữ liệu thất bại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fHangHoa_Load(object sender, EventArgs e)
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

        private void dgvDSHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}