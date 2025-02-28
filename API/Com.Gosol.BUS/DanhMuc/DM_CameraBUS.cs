using Com.Gosol.DAL.DanhMuc;
using Com.Gosol.Models.DanhMuc;
using Com.Gosol.VHTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.BUS.DanhMuc
{
    public class DM_CameraBUS
    {
        private readonly DM_CameraDAL _cameraDAL;

        public DM_CameraBUS()
        {
            _cameraDAL = new DM_CameraDAL();
        }

        // Lấy thông tin camera theo ID
        public DM_Camera GetById(int id)
        {
            return _cameraDAL.GetById(id);
        }

        public DM_Camera GetByCode(string code)
        {
            return _cameraDAL.GetByCode(code);
        }

        // Lấy tất cả các camera
        public List<DM_Camera_ThungRacRespone> GetAll()
        {
            return _cameraDAL.GetAll();
        }

        // Thêm mới camera
        public BaseResultModel Insert(DM_Camera camera)
        {
            var result = new BaseResultModel();
            try
            {
                var results = _cameraDAL.Insert(camera);
                result.Status = results ? 1 : 0;
                result.Message = results ? "Thêm mới camera thành công!" : "Thêm mới camera thất bại!";
                result.Data = null;
            }
            catch (Exception ex)
            {
                result.Status = -1;
                result.Message = ex.ToString();
                result.Data = null;
            }
            return result;
        }

        // Cập nhật camera
        public BaseResultModel Update(DM_Camera camera)
        {
            var result = new BaseResultModel();
            try
            {
                var results = _cameraDAL.Update(camera);
                result.Status = results ? 1 : 0;
                result.Message = results ? "Cập nhật camera thành công!" : "Cập nhật camera thất bại!";
                result.Data = null;
            }
            catch (Exception ex)
            {
                result.Status = -1;
                result.Message = ex.ToString();
                result.Data = null;
            }
            return result;
        }

        // Xóa camera theo ID
        public BaseResultModel Delete(int id)
        {
            var result = new BaseResultModel();
            try
            {
                var results = _cameraDAL.Delete(id);
                result.Status = results ? 1 : 0;
                result.Message = results ? "Xóa camera thành công!" : "Xóa camera thất bại!";
                result.Data = null;
            }
            catch (Exception ex)
            {
                result.Status = -1;
                result.Message = ex.ToString();
                result.Data = null;
            }
            return result;
        }
    }

}
