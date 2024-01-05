﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }


        private const string ConnectionString = @"Data Source= DESKTOP-IAMCQPA\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True ";
        public string luuNhanVien;

        private void SbtnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = TeTenDangNhap.Text;
            string matKhau = TeMatKhau.Text;

            if (string.IsNullOrWhiteSpace(tenTaiKhoan) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi đăng nhập", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT TAI_KHOAN.MaNV, NHAN_VIEN.TenNV " +
                                   "FROM TAI_KHOAN " +
                                   "INNER JOIN NHAN_VIEN ON TAI_KHOAN.MaNV = NHAN_VIEN.MaNV " +
                                   "WHERE TAI_KHOAN.TenTaiKhoan = @TenTaiKhoan AND TAI_KHOAN.MatKhau = @MatKhau";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            luuNhanVien = reader["MaNV"].ToString(); // Lưu mã nhân viên

                            MessageBox.Show($"Đăng nhập thành công! Xin chào {reader["TenNV"]}", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            this.Hide();
                            FormMain frmDonNhap = new FormMain();
                            frmDonNhap.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin đăng nhập không chính xác.", "Lỗi đăng nhập",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }







        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
        private void TeMatKhau_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void TeTenDangNhap_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
