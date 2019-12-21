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
    public partial class LapPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        public LapPhieuXuat()
        {
            InitializeComponent();

            this.labelMaNV.Text = "MÃ NHÂN VIÊN: " + Program.username;
            this.labelTenNV.Text = "TÊN: " + Program.hoten;
            this.labelNhomNV.Text = "NHÓM: " + Program.group;

            // Phân quyền login
            if (Program.group == "USER")
            {
                this.btnThem.Enabled = false;
            }
            else if (Program.group == "CHINHANH")
            {

            }
            else if (Program.group == "CONGTY")
            {
                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;
                this.tenCNComboBox1.Enabled = true;
            }
        }

        private void LapPhieuXuat_Load(object sender, EventArgs e)
        {
            //tắt kiểm tra ràng buộc trước để tránh load lỗi  khi mã nhân viên không có
            cN1.EnforceConstraints = false;

            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectString;
            this.phieuXuatTableAdapter.Fill(this.cN1.PhieuXuat);

            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.v_DS_NhanVienTableAdapter.Connection.ConnectionString = Program.connectString;
            this.v_DS_NhanVienTableAdapter.Fill(this.cN1.V_DS_NhanVien);

            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectString;
            this.vattuTableAdapter.Fill(this.cN1.Vattu);

            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connectString;
            this.cTPXTableAdapter.Fill(this.cN1.CTPX);

            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.khoTableAdapter.Connection.ConnectionString = Program.connectString;
            this.khoTableAdapter.Fill(this.cN1.Kho);

            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DS_PHANMANH);

            this.tenCNComboBox1.SelectedValue = Program.servername;

            //bật lại kiểm tra ràng buộc
            cN1.EnforceConstraints = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mainForm.Visible = true;
            this.Visible = false;
        }

        private void tenCNComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //khi load form cac index thay doi
            //khi thay đổi có cái = null nên sẽ không thể tostring đc
            string server = this.tenCNComboBox1.SelectedValue != null ? this.tenCNComboBox1.SelectedValue.ToString() : "null";
            Program.chuyenChiNhanh(server);
            try
            {
                this.btnReload.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối Server thất bại! " + ex.Message, "Notification", MessageBoxButtons.OK);
                return;
            }
        }

        private void hoTenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maNVSpinEdit.Text = hoTenComboBox.SelectedValue.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void maNVSpinEdit_TextChanged(object sender, EventArgs e)
        {
            //thay doi ten nhan vien trong combobox khi ma nhan vien thay doi
            //xu ly khi nhan vao row trong table don dat hang
            try
            {
                string manv = this.maNVSpinEdit.Text;
                this.hoTenComboBox.SelectedValue = int.Parse(manv);
            }
            catch (Exception)
            {

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectString;
            this.phieuXuatTableAdapter.Fill(this.cN1.PhieuXuat);

            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.v_DS_NhanVienTableAdapter.Connection.ConnectionString = Program.connectString;
            this.v_DS_NhanVienTableAdapter.Fill(this.cN1.V_DS_NhanVien);

            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectString;
            this.vattuTableAdapter.Fill(this.cN1.Vattu);

            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connectString;
            this.cTPXTableAdapter.Fill(this.cN1.CTPX);

            //thay đổi connectionstring để phù hợp với tài khoản mới khi chuyển chi nhánh or đăng nhập lại
            this.khoTableAdapter.Connection.ConnectionString = Program.connectString;
            this.khoTableAdapter.Fill(this.cN1.Kho);
        }

        private void tenKhoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maKhoTextEdit.Text = tenKhoComboBox.SelectedValue.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void maKhoTextEdit_TextChanged(object sender, EventArgs e)
        {
            //thay doi ten nhan vien trong combobox khi ma nhan vien thay doi
            //xu ly khi nhan vao row trong table don dat hang
            try
            {
                string makho = this.maKhoTextEdit.Text;
                this.tenKhoComboBox.SelectedValue = makho;
            }
            catch (Exception)
            {

            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cTPXBindingSource.Count > 0)
            {
                MessageBox.Show("Phiếu xuất đã có chi tiết phiếu. Xin vui lòng xoá chi tiết phiếu trước.", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                string cmd = "EXEC sp_xoaphieuxuat '" + this.maPhieuXuatTextEdit.Text + "'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.connect);
                sqlcmd.CommandType = CommandType.Text;
                Program.execStoreProcedure(sqlcmd);
                btnReload.PerformClick();
            }
        }

        private void btnSubformAdd_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cTPXBindingSource.EndEdit();
            this.cTPXTableAdapter.Update(this.cN1);
            // fill lại dữ liệu cho subform
            this.cTPXTableAdapter.Fill(this.cN1.CTPX);
        }

        private void btnSubformWrite_Click(object sender, EventArgs e)
        {
            btnSubformAdd.PerformClick();
        }

        private void btnSubformDel_Click(object sender, EventArgs e)
        {
            //xóa phần tử hiện tại trong bảng(con trỏ ở đâu xóa ở đó)
            this.cTPXBindingSource.RemoveCurrent();
            this.btnSubformAdd.PerformClick();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mapx = this.maPhieuXuatTextEdit.Text;
            DateTime ngaylap = this.ngayLapDateEdit.Value;
            string ngayLap = ngaylap.Year.ToString() + "-" + ngaylap.Month.ToString() + "-" + ngaylap.Day.ToString();
            string hotenkhachhang = this.hoTenKhachHangTextEdit.Text;
            string manv = this.maNVSpinEdit.Text;
            string makho = this.maKhoTextEdit.Text;

            //câu lệnh tạo sp để lập đơn đặt hàng
            SqlCommand sqlcmd = new SqlCommand("sp_lapphieuxuat", Program.connect);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add("@MAPX", SqlDbType.NChar).Value = mapx;
            sqlcmd.Parameters.Add("@NGAY", SqlDbType.DateTime).Value = ngayLap;
            sqlcmd.Parameters.Add("@HOTENKH", SqlDbType.NVarChar).Value = hotenkhachhang;
            sqlcmd.Parameters.Add("@MANV", SqlDbType.Int).Value = manv;
            sqlcmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = makho;

            int checkIf = Program.execStoreProcedureWithReturnValue(sqlcmd);
            //văng lỗi theo mã
            if (checkIf == 2627)
            {
                MessageBox.Show("Mã phiếu xuất đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (checkIf == 547)
            {
                MessageBox.Show("Mã nhân viên hoặc mã kho không tồn tại", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (checkIf == 0)
            {
                MessageBox.Show("Thêm phiếu xuất thành công", "Xong", MessageBoxButtons.OK);
                this.btnReload.PerformClick();
                return;
            }
        }

        private bool checkValidate(TextEdit tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(maPhieuXuatTextEdit, "Field mã phiếu xuất không được để trống!")) return;
            if (!checkValidate(hoTenKhachHangTextEdit, "Field họ tên khách hàng không được để trống!")) return;

            // lay thong tin phieu xuat hien tai
            string mapx = this.maPhieuXuatTextEdit.Text;
            DateTime ngaylap = this.ngayLapDateEdit.Value;
            string ngayLap = ngaylap.Year.ToString() + "-" + ngaylap.Month.ToString() + "-" + ngaylap.Day.ToString();
            string tenkhachhang = this.hoTenKhachHangTextEdit.Text;
            string manv = this.maNVSpinEdit.Text;
            string makho = this.maKhoTextEdit.Text;

            //câu lệnh tạo sp để update phieu xuat
            SqlCommand sqlcmd = new SqlCommand("sp_updatephieuxuat", Program.connect);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add("@MAPX", SqlDbType.NChar).Value = mapx;
            sqlcmd.Parameters.Add("@NGAY", SqlDbType.Date).Value = ngayLap;
            sqlcmd.Parameters.Add("@HOTENKH", SqlDbType.NVarChar).Value = tenkhachhang;
            sqlcmd.Parameters.Add("@MANV", SqlDbType.Int).Value = manv;
            sqlcmd.Parameters.Add("@MAKHO", SqlDbType.NChar).Value = makho;
            Program.execStoreProcedure(sqlcmd);
            this.btnReload.PerformClick();
        }
    }
}