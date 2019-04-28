using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace H2.Oefening1.Web.Controllers
{
    public class ReponseTypesController : Controller
    {
        public IActionResult Index()
        {
            return Content("Shan Saddiqui", "text/plain");
        }
        public IActionResult Fail()
        {
            return NotFound();
        }

        public IActionResult File()
        {
            string path = "wwwroot/";
            byte[] fileBytes = System.IO.File.ReadAllBytes(path + "Oefeningen1.pptx");
            string fileName = "Oefeningen1.pptx";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public IActionResult Forward()
        {
            return Redirect("https://localhost:44304/ReponseTypes/File");
        }
    }
}