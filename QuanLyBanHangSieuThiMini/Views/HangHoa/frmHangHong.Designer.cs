namespace QuanLyBanHangSieuThiMini.Views.HangHoa
{
    partial class frmHangHong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHanghong = new System.Windows.Forms.DataGridView();
            this.sMavach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNgaythang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.grHanghong = new System.Windows.Forms.GroupBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.nmSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtMavach = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimHangHong = new System.Windows.Forms.TextBox();
            this.btnTimHangHong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bntHuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghong)).BeginInit();
            this.grHanghong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHanghong);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng hỏng / lỗi";
            // 
            // dgvHanghong
            // 
            this.dgvHanghong.AllowUserToAddRows = false;
            this.dgvHanghong.AllowUserToDeleteRows = false;
            this.dgvHanghong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHanghong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHanghong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanghong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMavach,
            this.sTenhang,
            this.sSoluong,
            this.sMota,
            this.sNgaythang});
            this.dgvHanghong.Location = new System.Drawing.Point(7, 30);
            this.dgvHanghong.Name = "dgvHanghong";
            this.dgvHanghong.ReadOnly = true;
            this.dgvHanghong.Size = new System.Drawing.Size(775, 444);
            this.dgvHanghong.TabIndex = 0;
            // 
            // sMavach
            // 
            this.sMavach.DataPropertyName = "sMavach";
            this.sMavach.HeaderText = "Mã  vạch";
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
            // sSoluong
            // 
            this.sSoluong.DataPropertyName = "iSoluong";
            this.sSoluong.HeaderText = "Số lượng hỏng";
            this.sSoluong.Name = "sSoluong";
            this.sSoluong.ReadOnly = true;
            // 
            // sMota
            // 
            this.sMota.DataPropertyName = "sMota";
            this.sMota.HeaderText = "Mô tả";
            this.sMota.Name = "sMota";
            this.sMota.ReadOnly = true;
            // 
            // sNgaythang
            // 
            this.sNgaythang.DataPropertyName = "dNgaythang";
            this.sNgaythang.HeaderText = "Ngày lưu";
            this.sNgaythang.Name = "sNgaythang";
            this.sNgaythang.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(727, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 31);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grHanghong
            // 
            this.grHanghong.Controls.Add(this.txtMota);
            this.grHanghong.Controls.Add(this.nmSoluong);
            this.grHanghong.Controls.Add(this.txtMavach);
            this.grHanghong.Controls.Add(this.txtTenhang);
            this.grHanghong.Controls.Add(this.btnLuu);
            this.grHanghong.Controls.Add(this.btnHuy);
            this.grHanghong.Controls.Add(this.label4);
            this.grHanghong.Controls.Add(this.label3);
            this.grHanghong.Controls.Add(this.label2);
            this.grHanghong.Controls.Add(this.label1);
            this.grHanghong.Enabled = false;
            this.grHanghong.Location = new System.Drawing.Point(807, 67);
            this.grHanghong.Name = "grHanghong";
            this.grHanghong.Size = new System.Drawing.Size(510, 462);
            this.grHanghong.TabIndex = 4;
            this.grHanghong.TabStop = false;
            this.grHanghong.Text = "Quản lý hàng hỏng / lỗi";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(160, 172);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(309, 122);
            this.txtMota.TabIndex = 5;
            // 
            // nmSoluong
            // 
            this.nmSoluong.Location = new System.Drawing.Point(160, 124);
            this.nmSoluong.Name = "nmSoluong";
            this.nmSoluong.Size = new System.Drawing.Size(309, 20);
            this.nmSoluong.TabIndex = 4;
            // 
            // txtMavach
            // 
            this.txtMavach.AcceptsTab = true;
            this.txtMavach.Location = new System.Drawing.Point(160, 37);
            this.txtMavach.Name = "txtMavach";
            this.txtMavach.Size = new System.Drawing.Size(309, 20);
            this.txtMavach.TabIndex = 2;
            this.txtMavach.Leave += new System.EventHandler(this.txtMavach_Leave);
            // 
            // txtTenhang
            // 
            this.txtTenhang.Enabled = false;
            this.txtTenhang.Location = new System.Drawing.Point(160, 76);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(309, 20);
            this.txtTenhang.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(313, 314);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(394, 314);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng hỏng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vạch :";
            // 
            // txtTimHangHong
            // 
            this.txtTimHangHong.AcceptsTab = true;
            this.txtTimHangHong.Location = new System.Drawing.Point(130, 18);
            this.txtTimHangHong.Name = "txtTimHangHong";
            this.txtTimHangHong.Size = new System.Drawing.Size(309, 20);
            this.txtTimHangHong.TabIndex = 2;
            this.txtTimHangHong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimHangHong_KeyDown);
            // 
            // btnTimHangHong
            // 
            this.btnTimHangHong.Location = new System.Drawing.Point(455, 17);
            this.btnTimHangHong.Name = "btnTimHangHong";
            this.btnTimHangHong.Size = new System.Drawing.Size(75, 23);
            this.btnTimHangHong.TabIndex = 3;
            this.btnTimHangHong.Text = "Tìm";
            this.btnTimHangHong.UseVisualStyleBackColor = true;
            this.btnTimHangHong.Click += new System.EventHandler(this.btnTimHangHong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm hàng hỏng :";
            // 
            // bntHuy
            // 
            this.bntHuy.Location = new System.Drawing.Point(536, 17);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(75, 23);
            this.bntHuy.TabIndex = 3;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // frmHangHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.grHanghong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimHangHong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.btnTimHangHong);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmHangHong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hỏng / lỗi";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghong)).EndInit();
            this.grHanghong.ResumeLayout(false);
            this.grHanghong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHanghong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grHanghong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmSoluong;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtMavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMavach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNgaythang;
        private System.Windows.Forms.TextBox txtTimHangHong;
        private System.Windows.Forms.Button btnTimHangHong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntHuy;
    }
}