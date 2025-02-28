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
    public class NV_SuKienVutRacBUS
    {
        private readonly NV_SuKienVutRacDAL _suKienVutRacDAL;
        private readonly DM_Camera_ThungRacDAL _dM_Camera_ThungRacDAL;

        public NV_SuKienVutRacBUS()
        {
            _suKienVutRacDAL = new NV_SuKienVutRacDAL();
            _dM_Camera_ThungRacDAL = new DM_Camera_ThungRacDAL();
        }

        // Lấy thông tin sự kiện vứt rác theo ID
        public NV_SuKienVutRac GetById(int id)
        {
            return _suKienVutRacDAL.GetById(id);
        }

        // Lấy tất cả các sự kiện vứt rác
        public List<NV_SuKienVutRac> GetAll()
        {
            return _suKienVutRacDAL.GetAll();
        }

        // Thêm mới sự kiện vứt rác
        public BaseResultModel Insert(string cameraCode)
        {
            var suKienVutRac = new NV_SuKienVutRac();
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
                suKienVutRac.CameraID = data.CameraID;
                suKienVutRac.ThungRacID = data.ThungRacID;
                suKienVutRac.ThoiGianVut = DateTime.Now;

                var results = _suKienVutRacDAL.Insert(suKienVutRac);
                Result.Status = results ? 1 : 0;
                Result.Message = results ? "Successfully!" : "Failure!";
                Result.Data = null;
            }
            catch (Exception ex)
            {
                Result.Status = -1;
                Result.Message = ex.ToString();
                Result.Data = null;
            }
            return Result;
        }

        // Cập nhật sự kiện vứt rác
        public BaseResultModel Update(NV_SuKienVutRac suKienVutRac)
        {
            var Result = new BaseResultModel();
            try
            {
                var results = _suKienVutRacDAL.Update(suKienVutRac);
                Result.Status = results ? 1 : 0;
                Result.Message = results ? "Cập nhật thành công!" : "Cập nhật thất bại!";
                Result.Data = null;
            }
            catch (Exception ex)
            {
                Result.Status = -1;
                Result.Message = ex.ToString();
                Result.Data = null;
            }
            return Result;
        }

        // Xóa sự kiện vứt rác theo ID
        public BaseResultModel Delete(int id)
        {
            var Result = new BaseResultModel();
            try
            {
                var results = _suKienVutRacDAL.Delete(id);
                Result.Status = results ? 1 : 0;
                Result.Message = results ? "Xóa thành công!" : "Xóa thất bại!";
                Result.Data = null;
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
