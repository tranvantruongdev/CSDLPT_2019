﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_DATHANG.Report
{
    public partial class TongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public TongHopNhapXuat(DateTime start, DateTime end)
        {
            InitializeComponent();

            //nếu là login công ty thì lấy connect string của main server 
            if (Program.group == "CONGTY")
            {
                this.sp_tongHopNhapXuatTableAdapterCN1.Connection.ConnectionString = "Data Source=HEROSEEKER\\MAINSERVER;Initial Catalog=QLVT_DATHANG;Integrated Security=True";
            }
            else
            {
                //login còn lại thì lấy connect string hiện tại
                this.sp_tongHopNhapXuatTableAdapterCN1.Connection.ConnectionString = Program.connectString;
            }

            //truyền tham số vào sp
            this.sp_tongHopNhapXuatTableAdapterCN1.Fill(Server1.sp_tongHopNhapXuat, start, end);
            //label động ngày tháng
            this.lbNgayThang.Text = "TỪ " + String.Format("{0:dd/MM/yyyy}", start) + " ĐẾN " + String.Format("{0:dd/MM/yyyy}", end); ;
        }

    }
}
