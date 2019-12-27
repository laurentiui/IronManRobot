using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webserver.Models;

namespace webserver.Controllers
{
    public class RobotController : Controller
    {
        private readonly ILogger<TestController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public RobotController(ILogger<TestController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Build()
        {
            return View();
        }

        public IActionResult Manage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile fileToUpload, string partname)
        {
            var model = new TestModel();

            if (fileToUpload == null)
            {
                model.Error = $"You did not upload any file";
                return View(model);
            }

            string fileName = fileToUpload.FileName;
            string uniqueFileName = "";

            try
            {
                uniqueFileName = GetUniqueFileName(fileName);
            }
            catch (System.Exception ex)
            {
                model.Error = $"Can not upload {fileName} to {uniqueFileName}: {ex}";
                return View(model);
            }

            using (var stream = System.IO.File.Create(uniqueFileName))
            {
                await fileToUpload.CopyToAsync(stream);
            }

            model.FileName = uniqueFileName;

            //return View("Manage", new Models.ErrorViewModel);
        }

        private string GetUniqueFileName(string fileName)
        {
            string rootPath = _webHostEnvironment.ContentRootPath;

            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            //Returns the extension (including the period ".") of the specified path string.
            string extension = Path.GetExtension(fileName);

            int index = 0;
            while (index < 50)
            {
                string newFileName = $"{rootPath}/_files/{fileNameWithoutExtension}_{index}{extension}";
                if (!System.IO.File.Exists(newFileName))
                {
                    return newFileName;
                }
                index++;
            }

            throw new Exception("threashhold exceed. please delete some files");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
