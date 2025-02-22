﻿namespace market_management.UI
{
    partial class UcNhaCungCap
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GcNCC = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.BbiThemNCC = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSuaNCC = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoaNCC = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TeTenNCC = new DevExpress.XtraEditors.TextEdit();
            this.TeSĐTNCC = new DevExpress.XtraEditors.TextEdit();
            this.TeDiaChiNCC = new DevExpress.XtraEditors.TextEdit();
            this.LbLoaiSanPham = new DevExpress.XtraEditors.LabelControl();
            this.CbeLoaiSanPham = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GcNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSĐTNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChiNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeLoaiSanPham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcNCC
            // 
            this.GcNCC.Location = new System.Drawing.Point(0, 239);
            this.GcNCC.MainView = this.gridView;
            this.GcNCC.MenuManager = this.ribbonControl;
            this.GcNCC.Name = "GcNCC";
            this.GcNCC.Size = new System.Drawing.Size(870, 421);
            this.GcNCC.TabIndex = 2;
            this.GcNCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.GcNCC;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.BbiThemNCC,
            this.BbiSuaNCC,
            this.BbiXoaNCC,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(870, 126);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // BbiThemNCC
            // 
            this.BbiThemNCC.Caption = "Thêm";
            this.BbiThemNCC.Id = 16;
            this.BbiThemNCC.ImageOptions.ImageUri.Uri = "New";
            this.BbiThemNCC.Name = "BbiThemNCC";
            this.BbiThemNCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiThemNCC_ItemClick);
            // 
            // BbiSuaNCC
            // 
            this.BbiSuaNCC.Caption = "Sửa";
            this.BbiSuaNCC.Id = 17;
            this.BbiSuaNCC.ImageOptions.ImageUri.Uri = "Edit";
            this.BbiSuaNCC.Name = "BbiSuaNCC";
            this.BbiSuaNCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSuaNCC_ItemClick);
            // 
            // BbiXoaNCC
            // 
            this.BbiXoaNCC.Caption = "Xóa";
            this.BbiXoaNCC.Id = 18;
            this.BbiXoaNCC.ImageOptions.ImageUri.Uri = "Delete";
            this.BbiXoaNCC.Name = "BbiXoaNCC";
            this.BbiXoaNCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiXoaNCC_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Làm Mới";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý Nhà Cung Cấp";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiThemNCC);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiSuaNCC);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiXoaNCC);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ";
            // 
            // TeTenNCC
            // 
            this.TeTenNCC.Location = new System.Drawing.Point(201, 154);
            this.TeTenNCC.MenuManager = this.ribbonControl;
            this.TeTenNCC.Name = "TeTenNCC";
            this.TeTenNCC.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeTenNCC.Properties.Appearance.Options.UseFont = true;
            this.TeTenNCC.Size = new System.Drawing.Size(158, 26);
            this.TeTenNCC.TabIndex = 7;
            // 
            // TeSĐTNCC
            // 
            this.TeSĐTNCC.Location = new System.Drawing.Point(201, 203);
            this.TeSĐTNCC.MenuManager = this.ribbonControl;
            this.TeSĐTNCC.Name = "TeSĐTNCC";
            this.TeSĐTNCC.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeSĐTNCC.Properties.Appearance.Options.UseFont = true;
            this.TeSĐTNCC.Size = new System.Drawing.Size(158, 26);
            this.TeSĐTNCC.TabIndex = 8;
            // 
            // TeDiaChiNCC
            // 
            this.TeDiaChiNCC.Location = new System.Drawing.Point(597, 151);
            this.TeDiaChiNCC.MenuManager = this.ribbonControl;
            this.TeDiaChiNCC.Name = "TeDiaChiNCC";
            this.TeDiaChiNCC.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeDiaChiNCC.Properties.Appearance.Options.UseFont = true;
            this.TeDiaChiNCC.Size = new System.Drawing.Size(196, 26);
            this.TeDiaChiNCC.TabIndex = 9;
            // 
            // LbLoaiSanPham
            // 
            this.LbLoaiSanPham.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLoaiSanPham.Appearance.Options.UseFont = true;
            this.LbLoaiSanPham.Location = new System.Drawing.Point(485, 204);
            this.LbLoaiSanPham.Name = "LbLoaiSanPham";
            this.LbLoaiSanPham.Size = new System.Drawing.Size(97, 20);
            this.LbLoaiSanPham.TabIndex = 12;
            this.LbLoaiSanPham.Text = "Loại Sản Phẩm";
            // 
            // CbeLoaiSanPham
            // 
            this.CbeLoaiSanPham.Location = new System.Drawing.Point(597, 198);
            this.CbeLoaiSanPham.MenuManager = this.ribbonControl;
            this.CbeLoaiSanPham.Name = "CbeLoaiSanPham";
            this.CbeLoaiSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeLoaiSanPham.Properties.Appearance.Options.UseFont = true;
            this.CbeLoaiSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeLoaiSanPham.Size = new System.Drawing.Size(100, 26);
            this.CbeLoaiSanPham.TabIndex = 13;
            // 
            // UcNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbeLoaiSanPham);
            this.Controls.Add(this.LbLoaiSanPham);
            this.Controls.Add(this.TeDiaChiNCC);
            this.Controls.Add(this.TeSĐTNCC);
            this.Controls.Add(this.TeTenNCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GcNCC);
            this.Controls.Add(this.ribbonControl);
            this.Name = "UcNhaCungCap";
            this.Size = new System.Drawing.Size(870, 660);
            ((System.ComponentModel.ISupportInitialize)(this.GcNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSĐTNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChiNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeLoaiSanPham.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcNCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem BbiThemNCC;
        private DevExpress.XtraBars.BarButtonItem BbiSuaNCC;
        private DevExpress.XtraBars.BarButtonItem BbiXoaNCC;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit TeTenNCC;
        private DevExpress.XtraEditors.TextEdit TeSĐTNCC;
        private DevExpress.XtraEditors.TextEdit TeDiaChiNCC;
        private DevExpress.XtraEditors.LabelControl LbLoaiSanPham;
        private DevExpress.XtraEditors.ComboBoxEdit CbeLoaiSanPham;
    }
}
