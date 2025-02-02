using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// calclute area of hexagon with given lenth of side
        /// </summary>
        ///
        /// <param name="Side">Length of one side of hexagon</param>
        /// <returns>
        /// Area of hexagon as a double
        /// </returns>
        /// <exapmple>
        /// GET http://localhost:5005/api/Q6/hexagon?side=1
        /// response- 2.598076211353316
        /// GET http://localhost:5005/api/Q6/hexagon?side=1.5
        /// reponse- 5.845671475544961

        /// GET http://localhost:5005/api/Q6/hexagon?side=20
        /// response- 1039.2304845413264
        /// </exapmple>
        /// 
        //
        [HttpGet("hexagon")]
        public double hexagonArea(double Side)
        {
            double A = (3 * Math.Sqrt(3) / 2) * Math.Pow(Side, 2);
            return(A);
        }
    }
}
