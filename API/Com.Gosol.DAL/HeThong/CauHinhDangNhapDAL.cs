using Com.Gosol.VHTT.Models.HeThong;
using Com.Gosol.VHTT.Ultilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Gosol.VHTT.Models;

namespace Com.Gosol.VHTT.DAL.HeThong
{
    public class CauHinhDangNhapDAL
    {
        private readonly string connectionString;

        public CauHinhDangNhapDAL()
        {
            // Connection string lấy từ SQLHelper hoặc từ cấu hình ứng dụng của bạn
            connectionString = SQLHelper.appConnectionStrings;
        }

        // Method để thêm mới một bản ghi
        public BaseResultModel InsertCauHinhDangNhap(CauHinhDangNhap cauHinh)
        {
            var Result = new BaseResultModel();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("v2_HT_QuanLyCauHinhDangNhap_Insert", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TenPhanMem", cauHinh.TenPhanMem ?? Convert.DBNull);
                    command.Parameters.AddWithValue("@SlideAnh", cauHinh.SlideAnh ?? Convert.DBNull);
                    command.Parameters.AddWithValue("@Logo", cauHinh.LogoDangNhap ?? 0);
                    command.Parameters.AddWithValue("@HinhNen", cauHinh.HinhNenDangNhap ?? 0);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                Result.Status = 1;
                Result.Message = "Thêm mới cấu hình đăng nhập thành công!";

                return Result;
            }
            catch (Exception ex)
            {
                Result.Status = -1;
                Result.Message = ex.Message;
                return Result;

            }
        }

        // Method để cập nhật một bản ghi
        public BaseResultModel UpdateCauHinhDangNhap(CauHinhDangNhap cauHinh)
        {
            var Result = new BaseResultModel();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("v2_HT_QuanLyCauHinhDangNhap_Update", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", cauHinh.ID);
                    command.Parameters.AddWithValue("@TenPhanMem", cauHinh.TenPhanMem ?? Convert.DBNull);
                    command.Parameters.AddWithValue("@SlideAnh", cauHinh.SlideAnh ?? Convert.DBNull);
                    command.Parameters.AddWithValue("@Logo", cauHinh.LogoDangNhap ?? 0);
                    command.Parameters.AddWithValue("@HinhNen", cauHinh.HinhNenDangNhap ?? 0);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                Result.Status = 1;
                Result.Message = "Cập nhập cấu hình đăng nhập thành công!";

                return Result;
            }
            catch (Exception ex)
            {
                Result.Status = -1;
                Result.Message = ex.Message;
                return Result;

            }
        }

        // Method để xóa một bản ghi
        public BaseResultModel DeleteCauHinhDangNhap(int id)
        {
            var Result = new BaseResultModel();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("v2_HT_QuanLyCauHinhDangNhap_Delete", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                Result.Status = 1;
                Result.Message = "Xóa cấu hình đăng nhập thành công!";

                return Result;
            }
            catch (Exception ex)
            {
                Result.Status = -1;
                Result.Message = ex.Message;
                return Result;

            }
        }

        // Method để lấy một bản ghi theo ID
        public GetCauHinhDangNhap GetCauHinhDangNhapById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("v2_HT_QuanLyCauHinhDangNhap_GetById", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new GetCauHinhDangNhap
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        TenPhanMem = reader["TenPhanMem"].ToString(),
                        SlideAnh = reader["SlideAnh"].ToString(),
                        LogoDangNhap = Convert.ToInt32(reader["Logo"]),
                        HinhNenDangNhap = Convert.ToInt32(reader["HinhNen"])
                    };
                }
                return null;
            }
        }

        // Method để lấy tất cả các bản ghi
        public List<GetCauHinhDangNhap> GetAllCauHinhDangNhap()
        {
            List<GetCauHinhDangNhap> cauHinhs = new List<GetCauHinhDangNhap>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM HT_QuanLyCauHinhDangNhap", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cauHinhs.Add(new GetCauHinhDangNhap
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        TenPhanMem = reader["TenPhanMem"].ToString(),
                        SlideAnh = reader["SlideAnh"].ToString(),
                        LogoDangNhap = Convert.ToInt32(reader["Logo"]),
                        HinhNenDangNhap = Convert.ToInt32(reader["HinhNen"])
                    });
                }
            }
            return cauHinhs;
        }
    }
}
