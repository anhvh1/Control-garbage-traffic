using Com.Gosol.VHTT.Ultilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Gosol.Models.DanhMuc;

namespace Com.Gosol.DAL.DanhMuc
{
    public class DM_Camera_ThungRacDAL
    {
        // Lấy thông tin DM_Camera_ThungRac theo ID
        public DM_Camera_ThungRac GetById(int id)
        {
            DM_Camera_ThungRac cameraThungRac = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_ThungRac_GetById", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            var records = DataAccessHelper.MapToList<DM_Camera_ThungRac>(reader);
                            cameraThungRac = records.FirstOrDefault();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception
            }
            return cameraThungRac;
        }

        // Thêm mới một bản ghi DM_Camera_ThungRac
        public bool Insert(DM_Camera_ThungRac cameraThungRac)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_ThungRac_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@CameraID", cameraThungRac.CameraID));
                    cmd.Parameters.Add(new SqlParameter("@ThungRacID", cameraThungRac.ThungRacID));

                    var result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        // Cập nhật thông tin DM_Camera_ThungRac
        public bool Update(DM_Camera_ThungRac cameraThungRac)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_ThungRac_Update", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@ID", cameraThungRac.ID));
                    cmd.Parameters.Add(new SqlParameter("@CameraID", cameraThungRac.CameraID));
                    cmd.Parameters.Add(new SqlParameter("@ThungRacID", cameraThungRac.ThungRacID));

                    var result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        // Xóa DM_Camera_ThungRac theo ID
        public bool Delete(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_ThungRac_Delete", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    var result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        // Lấy tất cả các bản ghi DM_Camera_ThungRac
        public List<DM_Camera_ThungRac> GetAll()
        {
            List<DM_Camera_ThungRac> cameraThungRacs = new List<DM_Camera_ThungRac>();
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_ThungRac_GetAll", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            cameraThungRacs = DataAccessHelper.MapToList<DM_Camera_ThungRac>(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception
            }
            return cameraThungRacs;
        }

        public List<DM_Camera_ThungRacRespone> GetByCameraCode(string maCamera)
        {
            var results = new List<DM_Camera_ThungRacRespone>();
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_ThungRac_GetByCameraCode", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@MaCamera", maCamera));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            results = DataAccessHelper.MapToList<DM_Camera_ThungRacRespone>(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle as necessary
                throw new Exception("An error occurred while fetching camera data.", ex);
            }

            return results;
        }
    }

}
