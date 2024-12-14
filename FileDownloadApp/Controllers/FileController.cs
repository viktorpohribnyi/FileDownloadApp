using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace FileDownloadApp.Controllers
{
    public class FileController : Controller
    {
        [HttpGet("")]
        [HttpGet("File/DownloadFile")]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost("File/DownloadFile")]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                fileName = "output.txt";
            }

            string fileContent = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            byte[] fileBytes = Encoding.UTF8.GetBytes(fileContent);

            return File(fileBytes, "text/plain", fileName);
        }
    }
}
