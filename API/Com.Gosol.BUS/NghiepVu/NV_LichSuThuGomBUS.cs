using Com.Gosol.DAL.DanhMuc;
using Com.Gosol.DAL.NghiepVu;
using Com.Gosol.Models.NghiepVu;
using Com.Gosol.VHTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.BUS.NghiepVu
{
    public class NV_LichSuThuGomBUS
    {
        private readonly NV_LichSuThuGomDAL _lichSuThuGomDAL;
        private readonly DM_Camera_ThungRacDAL _dM_Camera_ThungRacDAL;

        public NV_LichSuThuGomBUS()
        {
            _lichSuThuGomDAL = new NV_LichSuThuGomDAL();
            _dM_Camera_ThungRacDAL = new DM_Camera_ThungRacDAL();
        }

        // Lấy thông tin lịch sử thu gom theo ID
        public NV_LichSuThuGom GetById(int id)
        {
            return  _lichSuThuGomDAL.GetById(id);
        }

        public BaseResultModel Insert(string cameraCode)
        {
            var Result = new BaseResultModel();
            try
            {
                var data = _dM_Camera_ThungRacDAL.GetByCameraCode(cameraCode).FirstOrDefault();
                if (data == null)
                {
                    Result.Status = -1;
                    Result.Message = "Trash can not found";
                    return Result;
                }
                var lichSuThuGom = new NV_LichSuThuGom();
                lichSuThuGom.ThungRacID = data.ThungRacID;
                lichSuThuGom.ThoiGianThuGom = DateTime.Now;
                var results = _lichSuThuGomDAL.Insert(lichSuThuGom);
                results.Message = results.Status == 1 ? "Successfully!" : "Failure!";
                return results;
            }
            catch (Exception ex)
            {
                Result.Status = -1;
                Result.Message = ex.ToString();
                Result.Data = null;
            }
            return Result;
        }
    }

}
