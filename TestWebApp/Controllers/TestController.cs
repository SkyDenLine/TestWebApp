using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery]Filters filters)
        {
            return Ok(new { sum = filters.Sum });
        }
        
        public IActionResult Post([FromBody] Filters filters) 
        {
            return Ok(new { text = filters.Sum });
        }
    }

  
}
