using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prueba.Models;

namespace Prueba.Controllers
{
    
    public class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet("api")]
        [HttpGet("api/Index")]
        [HttpGet("api/Index/{id?}")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("api/privacy")]
        [Route("api/privacy/{id?}")]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
