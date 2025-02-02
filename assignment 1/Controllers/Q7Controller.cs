using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// adjust current date by a specific number of days 
        /// </summary>
        /// <param name="days">o. of days to add or subtract from today</param>
        /// <returns> adjust date in "yyyy-MM-dd"</returns>
        /// <exapmle>
        /// GET http://localhost:5005/api/Q7/timemachine?days=1
        /// response- 2025-02-02
        /// GET http://localhost:5005/api/Q7/timemachine?days=-1
        /// </exapmle> response - 2025-01-31
        [HttpGet("timemachine")]
        public string Timetravel(int days)
        {
            DateTime newDate = DateTime.Today.AddDays(days);
            return newDate.ToString("yyyy-MM-dd");
        }

    }
}


