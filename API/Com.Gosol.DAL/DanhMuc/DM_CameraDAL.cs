using Com.Gosol.Models.DanhMuc;
using Com.Gosol.VHTT.Models;
using Com.Gosol.VHTT.Ultilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.DAL.DanhMuc
{
    public class DM_CameraDAL
    {
        // Lấy thông tin camera theo ID
        public DM_Camera GetById(int id)
        {
            DM_Camera camera = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_GetById", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            var records = DataAccessHelper.MapToList<DM_Camera>(reader);
                            camera = records.FirstOrDefault();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception
            }
            return camera;
        }

        public DM_Camera GetByCode(string id)
        {
            DM_Camera camera = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_GetByCameraCode", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@MaCamera", id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            var records = DataAccessHelper.MapToList<DM_Camera>(reader);
                            camera = records.FirstOrDefault();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception
            }
            return camera;
        }


        // Lấy tất cả thông tin camera
        public List<DM_Camera_ThungRacRespone> GetAll()
        {
            List<DM_Camera_ThungRacRespone> cameras = new List<DM_Camera_ThungRacRespone>();
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_GetAll", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            cameras = DataAccessHelper.MapToList<DM_Camera_ThungRacRespone>(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception
            }
            return cameras;
        }

        // Thêm mới camera
        public bool Insert(DM_Camera camera)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@MaCamera", camera.MaCamera));
                    cmd.Parameters.Add(new SqlParameter("@TenCamera", camera.TenCamera));
                    cmd.Parameters.Add(new SqlParameter("@ViTri", camera.ViTri));
                    cmd.Parameters.Add(new SqlParameter("@ViDo", camera.ViDo));
                    cmd.Parameters.Add(new SqlParameter("@KinhDo", camera.KinhDo));
                    cmd.Parameters.Add(new SqlParameter("@DiaChiIP", camera.DiaChiIP));
                    cmd.Parameters.Add(new SqlParameter("@DiaChiMAC", camera.DiaChiMAC));
                    cmd.Parameters.Add(new SqlParameter("@NgayTao", camera.NgayTao));

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

        // Cập nhật thông tin camera
        public bool Update(DM_Camera camera)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_Update", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@ID", camera.ID));
                    cmd.Parameters.Add(new SqlParameter("@MaCamera", camera.MaCamera));
                    cmd.Parameters.Add(new SqlParameter("@TenCamera", camera.TenCamera));
                    cmd.Parameters.Add(new SqlParameter("@ViTri", camera.ViTri));
                    cmd.Parameters.Add(new SqlParameter("@ViDo", camera.ViDo));
                    cmd.Parameters.Add(new SqlParameter("@KinhDo", camera.KinhDo));
                    cmd.Parameters.Add(new SqlParameter("@DiaChiIP", camera.DiaChiIP));
                    cmd.Parameters.Add(new SqlParameter("@DiaChiMAC", camera.DiaChiMAC));
                    cmd.Parameters.Add(new SqlParameter("@NgayTao", camera.NgayTao));

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

        // Xóa camera theo ID
        public bool Delete(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_DM_Camera_Delete", conn)
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
    }

}
