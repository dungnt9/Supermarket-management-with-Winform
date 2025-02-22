﻿namespace market_management.UI
{
    partial class UcTKSPDaBan
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LbcTenSP = new DevExpress.XtraEditors.LabelControl();
            this.LbcSoSP = new DevExpress.XtraEditors.LabelControl();
            this.GcSanPhamDaBan = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcTKSP = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcSanPhamDaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcTKSP)).BeginInit();
            this.GcTKSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 25);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(176, 21);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Sản phẩm bán chạy nhất";
            // 
            // LbcTenSP
            // 
            this.LbcTenSP.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.LbcTenSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcTenSP.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.LbcTenSP.Appearance.Options.UseFont = true;
            this.LbcTenSP.Appearance.Options.UseForeColor = true;
            this.LbcTenSP.Location = new System.Drawing.Point(22, 45);
            this.LbcTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbcTenSP.Name = "LbcTenSP";
            this.LbcTenSP.Size = new System.Drawing.Size(96, 45);
            this.LbcTenSP.TabIndex = 7;
            this.LbcTenSP.Text = "Tên SP";
            // 
            // LbcSoSP
            // 
            this.LbcSoSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcSoSP.Appearance.Options.UseFont = true;
            this.LbcSoSP.Location = new System.Drawing.Point(22, 94);
            this.LbcSoSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbcSoSP.Name = "LbcSoSP";
            this.LbcSoSP.Size = new System.Drawing.Size(80, 20);
            this.LbcSoSP.TabIndex = 6;
            this.LbcSoSP.Text = "Số lượng SP";
            // 
            // GcSanPhamDaBan
            // 
            this.GcSanPhamDaBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcSanPhamDaBan.Location = new System.Drawing.Point(-3, 126);
            this.GcSanPhamDaBan.MainView = this.gridView2;
            this.GcSanPhamDaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcSanPhamDaBan.Name = "GcSanPhamDaBan";
            this.GcSanPhamDaBan.Size = new System.Drawing.Size(862, 515);
            this.GcSanPhamDaBan.TabIndex = 8;
            this.GcSanPhamDaBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.GcSanPhamDaBan;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // GcTKSP
            // 
            this.GcTKSP.Controls.Add(this.LbcTenSP);
            this.GcTKSP.Controls.Add(this.GcSanPhamDaBan);
            this.GcTKSP.Controls.Add(this.labelControl5);
            this.GcTKSP.Controls.Add(this.LbcSoSP);
            this.GcTKSP.Location = new System.Drawing.Point(3, 13);
            this.GcTKSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcTKSP.Name = "GcTKSP";
            this.GcTKSP.Size = new System.Drawing.Size(864, 645);
            this.GcTKSP.TabIndex = 10;
            this.GcTKSP.Text = "Thống kê sản phẩm";
            // 
            // UcTKSPDaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GcTKSP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcTKSPDaBan";
            this.Size = new System.Drawing.Size(870, 660);
            ((System.ComponentModel.ISupportInitialize)(this.GcSanPhamDaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcTKSP)).EndInit();
            this.GcTKSP.ResumeLayout(false);
            this.GcTKSP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl LbcTenSP;
        private DevExpress.XtraEditors.LabelControl LbcSoSP;
        private DevExpress.XtraGrid.GridControl GcSanPhamDaBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl GcTKSP;
    }
}
