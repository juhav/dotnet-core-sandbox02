using Microsoft.AspNetCore.Mvc;
using System;

namespace ConsoleApplication
{
    [Route("api/ping")]
    public class PingController : Controller
    {
        public PingController()
        {

        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return new ObjectResult(new {
                Timestamp = DateTime.Now.ToString("yyyyMMdd HH:mm:ss"),
                Id = id 
            });
        }
    }
}