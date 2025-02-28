using Com.Gosol.Models.NghiepVu;
using Com.Gosol.VHTT.Ultilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.DAL.NghiepVu
{
    public class NV_SuKienVutRacDAL
    {
        private readonly string _connectionString;

        public NV_SuKienVutRacDAL()
        {
            _connectionString = SQLHelper.appConnectionStrings;
        }

        #region Get Methods

        public NV_SuKienVutRac GetById(int id)
        {
            var result = new NV_SuKienVutRac();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_NV_SuKienVutRac_GetById", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            var records = DataAccessHelper.MapToList<NV_SuKienVutRac>(reader);
                            result = records.FirstOrDefault();  // Lấy bản ghi đầu tiên (nếu có)
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
                return result;
            }
            return result;
        }

        public List<NV_SuKienVutRac> GetAll()
        {
            var results = new List<NV_SuKienVutRac>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_NV_SuKienVutRac_GetAll", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            results = DataAccessHelper.MapToList<NV_SuKienVutRac>(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
            }
            return results;
        }

        #endregion

        #region Insert Methods

        public bool Insert(NV_SuKienVutRac entity)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_NV_SuKienVutRac_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Các tham số cần truyền vào stored procedure
                    cmd.Parameters.Add(new SqlParameter("@CameraID", entity.CameraID));
                    cmd.Parameters.Add(new SqlParameter("@ThungRacID", entity.ThungRacID));
                    cmd.Parameters.Add(new SqlParameter("@ThoiGianVut", entity.ThoiGianVut));

                    // Thực thi stored procedure
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion

        #region Update Methods

        public bool Update(NV_SuKienVutRac entity)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_NV_SuKienVutRac_Update", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Các tham số cần truyền vào stored procedure
                    cmd.Parameters.Add(new SqlParameter("@ID", entity.ID));
                    cmd.Parameters.Add(new SqlParameter("@CameraID", entity.CameraID));
                    cmd.Parameters.Add(new SqlParameter("@ThungRacID", entity.ThungRacID));
                    cmd.Parameters.Add(new SqlParameter("@ThoiGianVut", entity.ThoiGianVut));

                    // Thực thi stored procedure
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion

        #region Delete Methods

        public bool Delete(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_NV_SuKienVutRac_Delete", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    // Thực thi stored procedure
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion
    }

}
