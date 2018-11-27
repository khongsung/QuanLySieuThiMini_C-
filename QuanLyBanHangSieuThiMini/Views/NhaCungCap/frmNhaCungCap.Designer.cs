namespace QuanLyBanHangSieuThiMini.Views.NhaCungCap
{
    partial class frmNhaCungCap
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
            this.dgvNhaCC = new System.Windows.Forms.DataGridView();
            this.sMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimNcc = new System.Windows.Forms.Button();
            this.txtTimNcc = new System.Windows.Forms.TextBox();
            this.grForm = new System.Windows.Forms.GroupBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuyTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            this.grForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNhaCC);
            this.groupBox1.Location = new System.Drawing.Point(15, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhà cung cấp";
            // 
            // dgvNhaCC
            // 
            this.dgvNhaCC.AllowUserToAddRows = false;
            this.dgvNhaCC.AllowUserToDeleteRows = false;
            this.dgvNhaCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMa,
            this.sTen,
            this.sSdt,
            this.sDiachi});
            this.dgvNhaCC.Location = new System.Drawing.Point(6, 19);
            this.dgvNhaCC.Name = "dgvNhaCC";
            this.dgvNhaCC.ReadOnly = true;
            this.dgvNhaCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCC.Size = new System.Drawing.Size(716, 418);
            this.dgvNhaCC.TabIndex = 1;
            // 
            // sMa
            // 
            this.sMa.DataPropertyName = "PK_iManhacungcapID";
            this.sMa.HeaderText = "Mã nhà cung cấp";
            this.sMa.Name = "sMa";
            this.sMa.ReadOnly = true;
            // 
            // sTen
            // 
            this.sTen.DataPropertyName = "sTennhacungcap";
            this.sTen.HeaderText = "Tên nhà cung cấp";
            this.sTen.Name = "sTen";
            this.sTen.ReadOnly = true;
            // 
            // sSdt
            // 
            this.sSdt.DataPropertyName = "sSDT";
            this.sSdt.HeaderText = "Số điện thoại";
            this.sSdt.Name = "sSdt";
            this.sSdt.ReadOnly = true;
            // 
            // sDiachi
            // 
            this.sDiachi.DataPropertyName = "sDiachi";
            this.sDiachi.HeaderText = "Địa chỉ";
            this.sDiachi.Name = "sDiachi";
            this.sDiachi.ReadOnly = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(835, 16);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 33);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(685, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 33);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimNcc
            // 
            this.btnTimNcc.Location = new System.Drawing.Point(425, 22);
            this.btnTimNcc.Name = "btnTimNcc";
            this.btnTimNcc.Size = new System.Drawing.Size(75, 23);
            this.btnTimNcc.TabIndex = 9;
            this.btnTimNcc.Text = "Tìm";
            this.btnTimNcc.UseVisualStyleBackColor = true;
            this.btnTimNcc.Click += new System.EventHandler(this.btnTimNcc_Click);
            // 
            // txtTimNcc
            // 
            this.txtTimNcc.Location = new System.Drawing.Point(142, 24);
            this.txtTimNcc.Name = "txtTimNcc";
            this.txtTimNcc.Size = new System.Drawing.Size(263, 20);
            this.txtTimNcc.TabIndex = 8;
            this.txtTimNcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimNcc_KeyDown);
            // 
            // grForm
            // 
            this.grForm.Controls.Add(this.txtSdt);
            this.grForm.Controls.Add(this.txtDiachi);
            this.grForm.Controls.Add(this.txtTen);
            this.grForm.Controls.Add(this.btnLuu);
            this.grForm.Controls.Add(this.btnHuy);
            this.grForm.Controls.Add(this.label4);
            this.grForm.Controls.Add(this.label3);
            this.grForm.Controls.Add(this.label2);
            this.grForm.Controls.Add(this.label1);
            this.grForm.Enabled = false;
            this.grForm.Location = new System.Drawing.Point(750, 81);
            this.grForm.Name = "grForm";
            this.grForm.Size = new System.Drawing.Size(559, 448);
            this.grForm.TabIndex = 9;
            this.grForm.TabStop = false;
            this.grForm.Text = "Quản lý nhà cung cấp";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(183, 120);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(309, 20);
            this.txtSdt.TabIndex = 21;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(183, 169);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(309, 122);
            this.txtDiachi.TabIndex = 19;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(183, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(309, 20);
            this.txtTen.TabIndex = 17;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(336, 311);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(417, 311);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Địa chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số điện thoại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên nhà cung cấp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tìm kiếm nhà cung cấp :";
            // 
            // btnHuyTim
            // 
            this.btnHuyTim.Location = new System.Drawing.Point(506, 22);
            this.btnHuyTim.Name = "btnHuyTim";
            this.btnHuyTim.Size = new System.Drawing.Size(75, 23);
            this.btnHuyTim.TabIndex = 10;
            this.btnHuyTim.Text = "Hủy";
            this.btnHuyTim.UseVisualStyleBackColor = true;
            this.btnHuyTim.Click += new System.EventHandler(this.btnHuyTim_Click);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 541);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grForm);
            this.Controls.Add(this.txtTimNcc);
            this.Controls.Add(this.btnHuyTim);
            this.Controls.Add(this.btnTimNcc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            this.grForm.ResumeLayout(false);
            this.grForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhaCC;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimNcc;
        private System.Windows.Forms.TextBox txtTimNcc;
        private System.Windows.Forms.GroupBox grForm;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiachi;
        private System.Windows.Forms.Button btnHuyTim;
    }
}