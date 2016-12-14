namespace Presentation_Layer
{
    partial class fKhachHang
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.gridDSNhomKhacHang = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NhomKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoaKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThemKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.gridDSKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienTichLuy = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSNhomKhacHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.gridDSNhomKhacHang);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 485);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Danh Sách Nhóm Khách Hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(10, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 31);
            this.panel1.TabIndex = 11;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(65, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(121, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            // 
            // gridDSNhomKhacHang
            // 
            this.gridDSNhomKhacHang.Location = new System.Drawing.Point(8, 23);
            this.gridDSNhomKhacHang.MainView = this.gridView2;
            this.gridDSNhomKhacHang.Name = "gridDSNhomKhacHang";
            this.gridDSNhomKhacHang.Size = new System.Drawing.Size(186, 395);
            this.gridDSNhomKhacHang.TabIndex = 1;
            this.gridDSNhomKhacHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NhomKhachHang});
            this.gridView2.GridControl = this.gridDSNhomKhacHang;
            this.gridView2.Name = "gridView2";
            // 
            // NhomKhachHang
            // 
            this.NhomKhachHang.Caption = "Nhóm Khách Hàng";
            this.NhomKhachHang.FieldName = "NhomKhachHang";
            this.NhomKhachHang.Name = "NhomKhachHang";
            this.NhomKhachHang.Visible = true;
            this.NhomKhachHang.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Controls.Add(this.gridDSKhachHang);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(200, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(871, 485);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Danh Sách Khách Hàng";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXoaKhachHang);
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Controls.Add(this.btnThemKhachHang);
            this.panelControl1.Controls.Add(this.btnSuaKhachHang);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(867, 31);
            this.panelControl1.TabIndex = 10;
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Location = new System.Drawing.Point(148, 5);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(50, 23);
            this.btnXoaKhachHang.TabIndex = 7;
            this.btnXoaKhachHang.Text = "Xóa";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(235, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 21);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Text = "Tìm Kiếm....";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Location = new System.Drawing.Point(12, 5);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(50, 23);
            this.btnThemKhachHang.TabIndex = 6;
            this.btnThemKhachHang.Text = "Thêm";
            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.Location = new System.Drawing.Point(78, 5);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(50, 23);
            this.btnSuaKhachHang.TabIndex = 8;
            this.btnSuaKhachHang.Text = "Sửa";
            // 
            // gridDSKhachHang
            // 
            this.gridDSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSKhachHang.Location = new System.Drawing.Point(2, 20);
            this.gridDSKhachHang.MainView = this.gridView1;
            this.gridDSKhachHang.Name = "gridDSKhachHang";
            this.gridDSKhachHang.Size = new System.Drawing.Size(867, 463);
            this.gridDSKhachHang.TabIndex = 0;
            this.gridDSKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenKhachHang,
            this.SDT,
            this.DiaChi,
            this.NgayDangKy,
            this.LoaiKhachHang,
            this.TienTichLuy});
            this.gridView1.GridControl = this.gridDSKhachHang;
            this.gridView1.Name = "gridView1";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Caption = "Tên Khách Hàng";
            this.TenKhachHang.FieldName = "TenKhachHang";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Visible = true;
            this.TenKhachHang.VisibleIndex = 0;
            // 
            // SDT
            // 
            this.SDT.Caption = "Số Điện Thoại";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 1;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.Caption = "Ngày Đăng Ký";
            this.NgayDangKy.FieldName = "NgayDangKy";
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.Visible = true;
            this.NgayDangKy.VisibleIndex = 3;
            // 
            // LoaiKhachHang
            // 
            this.LoaiKhachHang.Caption = "Loại Khách Hàng";
            this.LoaiKhachHang.FieldName = "LoaiKhachHang";
            this.LoaiKhachHang.Name = "LoaiKhachHang";
            this.LoaiKhachHang.Visible = true;
            this.LoaiKhachHang.VisibleIndex = 4;
            // 
            // TienTichLuy
            // 
            this.TienTichLuy.Caption = "Tiền Tích Lũy ";
            this.TienTichLuy.FieldName = "TienTichLuy";
            this.TienTichLuy.Name = "TienTichLuy";
            this.TienTichLuy.Visible = true;
            this.TienTichLuy.VisibleIndex = 5;
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 485);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "fKhachHang";
            this.Text = "Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSNhomKhacHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl gridDSNhomKhacHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn NhomKhachHang;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaKhachHang;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnThemKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnSuaKhachHang;
        private DevExpress.XtraGrid.GridControl gridDSKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn TienTichLuy;






    }
}