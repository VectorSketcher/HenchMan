using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HenchMan.Controllers
{
    [Produces("application/json")]
    
    public class PingController : Controller
    {
        [HttpGet]
        [Route("api/Ping")]
        public IActionResult Ping()
        {
            return Ok("pong!!");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}