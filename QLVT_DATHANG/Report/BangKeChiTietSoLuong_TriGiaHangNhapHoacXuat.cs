﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANG.Report
{
    public partial class BangKeChiTietSoLuong_TriGiaHangNhapHoacXuat : DevExpress.XtraReports.UI.XtraReport
    {
        //tham số cho sp để gán vào các label động
        public static bool congty, phieuNhap;
        public static DateTime startDate, endDate;
        public static string lableTitle;

        public BangKeChiTietSoLuong_TriGiaHangNhapHoacXuat()
        {
            InitializeComponent();

            lbTitle.Text = lableTitle;

            //gán lại connect string để đề phòng trường hợp đăng nhập lại or đổi chi nhánh
            this.sp_keKhaiChiTietTongHopTableAdapter.Connection.ConnectionString = Program.connectString;
            this.sp_keKhaiChiTietTongHopTableAdapter.Fill(KeKhaiCN1.sp_keKhaiChiTietTongHop, congty, phieuNhap, startDate, endDate);
        }

    }
}
