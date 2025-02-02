using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace assignment_1.Controllers
{/// <summary>
/// calculate the total cost including tax for a given number of smalll and large item
/// </summary>
/// 
/// return
/// 


    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        [HttpGet("squashfellows")]
        public string total([FromForm] int small, [FromForm] int large)
        {
            double smallPrice = 25.50;
            double largePrice = 40.50;
            double taxrate = 0.13;

            double smallTotal = small * smallPrice;
            double largeTotal = large * largePrice;
            double subtotal = smallTotal + largeTotal;
            double total = subtotal * (1 + 0.13);
            double tax = taxrate * subtotal;


            return /// couldn't understands how to return  multiple value .
}
