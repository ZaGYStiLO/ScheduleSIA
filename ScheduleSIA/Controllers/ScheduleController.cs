using ScheduleSIA.Data;
using ScheduleSIA.Services;
using Microsoft.AspNetCore.Mvc;

namespace ScheduleSIA.Controllers
{
    [ApiController]
    [Route("api/schedule")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _service;
        public ScheduleController(IScheduleService service, AppDbContext db)
        {
            _service = service;
        }

        [HttpGet("group/{grounName}")]

        public async Task<IActionResult> GetSchedule(string grounName, DateTime start, DateTime end)
        {
            var result = await _service.GetScheduleForGroup(grounName, start.Date, end.Date);
            return Ok(result);
        }
    }
}
