using calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }




        [HttpPost]
        public IActionResult Index(Calculator calculator)
        {

            if (calculator.calculate == "*")
            {
                calculator.result = calculator.value1 * calculator.value2;
            }
            else
            {
                calculator.result = calculator.value1 + calculator.value2;
            }
           

            ViewData["result"] = calculator.result;

            return View();
        }

        public IActionResult Privacy()
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