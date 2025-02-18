using Com.Gosol.Models;
using Com.Gosol.VHTT.API.Formats;
using Com.Gosol.VHTT.BUS.HeThong;
using Com.Gosol.VHTT.Models.HeThong;
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
        private SystemLogBUS _SystemLogBUS;
        
        [HttpPost]
        [Route("Log")]
        public async Task<IActionResult> LogMessage([FromBody] NXCamera request)
        {
            _SystemLogBUS = new SystemLogBUS();
            if (request == null || string.IsNullOrWhiteSpace(request.Message) || string.IsNullOrWhiteSpace(request.Ip))
            {
                return BadRequest("Invalid input data.");
            }

            try
            {
                var model = new SystemLogModel();
                model.CanBoID = 1;
                model.LogInfo = request.Ip + " | " + request.Message;
                model.LogType = 1;
                model.LogTime = DateTime.Now;
                _SystemLogBUS.Insert(model);
                return Ok("Log written successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error writing log: {ex.Message}");
            }
        }
    }
}
