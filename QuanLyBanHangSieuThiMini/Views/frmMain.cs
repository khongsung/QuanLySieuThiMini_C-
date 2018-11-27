using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHangSieuThiMini.Views.ThongKe;
using QuanLyBanHangSieuThiMini.Views;
using QuanLyBanHangSieuThiMini.Views.HangHoa;
using QuanLyBanHangSieuThiMini.Views.NhaCungCap;
using QuanLyBanHangSieuThiMini.Views.NhanVien;
using QuanLyBanHangSieuThiMini.Controls;
using QuanLyBanHangSieuThiMini.Objects;

namespace QuanLyBanHangSieuThiMini.Views
{
    public partial class frmMain : Form
    {
        DangNhapCtrl dangnhap = new DangNhapCtrl();
        Objects.NhanVien nvObj = new Objects.NhanVien();

        public frmMain()
        {
            InitializeComponent();
            Init();
            //MessageBox.Show(LoginInfo.UserName);
            showForm(formBanHang, "frmBanHang");
        }

        public void Init()
        {
            DataTable dt = new DataTable();
            nvObj.Username = LoginInfo.UserName;
            dt = dangnhap.GetDataByUser(nvObj);

            foreach (DataRow row in dt.Rows)
            {
                LoginInfo.Manv = row["PK_iManhanvienID"].ToString();
                lblUserName.Text = row["sHoten"].ToString();
                LoginInfo.Quyen = Convert.ToBoolean(row["bQuyen"].ToString());
                break;
            }

            if (LoginInfo.Quyen)
            {
                grQldh.Visible = true;
                grQlnv.Visible = true;
                grNcc.Visible = true;
                grTk.Visible = true;
            }
        }

        frmHangHoa formHangHoa = new frmHangHoa();
        frmNhapHang formNhapHang = new frmNhapHang();
        frmHoaDonNhap formHoaDonNhap = new frmHoaDonNhap();
        frmHoaDonBan formHoaDonBan = new frmHoaDonBan();
        frmBanHang formBanHang = new frmBanHang();
        frmNhanVien formNhanVien = new frmNhanVien();
        frmThongKe formThongKe = new frmThongKe();
        frmHangHong formHangHong = new frmHangHong();
        frmNhaCungCap formNCC = new frmNhaCungCap();
        frmGiamGia formGia = new frmGiamGia();

        private bool CheckExistForm(string name) //kiểm tra form đã hiện chưa
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActivateChildForm(string name) // Nếu form chưa hiện thì hiện form
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        void showForm(Form form, string name)
        {
            if (!CheckExistForm(name))
            {
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                ActivateChildForm(name);
            }
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            showForm(formHangHoa, "frmHangHoa");
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            showForm(formNhapHang, "frmNhapHang");
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            showForm(formHoaDonNhap, "frmHoaDonNhap");
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            showForm(formHoaDonBan, "frmHoaDonBan");
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            showForm(formBanHang, "frmBanHang");
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            showForm(formNhanVien, "frmNhanVien");
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showForm(formThongKe, "frmThongKe");
        }

        private void btnHangHong_Click(object sender, EventArgs e)
        {
            showForm(formHangHong, "frmHangHong");
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            showForm(formNCC, "frmNhaCungCap");
        }

        private void btnGia_Click(object sender, EventArgs e)
        {
            showForm(formGia, "frmGiamGia");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        public bool isShowing = true;
        public event EventHandler Logout;

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isShowing)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?","Đăng xuất",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Logout(this, new EventArgs());
            }
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass frmChangePass = new frmChangePass();
            frmChangePass.ShowDialog();
        }
    }
}
