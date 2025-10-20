using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UD7ejercicio1.Models;
using UD7ejercicio1.Models.Entities;
using UD7ejercicio1.Models.DAL;

namespace UD7ejercicio1.Controllers
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
            if (DateTime.Now.Hour < 12)
            {
                ViewData["Greeting"] = "buenos dias!";
            }
            else if (DateTime.Now.Hour < 20)
            {
                ViewData["Greeting"] = "buenas tardes!";
            }
            else
            {
                ViewData["Greeting"] = "buenas noches!";
            }

            ViewBag.Date = DateTime.Now.ToLongDateString();
            Persona Alvaro= new Persona(1, "Alvaro", "Marquez", 23);
            return View(Alvaro);
        }

        public IActionResult listadoPersonas()
        {
            var listado = ListadoPersonas.GetListado();
            return View(listado);
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
