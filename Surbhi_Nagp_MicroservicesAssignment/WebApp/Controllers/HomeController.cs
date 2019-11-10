using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        ConfigSettings configSettings { get; set; }
        CustomerClient client { get; set; }

        public HomeController(IOptions<ConfigSettings> settings, CustomerClient customerClient)
        {
            configSettings = settings.Value;
            client = customerClient;
        }

        public IActionResult Index()
        {
            string data = client.Execute();
            return Content(data);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
