using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {/// <summary>
     /// returns cube of the number that are passed
     /// </summary>
     /// <param> name="Base"</param>
     /// <returns> Return a int that is a cube of provided int
     /// </returns>
     /// /// <example> 
     /// GET http://localhost:5005/api/q3/cube/4
     /// response 64
     /// GET http://localhost:5005/api/q3/cube/-4
     /// Respobse -64
     /// GET http://localhost:5005/api/q3/cube/10
     /// Response 1000
     /// </example>
     /// 
        [HttpGet("cube/{base}")]
        public int cube_(int Base)
        {
            int answer = Base * Base * Base;
            return answer;
        }

    }
}
