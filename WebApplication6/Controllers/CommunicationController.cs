using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommunicationController : ControllerBase
    {
        private Communication _option;

        public CommunicationController(IOptionsSnapshot<Communication> options)
        {
            _option = options.Value;
        }

        [HttpGet]
        public  IActionResult Get(string GridHtml)
        {
            var x = _option.CommunicationBaseURL;
            return Ok();
          
        }
    }
}
