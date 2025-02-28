using Com.Gosol.BUS.DanhMuc;
using Com.Gosol.BUS.NghiepVu;
using Com.Gosol.Models;
using Com.Gosol.VHTT.API.Formats;
using Com.Gosol.VHTT.BUS.HeThong;
using Com.Gosol.VHTT.Models;
using Com.Gosol.VHTT.Models.HeThong;
using Com.Gosol.VHTT.Ultilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;
using System.Text;

namespace GO.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class NxLogController : ControllerBase
    {
        private readonly SystemLogBUS _systemLogBUS;
        private readonly DM_CameraBUS dM_CameraBUS;
        private readonly NV_SuKienVutRacBUS nV_SuKienVutRacBUS;
        private readonly NV_LichSuThuGomBUS nV_LichSuThuGomBUS;
        private readonly IHubContext<MapHub> _hubContext;
        public NxLogController(IHubContext<MapHub> hubContext)
        {
            _systemLogBUS = new SystemLogBUS();
            dM_CameraBUS = new DM_CameraBUS();
            nV_SuKienVutRacBUS = new NV_SuKienVutRacBUS();
            nV_LichSuThuGomBUS = new NV_LichSuThuGomBUS();
            _hubContext = hubContext;
        }


        [HttpPost]
        [Route("Log")]
        public async Task<IActionResult> LogResponse([FromBody] NXCamera request)
        {
            try
            {
                var model = new SystemLogModel();
                model.CanBoID = 1;
                model.LogInfo = request.Code + " | " + request.Type;
                model.LogType = 1;
                model.LogTime = DateTime.Now;
                _systemLogBUS.Insert(model);
            }
            catch (Exception ex)
            {
            }

            if (request == null || request.Type == 0)
            {
                return BadRequest("Invalid input data.");
            }
            else
            {
                try
                {
                    var respones = dM_CameraBUS.GetByCode(request.Code);
                    if (respones == null)
                    {
                        return BadRequest("Can't find the camera");
                    }
                    else
                    {
                        var result = new BaseResultModel();
                        if (request.Type == EnumNxLogType.VutRac.GetHashCode())
                            result = nV_SuKienVutRacBUS.Insert(request.Code);
                        else if (request.Type == EnumNxLogType.ThuGomRac.GetHashCode())
                            result = nV_LichSuThuGomBUS.Insert(request.Code);
                        else
                            return BadRequest("Can't find value");

                        //// Sau khi cập nhật DB, gửi dữ liệu cập nhật đến các clients

                        var updatedTrashData = dM_CameraBUS.GetAll();
                        foreach (var item in updatedTrashData)
                        {
                            item.LoaiThayDoi = item.ID == respones.ID ? request.Type : 0;
                        }
                        var data = new
                        {
                            data = updatedTrashData
                        };

                        await _hubContext.Clients.All.SendAsync("ReceiveTrashUpdate", data);

                        return Ok(result.Message);
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
        }
    }
}
