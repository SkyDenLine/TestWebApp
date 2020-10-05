using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Controllers
{
    [Route("[controller]")]

    public class SecondController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Conflict();
        }

    }
}
