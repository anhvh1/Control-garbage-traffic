using Com.Gosol.BUS.DanhMuc;
using Com.Gosol.Models.DanhMuc;
using Com.Gosol.VHTT.API.Authorization;
using Com.Gosol.VHTT.API.Formats;
using Com.Gosol.VHTT.Models;
using Com.Gosol.VHTT.Security;
using Com.Gosol.VHTT.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace GO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameraController : Controller
    {
        private readonly DM_CameraBUS _cameraBUS;

        public CameraController()
        {
            _cameraBUS = new DM_CameraBUS();
        }

        // GET: api/Camera
        [HttpGet]
        [Route("GetPageCamera")]

        public ActionResult<List<DM_Camera>> GetCameras()
        {
            try
            {
                var cameras = _cameraBUS.GetAll();
                if (cameras == null || cameras.Count == 0)
                {
                    return NotFound("No cameras found.");
                }
                return Ok(cameras);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
