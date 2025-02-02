using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// Return greeting message based on given name
        /// </summary>
        /// <param>name="Garry/Renne"</param>
        /// <returns> 
        /// Return with string containing a greeting message
        /// </returns>
        /// <example> request 
        ///  GET http://localhost:5005/api/q2/greeting?name=Gary
        ///  Respomse -Hi Gary!
        ///  GET http://localhost:5005/api/q2/greeting?name=Ren%C3%A9e
        ///  Response- Hi Renée!
        /// </example>
        [HttpGet("greeting")]
        public string Greetings(string name)
        {
            {
                return ("Hi " + name+ "!");
            }

        }
    }
}
