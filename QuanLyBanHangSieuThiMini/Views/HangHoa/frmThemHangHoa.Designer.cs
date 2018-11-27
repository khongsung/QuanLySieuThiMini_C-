namespace QuanLyBanHangSieuThiMini.Views.Hàng_hóa
{
    partial class frmThemHangHoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLoaihang = new System.Windows.Forms.ComboBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMavach = new System.Windows.Forms.TextBox();
            this.txtDovitinh = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng hóa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá bán ( nghìn VND) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn vị tính :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã vạch :";
            // 
            // cboLoaihang
            // 
            this.cboLoaihang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaihang.FormattingEnabled = true;
            this.cboLoaihang.Location = new System.Drawing.Point(126, 133);
            this.cboLoaihang.Name = "cboLoaihang";
            this.cboLoaihang.Size = new System.Drawing.Size(305, 21);
            this.cboLoaihang.TabIndex = 2;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(126, 170);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(305, 20);
            this.txtTenhang.TabIndex = 3;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(126, 210);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(305, 20);
            this.txtGia.TabIndex = 4;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtMavach
            // 
            this.txtMavach.Location = new System.Drawing.Point(126, 97);
            this.txtMavach.Name = "txtMavach";
            this.txtMavach.Size = new System.Drawing.Size(305, 20);
            this.txtMavach.TabIndex = 1;
            this.txtMavach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMavach_KeyPress);
            // 
            // txtDovitinh
            // 
            this.txtDovitinh.Location = new System.Drawing.Point(126, 291);
            this.txtDovitinh.Name = "txtDovitinh";
            this.txtDovitinh.Size = new System.Drawing.Size(305, 20);
            this.txtDovitinh.TabIndex = 6;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Enabled = false;
            this.txtSoluong.Location = new System.Drawing.Point(126, 252);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(305, 20);
            this.txtSoluong.TabIndex = 5;
            this.txtSoluong.Text = "0";
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(356, 359);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(258, 359);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thêm mặt hàng mới";
            // 
            // frmThemHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 407);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtDovitinh);
            this.Controls.Add(this.txtMavach);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.cboLoaihang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThemHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hàng hóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLoaihang;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMavach;
        private System.Windows.Forms.TextBox txtDovitinh;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
    }
}