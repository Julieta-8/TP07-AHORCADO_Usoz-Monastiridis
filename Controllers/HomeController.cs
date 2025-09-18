using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_Ahorcado.Models;

namespace TP_Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
  [HttpPost]public IActionResult Comenzar(string username, int dificultad)
{
string palabra = ObtenerPalabraPorDificultad(dificultad);
   
          ViewBag.palabra = "palabra";
        ViewBag.username = "username";
        return View("Index");
    }
[HttpPost]public IActionResult FinJuego(int intentos)
{
        ViewBag.intentos = "intentos";
        return View("Index");
}
    public IActionResult Index()
    {
        return View();
    }
}
