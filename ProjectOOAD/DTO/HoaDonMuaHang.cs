﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoaDonMuaHang
    {
        public string maHDMH
        {
            get;
            set;
        }

        public string ngayMua
        {
            get;
            set;
        }

        public string maNhaCungCap
        {
            get;
            set;
        }

        public string maNhanVien
        {
            get;
            set;
        }

        public double tongTien
        {
            get;
            set;
        }
        public HoaDonMuaHang()
        {

        }

        public HoaDonMuaHang(string _maHDMH, string _ngayMua, string _maNhanVien, string _maNhaCungCap, double _tongTien)
        {
            this.maHDMH = _maHDMH;
            this.ngayMua = _ngayMua;
            this.maNhanVien = _maNhanVien;
            this.maNhaCungCap = _maNhaCungCap;
            this.tongTien = _tongTien;
        }
    }
}

