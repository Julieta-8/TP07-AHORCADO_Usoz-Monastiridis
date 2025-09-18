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

    Juego.InicializarJuego(username, dificultad);
   HttpContext.Session.SetString("User", username.ToString());
  
string palabra =  CargarPalabra(dificultad);
   
     ViewBag.palabra = "palabra";
        ViewBag.username = "username";
        return View("Index");
    }
[HttpPost]public IActionResult FinJuego(int intentos)
{
        ViewBag.intentos = "intentos";
        Juego.FinJuego(intentos);
        return View("Index");
}
    public IActionResult Index()
    {
        ViewBag.Jugadores = Juego.DevolverListaUsuarios(); 
        return View();
    }
}
