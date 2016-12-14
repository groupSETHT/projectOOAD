using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Presentation_Layer
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fMain()
        {
            InitializeComponent();
        }

        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                {
                    return f;
                }
            }
            return null;
        }
        private void btnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(fBanHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fBanHang f = new fBanHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(fKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fKhachHang f = new fKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBaoCaoBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(fBaoCaoBanHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fBaoCaoBanHang f = new fBaoCaoBanHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(fMuaHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fMuaHang f = new fMuaHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(fNhaCungCap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fNhaCungCap f = new fNhaCungCap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBaoCaoMuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(fBaoCaoMuaHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fBaoCaoMuaHang f = new fBaoCaoMuaHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(fHangHoa));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fHangHoa f = new fHangHoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(fTonKho));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fTonKho f = new fTonKho();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
   
}
