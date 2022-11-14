using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bai09
{
    class Modify
    {
        SqlDataAdapter dataAdapter; // Truy xuat du lieu vao bang
        SqlCommand sqlCommand;
        public Modify()
        {

        }
        public DataTable getAllSinhVien()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from SINHVIEN";
            //------------------------------------------
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                //------------------------------------------
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                //------------------------------------------
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insert(SinhVien sinhvien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into SINHVIEN values(@MSSV, @HoTen, @ChuyenNganh, @GioiTinh, @SoMon)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MSSV", SqlDbType.Char).Value = sinhvien.Mssv;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sinhvien.Hoten;
                sqlCommand.Parameters.Add("@ChuyenNganh", SqlDbType.NVarChar).Value = sinhvien.Chuyennganh;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sinhvien.Gioitinh;
                sqlCommand.Parameters.Add("@SoMon", SqlDbType.Int).Value = sinhvien.Somon;
                sqlCommand.ExecuteNonQuery(); // Thuc thi cau lenh truy van
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool delete(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "delete SINHVIEN WHERE MSSV = @MSSV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MSSV", SqlDbType.Char).Value = id;
                sqlCommand.ExecuteNonQuery(); // Thuc thi cau lenh truy van
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
    
}
