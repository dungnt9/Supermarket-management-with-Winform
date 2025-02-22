﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management.UI
{
    public partial class UcTKSPDaBan : DevExpress.XtraEditors.XtraUserControl
    {
        public UcTKSPDaBan()
        {
            InitializeComponent();
            LoadData();
            LaySPBanNhieuNhat();
        }
        DataAccess dataAccess = new DataAccess();

        private void LoadData()
        {
            DataTable dataTable = LaySPDaBan();
            GcSanPhamDaBan.DataSource = dataTable;
        }

        private void LaySPBanNhieuNhat()
        {
            DataRow dongSPBanNhieuNhat = LayDongSPBanNhieuNhat();

            if (dongSPBanNhieuNhat != null)
            {
                LbcTenSP.Text = dongSPBanNhieuNhat["Tên Sản Phẩm"].ToString();
                LbcSoSP.Text = dongSPBanNhieuNhat["Số lượng đã bán"].ToString() + " sản phẩm";
            }
        }
        private DataRow LayDongSPBanNhieuNhat()
        {
            DataTable dataTable = LaySPDaBan();
            DataRow dongSPBanNhieuNhat = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            return dongSPBanNhieuNhat;
        }
        private DataTable LaySPDaBan()
        {
            DataTable dataTable = new DataTable();
            
            string query = "SELECT SP.MaSP AS 'Mã Sản Phẩm', SP.TenSP AS 'Tên Sản Phẩm', SP.SoLuong AS 'Số lượng', SUM(CT.SoLuong) AS 'Số lượng đã bán' " +
                           "FROM SAN_PHAM SP " +
                           "JOIN CT_HOA_DON_BAN CT ON SP.MaSP = CT.MaSP " +
                           "GROUP BY SP.MaSP, SP.TenSP, SP.SoLuong " +
                           "ORDER BY [Số lượng đã bán] DESC";
            
            dataTable = dataAccess.GetDataTable(query);

            return dataTable;
        }

        private void CmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            LaySPBanNhieuNhat();
        }
    }
}
