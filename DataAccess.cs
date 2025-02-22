﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management
{
    internal class DataAccess
    {
        public SqlConnection objConnection { get; private set; }
        public DataAccess()
        {
            // Vui lòng đổi lại đường dẫn khi thao tác tại máy
            //string strConnection = @"Data Source=.\SQLEXPRESS01;Initial Catalog=QLST;Integrated Security=True";

            //Chuỗi kết nối bỏ qua kiểm tra chứng chỉ SSL:
            string strConnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True;TrustServerCertificate=True;";

            objConnection = new SqlConnection(strConnection);

        }
        public void UpdateData(string i_updateCommand)
        {
            try
            {
                objConnection.Open();
                Console.WriteLine("Connection succeeded");
                SqlCommand cmd = new SqlCommand(i_updateCommand, objConnection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                if (objConnection != null)
                    objConnection.Close();
            }
        }

        public DataTable GetDataTable(string i_selectCommand)
        {
            DataTable dt = new DataTable();
            try
            {
                objConnection.Open();
                Console.WriteLine("Connection succeeded");
                SqlDataAdapter objAdapter = new SqlDataAdapter(i_selectCommand, objConnection);

                objAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                if (objConnection != null)
                    objConnection.Close();
            }

            return dt;
        }
        public object GetScalar(string query, SqlParameter parameter = null)
        {
            try
            {
                objConnection.Open();
                Console.WriteLine("Connection succeeded");

                using (SqlCommand cmd = new SqlCommand(query, objConnection))
                {
                    if (parameter != null)
                        cmd.Parameters.Add(parameter);

                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                objConnection.Close();
            }
        }
    }
}
