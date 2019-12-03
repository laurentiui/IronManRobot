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
    public class FilesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public FilesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string partName)
        {
            var model = new FilesModel();
            if (string.IsNullOrEmpty(partName)){
                model.ErrorMesage = "No part selected";
            }
            return View(model);
        }


    }
}
