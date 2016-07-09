using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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
            List<Configuration> result;

            using (var db = new MyDbContext())
            {
                db.Configuration.Add(new Configuration() {
                    Key = DateTime.Now.ToString("yyyyMMdd HH:mm:ss"),
                    Value = DateTime.Now.ToString("yyyyMMddHHmmss"),
                });

                db.SaveChanges();

                result = db.Configuration.AsNoTracking().ToList();
            }
            return new ObjectResult(result);
        }
    }
}