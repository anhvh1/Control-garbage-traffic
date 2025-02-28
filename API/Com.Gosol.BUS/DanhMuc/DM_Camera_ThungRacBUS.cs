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
    public class DM_Camera_ThungRacBUS
    {
        private readonly DM_Camera_ThungRacDAL _cameraThungRacDAL;

        public DM_Camera_ThungRacBUS()
        {
            _cameraThungRacDAL = new DM_Camera_ThungRacDAL();
        }

        // Lấy thông tin DM_Camera_ThungRac theo ID
        public DM_Camera_ThungRac GetById(int id)
        {
            return _cameraThungRacDAL.GetById(id);
        }

        // Thêm mới DM_Camera_ThungRac
        public BaseResultModel Insert(DM_Camera_ThungRac cameraThungRac)
        {
            var result = new BaseResultModel();
            try
            {
                bool isInserted = _cameraThungRacDAL.Insert(cameraThungRac);
                if (isInserted)
                {
                    result.Status = 1;
                    result.Message = "Thêm mới thành công!";
                }
                else
                {
                    result.Status = -1;
                    result.Message = "Thêm mới thất bại!";
                }
            }
            catch (Exception ex)
            {
                result.Status = -1;
                result.Message = ex.ToString();
                result.Data = null;
            }
            return result;
        }

        // Cập nhật thông tin DM_Camera_ThungRac
        public BaseResultModel Update(DM_Camera_ThungRac cameraThungRac)
        {
            var result = new BaseResultModel();
            try
            {
                bool isUpdated = _cameraThungRacDAL.Update(cameraThungRac);
                if (isUpdated)
                {
                    result.Status = 1;
                    result.Message = "Cập nhật thành công!";
                }
                else
                {
                    result.Status = -1;
                    result.Message = "Cập nhật thất bại!";
                }
            }
            catch (Exception ex)
            {
                result.Status = -1;
                result.Message = ex.ToString();
                result.Data = null;
            }
            return result;
        }

        // Xóa DM_Camera_ThungRac theo ID
        public BaseResultModel Delete(int id)
        {
            var result = new BaseResultModel();
            try
            {
                bool isDeleted = _cameraThungRacDAL.Delete(id);
                if (isDeleted)
                {
                    result.Status = 1;
                    result.Message = "Xóa thành công!";
                }
                else
                {
                    result.Status = -1;
                    result.Message = "Xóa thất bại!";
                }
            }
            catch (Exception ex)
            {
                result.Status = -1;
                result.Message = ex.ToString();
                result.Data = null;
            }
            return result;
        }

        // Lấy tất cả các bản ghi DM_Camera_ThungRac
        public List<DM_Camera_ThungRac> GetAll()
        {
            return _cameraThungRacDAL.GetAll();
        }

        public List<DM_Camera_ThungRacRespone> GetByCameraCode(string maCamera)
        {
            try
            {
                var result = _cameraThungRacDAL.GetByCameraCode(maCamera);
                return result;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                throw new Exception("An error occurred in the business logic.", ex);
            }
        }
    }

}
