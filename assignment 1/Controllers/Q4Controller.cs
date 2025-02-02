using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Responds to a knock knock joke by asking whos there
        /// </summary>
        /// <returns>
        /// a string response who's there
        /// </returns>
        /// <example> 
        /// POST http://localhost:5005/api/q4/knockknock
        /// Response Who's there?
        /// </example>
        [HttpPost("KnockKnock")]
        public string Knockknock()
        {
            return "Who's there?";
        }
            


    }
}
