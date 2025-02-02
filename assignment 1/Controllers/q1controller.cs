using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1controller : ControllerBase
    {
        /// <summary>
        /// returns with welcome message when accessed via get request
        /// </summary>
        /// <returns>
        /// Inn this string contains a welcome message
        /// </returns>
        /// <example>
        /// Get/api/welcome - welcome to 5125!
        /// </example>

        [HttpGet("welcome")]
        public string get()
        {
            return "welcome to 5125!";
        }
    }
}
