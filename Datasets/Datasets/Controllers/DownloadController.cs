using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Datasets.Controllers
{
    public class DownloadController : Controller
    {
        [Obsolete]
        private IHostingEnvironment Environment;

        [Obsolete]
        public DownloadController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }

        /*

        [HttpGet]
        [Obsolete]
        // GET: /<controller>/
        public IActionResult DownloadDatasetFile(string id)
        {
            string path = Path.Combine(this.Environment.WebRootPath, "files/") + id;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "text/csv", id);

        }

        */

        [HttpGet]
        [Route("Download")]
        [Obsolete]
        public ActionResult DownloadDatasetFile(string id)
        {
            var folder = Path.Combine(this.Environment.WebRootPath, "files");
            var filePath = Path.Combine(folder, id);
            if (!System.IO.File.Exists(filePath))
                return NotFound();

            var memory = new MemoryStream();
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                stream.CopyToAsync(memory);
            }
            memory.Position = 0;

            return File(memory, "text/csv", id);
        }

        [Obsolete]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var uploadPath = Path.Combine(this.Environment.WebRootPath, "uploadsfolder");

            using (var fileStream = new FileStream(Path.Combine(uploadPath, file.FileName), FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return RedirectToAction("Index");
        }

        private Dictionary<string, string> GetMimeTypes()
        {
        return new Dictionary<string, string>
        {
        { ".txt", "text/plain"},
        { ".csv", "text/csv"}
            };
        }
    }
}
