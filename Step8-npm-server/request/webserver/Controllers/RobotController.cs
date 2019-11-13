using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webserver.Models;

namespace webserver.Controllers
{
    public class RobotController : Controller
    {
        private readonly ILogger<RobotController> _logger;

        public RobotController(ILogger<RobotController> logger)
        {
            _logger = logger;
        }

        public IActionResult Build()
        {
            return View();
        }

        public IActionResult Manage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
