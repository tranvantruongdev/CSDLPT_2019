﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLVT_DATHANG.SubForm
{
    public partial class ThemVT : DevExpress.XtraEditors.XtraForm
    {
        public ThemVT()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.productForm.Visible = true;
        }

        private void textEditThemMaVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//nút enter
            {
                if (!(Program.isEmpty(this.textEditThemMaVT)))
                {
                    this.textEditThemMaVT.Text = Program.RemoveSpecialCharacters(this.textEditThemMaVT.Text);
                    this.textEditThemTenVT.Focus();
                }
            }
        }

        private void textEditThemTenVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//nút enter
            {
                if (!(Program.isEmpty(this.textEditThemTenVT)))
                {
                    this.textEditThemTenVT.Text = Program.RemoveSpecialCharacters(this.textEditThemTenVT.Text);
                    this.textEditThemDVT.Focus();
                }
            }
        }

        private void textEditThemDVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//nút enter
            {
                if (!(Program.isEmpty(this.textEditThemDVT)))
                {
                    this.textEditThemDVT.Text = Program.RemoveSpecialCharacters(this.textEditThemDVT.Text);
                    this.numericSoLuongTon.Focus();
                }
            }
        }

        private void numericSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnSave.PerformClick();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mavt = this.textEditThemMaVT.Text;
            string tenvt = this.textEditThemTenVT.Text;
            string dvt = this.textEditThemDVT.Text;
            decimal slt = this.numericSoLuongTon.Value;

            //kiem tra xem trong db co ma vat tu nay hay chua
            SqlCommand kiemtratontai = new SqlCommand("sp_KiemTraVatTuTonTai", Program.connect);
            kiemtratontai.CommandType = CommandType.StoredProcedure;
            kiemtratontai.Parameters.Add("@MAVT", SqlDbType.NChar).Value = mavt;
            kiemtratontai.Parameters.Add("@TENVT", SqlDbType.NVarChar).Value = tenvt;
            if (Program.execStoreProcedureWithReturnValue(kiemtratontai) == 1)
            {
                MessageBox.Show("Đã tồn tại mã vật tư " + mavt);
                return;
            }
            if (Program.execStoreProcedureWithReturnValue(kiemtratontai) == 2)
            {
                MessageBox.Show("Đã tồn tại tên vật tư " + tenvt);
                return;
            }

            //neu chua ton tai trong he thong ta se tao nhan vien
            SqlCommand sqlcmd = new SqlCommand("sp_themvattu", Program.connect);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add("@MAVT", SqlDbType.NChar).Value = mavt;
            sqlcmd.Parameters.Add("@TENVT", SqlDbType.NVarChar).Value = tenvt;
            sqlcmd.Parameters.Add("@DVT", SqlDbType.NVarChar).Value = dvt;
            sqlcmd.Parameters.Add("@SLT", SqlDbType.Int).Value = slt;
            Program.execStoreProcedure(sqlcmd);

            this.Visible = false;
            Program.productForm.Visible = true;
        }
    }
}