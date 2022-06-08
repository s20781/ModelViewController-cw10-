using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ModelViewController.Controllers
{
    public class HomeController1 : Controller
    {

        [HttpGet("HelloWorld")]
        public string Index(string name, int numTimes= 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Welcome")]
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
        
    
}
