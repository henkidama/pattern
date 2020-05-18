using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebPattern.Classes;
using WebPattern.Interfaces;

namespace WebPattern.Controllers
{
    [ApiController]
    [Route("api/Pattern")]
    public class PatternController : ControllerBase
    {
        private readonly IEncoding _encoding;

        public PatternController(IEncoding encoding)
        {
            _encoding = encoding;
        }

        [HttpGet("{pattern}")]
        public JsonResult Variables(string pattern)
        {
            return new JsonResult(_encoding.Encode(pattern));
        }
    }
}
