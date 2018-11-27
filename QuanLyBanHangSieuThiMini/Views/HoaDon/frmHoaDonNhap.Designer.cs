namespace QuanLyBanHangSieuThiMini.Views
{
    partial class frmHoaDonNhap
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
            this.btnTimKiemAll = new System.Windows.Forms.Button();
            this.tìmKiếmTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTheoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboTenNv = new System.Windows.Forms.ComboBox();
            this.btnTimKiemTen = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiemNgay = new System.Windows.Forms.Button();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tìmKiếmTheoTênNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXemAll = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.sMahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNgaythang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietNhap = new System.Windows.Forms.DataGridView();
            this.sMavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDonvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiemAll
            // 
            this.btnTimKiemAll.Location = new System.Drawing.Point(712, 41);
            this.btnTimKiemAll.Name = "btnTimKiemAll";
            this.btnTimKiemAll.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemAll.TabIndex = 21;
            this.btnTimKiemAll.Text = "Tìm kiếm";
            this.btnTimKiemAll.UseVisualStyleBackColor = true;
            this.btnTimKiemAll.Visible = false;
            this.btnTimKiemAll.Click += new System.EventHandler(this.btnTimKiemAll_Click);
            // 
            // tìmKiếmTheoNgàyToolStripMenuItem
            // 
            this.tìmKiếmTheoNgàyToolStripMenuItem.Name = "tìmKiếmTheoNgàyToolStripMenuItem";
            this.tìmKiếmTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.tìmKiếmTheoNgàyToolStripMenuItem.Text = "Tìm kiếm theo ngày";
            this.tìmKiếmTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTheoNgàyToolStripMenuItem_Click);
            // 
            // tìmKiếmTheoTênToolStripMenuItem
            // 
            this.tìmKiếmTheoTênToolStripMenuItem.Name = "tìmKiếmTheoTênToolStripMenuItem";
            this.tìmKiếmTheoTênToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.tìmKiếmTheoTênToolStripMenuItem.Text = "Tìm kiếm theo tên";
            this.tìmKiếmTheoTênToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTheoTênToolStripMenuItem_Click);
            // 
            // cboTenNv
            // 
            this.cboTenNv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenNv.FormattingEnabled = true;
            this.cboTenNv.Location = new System.Drawing.Point(85, 41);
            this.cboTenNv.Name = "cboTenNv";
            this.cboTenNv.Size = new System.Drawing.Size(176, 21);
            this.cboTenNv.TabIndex = 11;
            // 
            // btnTimKiemTen
            // 
            this.btnTimKiemTen.Location = new System.Drawing.Point(267, 40);
            this.btnTimKiemTen.Name = "btnTimKiemTen";
            this.btnTimKiemTen.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemTen.TabIndex = 12;
            this.btnTimKiemTen.Text = "Tìm kiếm";
            this.btnTimKiemTen.UseVisualStyleBackColor = true;
            this.btnTimKiemTen.Click += new System.EventHandler(this.btnTimKiemTen_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(51, 44);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(32, 13);
            this.lblTen.TabIndex = 17;
            this.lblTen.Text = "Tên :";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(532, 42);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(103, 20);
            this.dtNgayKetThuc.TabIndex = 16;
            this.dtNgayKetThuc.Visible = false;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "";
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(356, 42);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtNgayBatDau.Size = new System.Drawing.Size(103, 20);
            this.dtNgayBatDau.TabIndex = 14;
            this.dtNgayBatDau.Visible = false;
            // 
            // btnTimKiemNgay
            // 
            this.btnTimKiemNgay.Location = new System.Drawing.Point(641, 41);
            this.btnTimKiemNgay.Name = "btnTimKiemNgay";
            this.btnTimKiemNgay.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemNgay.TabIndex = 18;
            this.btnTimKiemNgay.Text = "Tìm kiếm";
            this.btnTimKiemNgay.UseVisualStyleBackColor = true;
            this.btnTimKiemNgay.Visible = false;
            this.btnTimKiemNgay.Click += new System.EventHandler(this.btnTimKiemNgay_Click);
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(471, 45);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(59, 13);
            this.lblDen.TabIndex = 19;
            this.lblDen.Text = "Đến ngày :";
            this.lblDen.Visible = false;
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(300, 44);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(52, 13);
            this.lblTu.TabIndex = 20;
            this.lblTu.Text = "Từ ngày :";
            this.lblTu.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmTheoTênToolStripMenuItem,
            this.tìmKiếmTheoNgàyToolStripMenuItem,
            this.tìmKiếmTheoTênNgàyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1329, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tìmKiếmTheoTênNgàyToolStripMenuItem
            // 
            this.tìmKiếmTheoTênNgàyToolStripMenuItem.Name = "tìmKiếmTheoTênNgàyToolStripMenuItem";
            this.tìmKiếmTheoTênNgàyToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.tìmKiếmTheoTênNgàyToolStripMenuItem.Text = "Tìm kiếm theo tên, ngày";
            this.tìmKiếmTheoTênNgàyToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTheoTênNgàyToolStripMenuItem_Click);
            // 
            // btnXemAll
            // 
            this.btnXemAll.Location = new System.Drawing.Point(262, 16);
            this.btnXemAll.Name = "btnXemAll";
            this.btnXemAll.Size = new System.Drawing.Size(113, 31);
            this.btnXemAll.TabIndex = 7;
            this.btnXemAll.Text = "Xem Tất Cả";
            this.btnXemAll.UseVisualStyleBackColor = true;
            this.btnXemAll.Click += new System.EventHandler(this.btnXemAll_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(382, 16);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(113, 31);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "In Hóa Đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMahoadon,
            this.sTenncc,
            this.sNhanvien,
            this.sNgaythang,
            this.sTongtien});
            this.dgvHoaDon.Location = new System.Drawing.Point(6, 53);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(489, 399);
            this.dgvHoaDon.TabIndex = 2;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // sMahoadon
            // 
            this.sMahoadon.DataPropertyName = "PK_iMahoadonnhapID";
            this.sMahoadon.FillWeight = 85.95601F;
            this.sMahoadon.HeaderText = "Mã hóa đơn";
            this.sMahoadon.Name = "sMahoadon";
            this.sMahoadon.ReadOnly = true;
            // 
            // sTenncc
            // 
            this.sTenncc.DataPropertyName = "sTennhacungcap";
            this.sTenncc.FillWeight = 85.95601F;
            this.sTenncc.HeaderText = "Tên Ncc";
            this.sTenncc.Name = "sTenncc";
            this.sTenncc.ReadOnly = true;
            // 
            // sNhanvien
            // 
            this.sNhanvien.DataPropertyName = "sHoten";
            this.sNhanvien.FillWeight = 142.132F;
            this.sNhanvien.HeaderText = "Nhân viên";
            this.sNhanvien.Name = "sNhanvien";
            this.sNhanvien.ReadOnly = true;
            this.sNhanvien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sNgaythang
            // 
            this.sNgaythang.DataPropertyName = "dNgaythang";
            this.sNgaythang.FillWeight = 85.95601F;
            this.sNgaythang.HeaderText = "Ngày lập";
            this.sNgaythang.Name = "sNgaythang";
            this.sNgaythang.ReadOnly = true;
            // 
            // sTongtien
            // 
            this.sTongtien.DataPropertyName = "sThanhtien";
            this.sTongtien.HeaderText = "Tổng Tiền";
            this.sTongtien.Name = "sTongtien";
            this.sTongtien.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemAll);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 458);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgvChiTietNhap
            // 
            this.dgvChiTietNhap.AllowUserToAddRows = false;
            this.dgvChiTietNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChiTietNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMavach,
            this.sTenhang,
            this.sGianhap,
            this.sSoluong,
            this.sDonvitinh,
            this.sThanhtien});
            this.dgvChiTietNhap.Location = new System.Drawing.Point(6, 19);
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.ReadOnly = true;
            this.dgvChiTietNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietNhap.Size = new System.Drawing.Size(773, 433);
            this.dgvChiTietNhap.TabIndex = 3;
            // 
            // sMavach
            // 
            this.sMavach.DataPropertyName = "sMavach";
            this.sMavach.HeaderText = "Mã vạch";
            this.sMavach.Name = "sMavach";
            this.sMavach.ReadOnly = true;
            // 
            // sTenhang
            // 
            this.sTenhang.DataPropertyName = "sTenhang";
            this.sTenhang.HeaderText = "Tên hàng";
            this.sTenhang.Name = "sTenhang";
            this.sTenhang.ReadOnly = true;
            // 
            // sGianhap
            // 
            this.sGianhap.DataPropertyName = "dGianhap";
            this.sGianhap.HeaderText = "Giá";
            this.sGianhap.Name = "sGianhap";
            this.sGianhap.ReadOnly = true;
            // 
            // sSoluong
            // 
            this.sSoluong.DataPropertyName = "iSoluong";
            this.sSoluong.HeaderText = "Số lượng nhập";
            this.sSoluong.Name = "sSoluong";
            this.sSoluong.ReadOnly = true;
            // 
            // sDonvitinh
            // 
            this.sDonvitinh.DataPropertyName = "sDonvitinh";
            this.sDonvitinh.HeaderText = "Đơn vị tính";
            this.sDonvitinh.Name = "sDonvitinh";
            this.sDonvitinh.ReadOnly = true;
            // 
            // sThanhtien
            // 
            this.sThanhtien.DataPropertyName = "sThanhtien";
            this.sThanhtien.HeaderText = "Thành tiền (VND)";
            this.sThanhtien.Name = "sThanhtien";
            this.sThanhtien.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietNhap);
            this.groupBox2.Location = new System.Drawing.Point(532, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 458);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.btnTimKiemAll);
            this.Controls.Add(this.cboTenNv);
            this.Controls.Add(this.btnTimKiemTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.dtNgayKetThuc);
            this.Controls.Add(this.dtNgayBatDau);
            this.Controls.Add(this.btnTimKiemNgay);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn nhập hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemAll;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoTênToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboTenNv;
        private System.Windows.Forms.Button btnTimKiemTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.Button btnTimKiemNgay;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoTênNgàyToolStripMenuItem;
        private System.Windows.Forms.Button btnXemAll;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChiTietNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgaythang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDonvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sThanhtien;

    }
}