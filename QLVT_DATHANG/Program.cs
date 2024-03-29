﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Text;
using System.Text.RegularExpressions;

namespace QLVT_DATHANG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 
        /// 
        // forms declaration
        public static MainForm mainForm;
        public static EmployeeForm employeeForm;
        public static StorageForm storageForm;
        public static ProductForm productForm;
        public static LoginForm loginForm;
        public static RegisterForm registerForm;
        public static SubForm.ThemVT addProductForm;
        public static SubForm.ThemKho addStorageForm;
        public static SubForm.LapDonDatHang addDDHForm;
        public static SubForm.LapPhieuNhap addPhieuNhapForm;
        public static SubForm.LapPhieuXuat addPhieuXuatForm;
        public static SubForm.ThemNV addEmployeeForm;
        public static SubForm.LapPhieuNhap_AddNew addNewPhieuNhap;

        public static Report.MenuDanhSachNhanVien menuDanhSachNhanVien;
        public static Report.MenuHoatDongNhanVien menuHoatDongNhanVien;
        public static Report.MenuTongHopNhapXuat menuTongHopNhapXuat;

        public static bool flagCloseRegisterForm;

        public static SqlConnection connect = new SqlConnection();
        public static String connectString = "";
        public static SqlDataReader dataReader;
        public static String servername = "";
        public static String username = "";
        public static String password = "";

        public static String serverLogin = "";

        public static String database = "QLVT_DATHANG";

        public static String remoteLogin = "HTKN";
        public static String remotePassword = "z";

        public static String usernameCurrent = "";
        public static String passwordCurrent = "";

        public static String group = "";
        public static String hoten = "";
        public static int chiNhanh = 0;

        public static BindingSource bdsDanhSachPhanManh = new BindingSource();  // giữ bdsPhanManh khi đăng nhập


        //kiểm tra các textbox có rỗng hay không
        public static bool checkValidate(TextBox tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        //kiem tra chuoi rong
        public static bool isEmpty(TextBox value)
        {
            bool empty = value.Text.Length == 0;
            if (empty)
            {
                MessageBox.Show("Trường này không được để rỗng");
                value.Focus();
            }
            return empty;
        }
        //xoa cac ky tu dac biet trong chuoi
        public static string RemoveSpecialCharacters(string strIn)
        {
            try
            {
                return Regex.Replace(strIn, @"[^\w{\s}]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.connect);
            sqlcmd.CommandType = CommandType.Text;

            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();

            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.connect.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //update, insert sp
        public static void execStoreProcedure(SqlCommand sqlcmd)
        {
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            sqlcmd.ExecuteNonQuery();
        }

        public static int execStoreProcedureWithReturnValue(SqlCommand sqlcmd)
        {
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            SqlParameter retval = sqlcmd.Parameters.Add("@return_value", SqlDbType.Int);
            retval.Direction = ParameterDirection.ReturnValue;
            try { sqlcmd.ExecuteNonQuery(); }
            catch (Exception) { }
            return int.Parse(sqlcmd.Parameters["@return_value"].Value.ToString());

        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.connect);
            da.Fill(dt);
            connect.Close();
            return dt;
        }

        public static int KetNoi()
        {
            //neu chung ta dang co connection va trang thai ket noi hien tai dang mo
            if (Program.connect != null && Program.connect.State == ConnectionState.Open)
            {
                Program.connect.Close();// dong ket noi
            }

            try
            {
                Program.connectString = "Data Source=" + Program.servername + ";Initial Catalog=" +
                          Program.database + ";User ID=" +
                          Program.serverLogin + ";password=" + Program.password;
                Program.connect.ConnectionString = Program.connectString;
                Program.connect.Open();
                return 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\n-Xem lại user name và password.\n-Xem lại chi nhánh!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        //chuyen chi nhanh de xem du lieu
        public static void chuyenChiNhanh(string server)
        {
            if (server == "null")
            {
                return;
            }
            //neu server ma user chon dang la server dang truy cap thi bao loi va out
            if (server == Program.servername)
            {
                return;
            }


            Program.servername = server;

            // luu lai vi tri server dang dung
            String temp = Program.serverLogin;

            // thiet lap vi tri hien tai la o remote
            Program.serverLogin = Program.remoteLogin;
            Program.password = Program.remotePassword;
            Program.connectString = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" + Program.serverLogin + ";password=" + Program.password;
            // chuyen remote thanh server da luu o tren
            Program.remoteLogin = temp;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            loginForm = new LoginForm();
            Application.Run(loginForm);
        }
    }

}
