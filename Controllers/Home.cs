using Microsoft.AspNetCore.Mvc;
using System.Net;
using Windows.UI.Xaml;

namespace Portfolio.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DownloadCV()
        {
            string filePath = @"C:\Users\Admin\Desktop\CV-HUỲNH-VĂN-HIỆP-Intern.pdf";

            if (System.IO.File.Exists(filePath))
            {
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

                string contentType = "application/pdf";

                string fileName = "CV.pdf";

                return File(fileBytes, contentType, fileName);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
