using Com.Gosol.VHTT.Ultilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Gosol.Models.NghiepVu;
using Com.Gosol.VHTT.Models;

namespace Com.Gosol.DAL.NghiepVu
{
    public class NV_LichSuThuGomDAL
    {
        public NV_LichSuThuGom GetById(int id)
        {
            var result = new NV_LichSuThuGom();
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_NV_LichSuThuGom_GetById", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            var records = DataAccessHelper.MapToList<NV_LichSuThuGom>(reader);
                            result = records.FirstOrDefault();
                        }
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public BaseResultModel Insert(NV_LichSuThuGom item)
        {
            var result = new BaseResultModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_NV_LichSuThuGom_Insert", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ThungRacID", item.ThungRacID));
                    cmd.Parameters.Add(new SqlParameter("@NguoiThuGom", item.NguoiThuGom));
                    cmd.Parameters.Add(new SqlParameter("@ThoiGianThuGom", item.ThoiGianThuGom));

                    cmd.ExecuteNonQuery();
                    result.Status = 1;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Status = -1;
                result.Message = ex.Message;
                return result;
            }
        }

        public BaseResultModel Update(NV_LichSuThuGom item)
        {
            var result = new BaseResultModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_NV_LichSuThuGom_Update", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", item.ID));
                    cmd.Parameters.Add(new SqlParameter("@ThungRacID", item.ThungRacID));
                    cmd.Parameters.Add(new SqlParameter("@NguoiThuGom", item.NguoiThuGom));
                    cmd.Parameters.Add(new SqlParameter("@ThoiGianThuGom", item.ThoiGianThuGom));

                    cmd.ExecuteNonQuery();
                    result.Status = 1;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Status = -1;
                result.Message = ex.Message;
                return result;
            }
        }

        public BaseResultModel Delete(int id)
        {
            var result = new BaseResultModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLHelper.appConnectionStrings))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("v1_NV_LichSuThuGom_Delete", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.ExecuteNonQuery();
                    result.Status = 1;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Status = -1;
                result.Message = ex.Message;
                return result;
            }
        }
    }

}
