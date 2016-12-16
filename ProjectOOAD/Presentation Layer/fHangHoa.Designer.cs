namespace Presentation_Layer
{
    partial class fHangHoa
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDSHangHoa = new System.Windows.Forms.DataGridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoaKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThemKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDSNhomHangHoa = new System.Windows.Forms.DataGridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhomHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.72588F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.4926594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.78146F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImagePadding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.groupControl2.Controls.Add(this.dgvDSHangHoa);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(207, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(858, 513);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Danh Sách Hàng Hóa";
            // 
            // dgvDSHangHoa
            // 
            this.dgvDSHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHangHoa.Location = new System.Drawing.Point(2, 51);
            this.dgvDSHangHoa.Name = "dgvDSHangHoa";
            this.dgvDSHangHoa.Size = new System.Drawing.Size(854, 460);
            this.dgvDSHangHoa.TabIndex = 12;
            this.dgvDSHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHangHoa_CellContentClick);
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
            this.panelControl1.Size = new System.Drawing.Size(854, 31);
            this.panelControl1.TabIndex = 10;
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Location = new System.Drawing.Point(124, 5);
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
            this.btnSuaKhachHang.Location = new System.Drawing.Point(68, 5);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(50, 23);
            this.btnSuaKhachHang.TabIndex = 8;
            this.btnSuaKhachHang.Text = "Sửa";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButton4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(199, 519);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(3, 480);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 36);
            this.simpleButton4.TabIndex = 13;
            this.simpleButton4.Text = "Báo Giá";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImagePadding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.groupControl1.Controls.Add(this.dgvDSNhomHangHoa);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(193, 471);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Danh Sách Nhóm Hàng Hóa";
            // 
            // dgvDSNhomHangHoa
            // 
            this.dgvDSNhomHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhomHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNhomHangHoa.Location = new System.Drawing.Point(2, 51);
            this.dgvDSNhomHangHoa.Name = "dgvDSNhomHangHoa";
            this.dgvDSNhomHangHoa.Size = new System.Drawing.Size(189, 418);
            this.dgvDSNhomHangHoa.TabIndex = 15;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.textBox1);
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.simpleButton3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 20);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(189, 31);
            this.panelControl2.TabIndex = 14;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(124, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(50, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Xóa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 21);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Tìm Kiếm....";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Thêm";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(68, 5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(50, 23);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "Sửa";
            // 
            // fHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fHangHoa";
            this.Text = "fHangHoa";
            this.Load += new System.EventHandler(this.fHangHoa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhomHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaKhachHang;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnThemKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnSuaKhachHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.DataGridView dgvDSHangHoa;
        private System.Windows.Forms.DataGridView dgvDSNhomHangHoa;







    }
}