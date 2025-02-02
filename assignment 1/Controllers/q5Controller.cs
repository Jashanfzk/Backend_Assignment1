using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// accept an integer secret and return a message revealing the secret 
        /// </summary>
        /// <param name="secret"> This is an int representing secret</param>
        /// <returns>
        /// string message reveal the secret
        /// </returns>
        /// <example> 
        /// curl -H "Content-Type: application/json" -d "5" http://localhost:5005/api/q5/secret
        /// response- the secret is 5
        /// curl -H "Content-Type: application/json" -d "-200" http://localhost:5005/api/q5/secret
        /// response- the secret is -200
        /// </example>
        [HttpPost("secret")]
        public string Secret([FromBody] int secret)
        {
            string mess_= "Shh..the secret is" + secret;
            return mess_;
        }
    }
}
