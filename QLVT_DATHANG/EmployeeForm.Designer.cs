﻿namespace QLVT_DATHANG
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tENCNLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label lUONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addButton = new DevExpress.XtraBars.BarButtonItem();
            this.eraseButton = new DevExpress.XtraBars.BarButtonItem();
            this.writeButton = new DevExpress.XtraBars.BarButtonItem();
            this.undoButton = new DevExpress.XtraBars.BarButtonItem();
            this.reloadButton = new DevExpress.XtraBars.BarButtonItem();
            this.btnMove = new DevExpress.XtraBars.BarButtonItem();
            this.exitButton = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tenChiNhanhComboBox = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVT_DATHANG.QLVT_DATHANGDataSet();
            this.cN1 = new QLVT_DATHANG.CN1();
            this.nhanVienTableAdapter = new QLVT_DATHANG.CN1TableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.CN1TableAdapters.TableAdapterManager();
            this.v_DS_PHANMANHTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maChiNhanhComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControlNhanVien = new DevExpress.XtraEditors.GroupControl();
            this.diaChiTextEdit = new System.Windows.Forms.TextBox();
            this.tenTextEdit = new System.Windows.Forms.TextBox();
            this.hoTextEdit = new System.Windows.Forms.TextBox();
            this.labelNhomNV = new DevExpress.XtraEditors.LabelControl();
            this.labelTenNV = new DevExpress.XtraEditors.LabelControl();
            this.labelMaNV = new DevExpress.XtraEditors.LabelControl();
            this.ngaySinhDateTImePicker = new System.Windows.Forms.DateTimePicker();
            this.luongSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.trangThaiXoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maNhanVienTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_DATHANG.CN1TableAdapters.DatHangTableAdapter();
            this.phieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT_DATHANG.CN1TableAdapters.PhieuXuatTableAdapter();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT_DATHANG.CN1TableAdapters.PhieuNhapTableAdapter();
            tENCNLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maChiNhanhComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNhanVien)).BeginInit();
            this.groupControlNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luongSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangThaiXoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNhanVienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(26, 30);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(120, 17);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chuyển chi nhánh";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(162, 48);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(94, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(229, 89);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(465, 49);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(36, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(701, 48);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(73, 17);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(689, 89);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(94, 17);
            mACNLabel.TabIndex = 8;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(960, 89);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(102, 17);
            trangThaiXoaLabel.TabIndex = 10;
            trangThaiXoaLabel.Text = "Trạng thái xóa:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(448, 90);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(53, 17);
            dIACHILabel.TabIndex = 12;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(1006, 48);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(53, 17);
            lUONGLabel.TabIndex = 15;
            lUONGLabel.Text = "Lương:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addButton,
            this.eraseButton,
            this.writeButton,
            this.undoButton,
            this.reloadButton,
            this.exitButton,
            this.btnMove});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addButton, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.eraseButton, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.writeButton, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.undoButton, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.reloadButton, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMove, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.exitButton, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addButton
            // 
            this.addButton.Caption = "Thêm";
            this.addButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addButton.Glyph")));
            this.addButton.Id = 0;
            this.addButton.Name = "addButton";
            this.addButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addButton_ItemClick);
            // 
            // eraseButton
            // 
            this.eraseButton.Caption = "Xóa";
            this.eraseButton.Glyph = ((System.Drawing.Image)(resources.GetObject("eraseButton.Glyph")));
            this.eraseButton.Id = 1;
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.eraseButton_ItemClick);
            // 
            // writeButton
            // 
            this.writeButton.Caption = "Ghi";
            this.writeButton.Glyph = ((System.Drawing.Image)(resources.GetObject("writeButton.Glyph")));
            this.writeButton.Id = 2;
            this.writeButton.Name = "writeButton";
            this.writeButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.writeButton_ItemClick);
            // 
            // undoButton
            // 
            this.undoButton.Caption = "Undo";
            this.undoButton.Glyph = ((System.Drawing.Image)(resources.GetObject("undoButton.Glyph")));
            this.undoButton.Id = 3;
            this.undoButton.Name = "undoButton";
            this.undoButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.undoButton_ItemClick);
            // 
            // reloadButton
            // 
            this.reloadButton.Caption = "Reload";
            this.reloadButton.Glyph = ((System.Drawing.Image)(resources.GetObject("reloadButton.Glyph")));
            this.reloadButton.Id = 4;
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.reloadButton_ItemClick);
            // 
            // btnMove
            // 
            this.btnMove.Caption = "Chuyển chi nhánh";
            this.btnMove.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMove.Glyph")));
            this.btnMove.Id = 7;
            this.btnMove.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMove.LargeGlyph")));
            this.btnMove.Name = "btnMove";
            this.btnMove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMove_ItemClick);
            // 
            // exitButton
            // 
            this.exitButton.Caption = "Thoát";
            this.exitButton.Glyph = ((System.Drawing.Image)(resources.GetObject("exitButton.Glyph")));
            this.exitButton.Id = 5;
            this.exitButton.Name = "exitButton";
            this.exitButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exitButton_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1240, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1051);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1240, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1001);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1240, 50);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1001);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tENCNLabel);
            this.panel1.Controls.Add(this.tenChiNhanhComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 75);
            this.panel1.TabIndex = 4;
            // 
            // tenChiNhanhComboBox
            // 
            this.tenChiNhanhComboBox.DataSource = this.v_DS_PHANMANHBindingSource;
            this.tenChiNhanhComboBox.DisplayMember = "TENCN";
            this.tenChiNhanhComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tenChiNhanhComboBox.Enabled = false;
            this.tenChiNhanhComboBox.FormattingEnabled = true;
            this.tenChiNhanhComboBox.Location = new System.Drawing.Point(163, 26);
            this.tenChiNhanhComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenChiNhanhComboBox.Name = "tenChiNhanhComboBox";
            this.tenChiNhanhComboBox.Size = new System.Drawing.Size(1036, 24);
            this.tenChiNhanhComboBox.TabIndex = 1;
            this.tenChiNhanhComboBox.ValueMember = "TENSERVER";
            this.tenChiNhanhComboBox.SelectedIndexChanged += new System.EventHandler(this.tenChiNhanhComboBox_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cN1
            // 
            this.cN1.DataSetName = "CN1";
            this.cN1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.CN1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CTDDHTableAdapter = null;
            this.tableAdapterManager1.CTPNTableAdapter = null;
            this.tableAdapterManager1.CTPXTableAdapter = null;
            this.tableAdapterManager1.DatHangTableAdapter = null;
            this.tableAdapterManager1.KhoTableAdapter = null;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.PhieuNhapTableAdapter = null;
            this.tableAdapterManager1.PhieuXuatTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VattuTableAdapter = null;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.cN1;
            // 
            // maChiNhanhComboBoxEdit
            // 
            this.maChiNhanhComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MACN", true));
            this.maChiNhanhComboBoxEdit.Enabled = false;
            this.maChiNhanhComboBoxEdit.Location = new System.Drawing.Point(784, 86);
            this.maChiNhanhComboBoxEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maChiNhanhComboBoxEdit.MenuManager = this.barManager1;
            this.maChiNhanhComboBoxEdit.Name = "maChiNhanhComboBoxEdit";
            this.maChiNhanhComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.maChiNhanhComboBoxEdit.Size = new System.Drawing.Size(131, 22);
            this.maChiNhanhComboBoxEdit.TabIndex = 9;
            // 
            // groupControlNhanVien
            // 
            this.groupControlNhanVien.Controls.Add(this.diaChiTextEdit);
            this.groupControlNhanVien.Controls.Add(this.tenTextEdit);
            this.groupControlNhanVien.Controls.Add(this.hoTextEdit);
            this.groupControlNhanVien.Controls.Add(this.labelNhomNV);
            this.groupControlNhanVien.Controls.Add(this.labelTenNV);
            this.groupControlNhanVien.Controls.Add(this.labelMaNV);
            this.groupControlNhanVien.Controls.Add(this.ngaySinhDateTImePicker);
            this.groupControlNhanVien.Controls.Add(lUONGLabel);
            this.groupControlNhanVien.Controls.Add(this.luongSpinEdit);
            this.groupControlNhanVien.Controls.Add(this.label1);
            this.groupControlNhanVien.Controls.Add(this.trangThaiXoaTextEdit);
            this.groupControlNhanVien.Controls.Add(dIACHILabel);
            this.groupControlNhanVien.Controls.Add(this.maNhanVienTextEdit);
            this.groupControlNhanVien.Controls.Add(trangThaiXoaLabel);
            this.groupControlNhanVien.Controls.Add(mACNLabel);
            this.groupControlNhanVien.Controls.Add(this.maChiNhanhComboBoxEdit);
            this.groupControlNhanVien.Controls.Add(nGAYSINHLabel);
            this.groupControlNhanVien.Controls.Add(tENLabel);
            this.groupControlNhanVien.Controls.Add(hOLabel);
            this.groupControlNhanVien.Controls.Add(mANVLabel);
            this.groupControlNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlNhanVien.Location = new System.Drawing.Point(0, 839);
            this.groupControlNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControlNhanVien.Name = "groupControlNhanVien";
            this.groupControlNhanVien.Size = new System.Drawing.Size(1240, 212);
            this.groupControlNhanVien.TabIndex = 9;
            this.groupControlNhanVien.Text = "Nhân viên";
            // 
            // diaChiTextEdit
            // 
            this.diaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DIACHI", true));
            this.diaChiTextEdit.Location = new System.Drawing.Point(507, 87);
            this.diaChiTextEdit.MaxLength = 100;
            this.diaChiTextEdit.Name = "diaChiTextEdit";
            this.diaChiTextEdit.Size = new System.Drawing.Size(139, 23);
            this.diaChiTextEdit.TabIndex = 21;
            // 
            // tenTextEdit
            // 
            this.tenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TEN", true));
            this.tenTextEdit.Location = new System.Drawing.Point(508, 45);
            this.tenTextEdit.MaxLength = 10;
            this.tenTextEdit.Name = "tenTextEdit";
            this.tenTextEdit.Size = new System.Drawing.Size(138, 23);
            this.tenTextEdit.TabIndex = 2;
            // 
            // hoTextEdit
            // 
            this.hoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "HO", true));
            this.hoTextEdit.Location = new System.Drawing.Point(266, 87);
            this.hoTextEdit.MaxLength = 40;
            this.hoTextEdit.Name = "hoTextEdit";
            this.hoTextEdit.Size = new System.Drawing.Size(131, 23);
            this.hoTextEdit.TabIndex = 1;
            // 
            // labelNhomNV
            // 
            this.labelNhomNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNhomNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhomNV.Location = new System.Drawing.Point(816, 183);
            this.labelNhomNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelNhomNV.Name = "labelNhomNV";
            this.labelNhomNV.Size = new System.Drawing.Size(49, 23);
            this.labelNhomNV.TabIndex = 20;
            this.labelNhomNV.Text = "Nhóm";
            // 
            // labelTenNV
            // 
            this.labelTenNV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTenNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNV.Location = new System.Drawing.Point(483, 183);
            this.labelTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(32, 23);
            this.labelTenNV.TabIndex = 19;
            this.labelTenNV.Text = "Tên";
            // 
            // labelMaNV
            // 
            this.labelMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.Location = new System.Drawing.Point(227, 183);
            this.labelMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(112, 23);
            this.labelMaNV.TabIndex = 18;
            this.labelMaNV.Text = "Mã nhân viên";
            // 
            // ngaySinhDateTImePicker
            // 
            this.ngaySinhDateTImePicker.CustomFormat = "yyyy-MM-dd";
            this.ngaySinhDateTImePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "NGAYSINH", true));
            this.ngaySinhDateTImePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaySinhDateTImePicker.Location = new System.Drawing.Point(784, 45);
            this.ngaySinhDateTImePicker.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.ngaySinhDateTImePicker.Name = "ngaySinhDateTImePicker";
            this.ngaySinhDateTImePicker.Size = new System.Drawing.Size(131, 23);
            this.ngaySinhDateTImePicker.TabIndex = 17;
            this.ngaySinhDateTImePicker.Value = new System.DateTime(2019, 12, 27, 0, 0, 0, 0);
            this.ngaySinhDateTImePicker.Enter += new System.EventHandler(this.ngaySinhDateTImePicker_Enter);
            // 
            // luongSpinEdit
            // 
            this.luongSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "LUONG", true));
            this.luongSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.luongSpinEdit.Location = new System.Drawing.Point(1069, 45);
            this.luongSpinEdit.MenuManager = this.barManager1;
            this.luongSpinEdit.Name = "luongSpinEdit";
            this.luongSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luongSpinEdit.Size = new System.Drawing.Size(130, 22);
            this.luongSpinEdit.TabIndex = 4;
            this.luongSpinEdit.EditValueChanged += new System.EventHandler(this.luongSpinEdit_EditValueChanged);
            this.luongSpinEdit.Enter += new System.EventHandler(this.luongSpinEdit_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.MaximumSize = new System.Drawing.Size(70, 74);
            this.label1.MinimumSize = new System.Drawing.Size(70, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 74);
            this.label1.TabIndex = 15;
            // 
            // trangThaiXoaTextEdit
            // 
            this.trangThaiXoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "TrangThaiXoa", true));
            this.trangThaiXoaTextEdit.Enabled = false;
            this.trangThaiXoaTextEdit.Location = new System.Drawing.Point(1068, 86);
            this.trangThaiXoaTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trangThaiXoaTextEdit.MenuManager = this.barManager1;
            this.trangThaiXoaTextEdit.Name = "trangThaiXoaTextEdit";
            this.trangThaiXoaTextEdit.Size = new System.Drawing.Size(131, 22);
            this.trangThaiXoaTextEdit.TabIndex = 14;
            this.trangThaiXoaTextEdit.Enter += new System.EventHandler(this.trangThaiXoaTextEdit_Enter);
            // 
            // maNhanVienTextEdit
            // 
            this.maNhanVienTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MANV", true));
            this.maNhanVienTextEdit.Enabled = false;
            this.maNhanVienTextEdit.Location = new System.Drawing.Point(266, 46);
            this.maNhanVienTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maNhanVienTextEdit.MenuManager = this.barManager1;
            this.maNhanVienTextEdit.Name = "maNhanVienTextEdit";
            this.maNhanVienTextEdit.Size = new System.Drawing.Size(131, 22);
            this.maNhanVienTextEdit.TabIndex = 12;
            this.maNhanVienTextEdit.TextChanged += new System.EventHandler(this.maNhanVienTextEdit_TextChanged);
            this.maNhanVienTextEdit.Enter += new System.EventHandler(this.maNhanVienTextEdit_Enter);
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            // 
            // gridViewNhanVien
            // 
            this.gridViewNhanVien.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.gridViewNhanVien.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridViewNhanVien.GridControl = this.nhanVienGridControl;
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            this.gridViewNhanVien.OptionsBehavior.ReadOnly = true;
            this.gridViewNhanVien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewNhanVien.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewNhanVien.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYSINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã Chi Nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.Caption = "Trạng Thái Xóa";
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.nhanVienBindingSource;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVienGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 125);
            this.nhanVienGridControl.MainView = this.gridViewNhanVien;
            this.nhanVienGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1240, 714);
            this.nhanVienGridControl.TabIndex = 13;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "FK_NhanVien_DatHang";
            this.datHangBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatBindingSource
            // 
            this.phieuXuatBindingSource.DataMember = "FK_PX_NhanVien";
            this.phieuXuatBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "FK_PhieuNhap_NhanVien";
            this.phieuNhapBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1240, 1051);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.groupControlNhanVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.LookAndFeel.SkinName = "Metropolis";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.VisibleChanged += new System.EventHandler(this.EmployeeForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maChiNhanhComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNhanVien)).EndInit();
            this.groupControlNhanVien.ResumeLayout(false);
            this.groupControlNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luongSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangThaiXoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNhanVienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addButton;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem eraseButton;
        private DevExpress.XtraBars.BarButtonItem writeButton;
        private DevExpress.XtraBars.BarButtonItem undoButton;
        private DevExpress.XtraBars.BarButtonItem reloadButton;
        private DevExpress.XtraBars.BarButtonItem exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tenChiNhanhComboBox;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private CN1 cN1;
        private CN1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private CN1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.GroupControl groupControlNhanVien;
        private DevExpress.XtraEditors.TextEdit trangThaiXoaTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit maChiNhanhComboBoxEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DevExpress.XtraEditors.SpinEdit luongSpinEdit;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTImePicker;
        private DevExpress.XtraEditors.LabelControl labelNhomNV;
        private DevExpress.XtraEditors.LabelControl labelTenNV;
        private DevExpress.XtraEditors.LabelControl labelMaNV;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private CN1TableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource phieuXuatBindingSource;
        private CN1TableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private CN1TableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnMove;
        private System.Windows.Forms.TextBox hoTextEdit;
        private DevExpress.XtraEditors.TextEdit maNhanVienTextEdit;
        private System.Windows.Forms.TextBox tenTextEdit;
        private System.Windows.Forms.TextBox diaChiTextEdit;
    }
}