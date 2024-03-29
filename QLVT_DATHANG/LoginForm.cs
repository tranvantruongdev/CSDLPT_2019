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

namespace QLVT_DATHANG
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            executeLogin();
        }

        private void executeLogin()
        {
            if (this.usernameTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxtBox.Focus();
                return;
            }

            if (this.passwordTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTxtBox.Focus();
                return;
            }

            Program.servername = this.tenChiNhanhComboBox.SelectedValue.ToString(); //ten chi nhanh dang nhap CHINHANH1 | CHINHANH2
            Program.serverLogin = this.usernameTxtBox.Text; //login name de dang nhap vao server
            Program.password = passwordTxtBox.Text; //mat khau de dang nhap server (truyền vào connection string để kết nối tới data source)

            if (Program.KetNoi() == 0)
            {
                return;
            }

            String sp_dangnhap = "EXEC SP_DANGNHAP '" + Program.serverLogin + "'";
            Program.dataReader = Program.ExecSqlDataReader(sp_dangnhap);

            if (Program.dataReader == null)
            {
                MessageBox.Show("Đăng nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //doc ket qua tu sp_dangnhap có 3 cột ("USERNAME", "HOTEN", "NHOM")
                Program.dataReader.Read();
            }
            catch (Exception)
            {
                MessageBox.Show("Login bạn nhập không được hỗ trợ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //sau khi thuc thi sp_dangnhap ta co    0           1       2
            //                                      manhanvien  hoten   group
            Program.username = Program.dataReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.hoten = Program.dataReader.GetString(1);
            Program.group = Program.dataReader.GetString(2);

            //đóng bảng chỉ đọc và ngắt kết nối
            Program.dataReader.Close();
            Program.connect.Close();

            //thiet lap chi nhanh
            Program.chiNhanh = int.Parse(Program.servername[Program.servername.Length - 1].ToString());

            //sau khi dang nhap thanh cong luu lai thong tin dang nhap hien tai
            Program.usernameCurrent = Program.username;
            Program.passwordCurrent = Program.password;
            Program.mainForm = new MainForm();
            Program.mainForm.Activate();
            Program.mainForm.Show();
            this.usernameTxtBox.Clear();
            this.passwordTxtBox.Clear();
            this.Visible = false;
        }

        private void passwordTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//nút enter
            {
                executeLogin();
            }
        }

        private void usernameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//nút enter
            {
                this.passwordTxtBox.Focus();
            }
        }
    }
}