using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối cơ sở dữ liệu
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-DQSEFU7\NGUYENLAM;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect
            return conn;
        }
    }

    public class DatabaseAccess
    {
        public static string CheckLogicDTO(TaiKhoan taikhoan)
        {
            string user = null;
            // Hàm connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.sTaiKhoan);
            command.Parameters.AddWithValue("@pass", taikhoan.sMatKhau);
            // Kiểm tra quyền các bạn thêm 1 cái parameter...
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            } else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
             
            return user;
        }
    }
}
