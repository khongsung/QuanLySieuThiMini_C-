﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHangSieuThiMini.Models;
using System.Data;
using QuanLyBanHangSieuThiMini.Objects;

namespace QuanLyBanHangSieuThiMini.Controls
{
    class QuanLyLoaiHangCtrl
    {
        LoaiHangMod loaiHang = new LoaiHangMod();

        public DataTable GetData()
        {
            return loaiHang.GetData();
        }

        public DataTable SearchData(string search)
        {
            return loaiHang.SearchData(search);
        }

        public bool InsertData(LoaiHang loaihangObj)
        {
            return loaiHang.InsertData(loaihangObj);
        }

        public bool UpdateData(LoaiHang loaihangObj)
        {
            return loaiHang.UpdateData(loaihangObj);
        }
    }
}
