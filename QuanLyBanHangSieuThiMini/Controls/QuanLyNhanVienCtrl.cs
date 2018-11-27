using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangSieuThiMini.Models;
using QuanLyBanHangSieuThiMini.Objects;
using System.Data;

namespace QuanLyBanHangSieuThiMini.Controls
{
    class QuanLyNhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();

        public DataTable GetData()
        {
            return nvMod.GetData();
        }

        public DataTable SearchData(string search)
        {
            return nvMod.SearchData(search);
        }

        public bool InsertData(NhanVien nvObj)
        {
            return nvMod.InsertData(nvObj);
        }

        public bool UpdateData(NhanVien nvObj)
        {
            return nvMod.UpdateData(nvObj);
        }

        public bool CheckEmail(string email)
        {
            return nvMod.ChekEmail(email);
        }

        public bool CheckSDT(string sdt)
        {
            return nvMod.ChekSDT(sdt);
        }
    }
}
