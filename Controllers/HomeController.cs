
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_Ahorcado.Models;
using Newtonsoft.Json; 

namespace TP_Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public IActionResult Comenzar(string username, int dificultad)
    {
        Juego juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Juego"));
      Usuario jugador = juego.Jugadores.FirstOrDefault(j => j.Nombre == username);
    ViewBag.jugador = jugador;

        if (juego == null || ViewBag.jugador == null)
        {
            Juego juego2 = new Juego();
            juego2.InicializarJuego(username, dificultad);
            HttpContext.Session.SetString("Juego", Objeto.ObjectToString(juego2));

            return View("Juego");
        }

     
        if (ViewBag.jugador != null)
        {

            return Json(new
            {
                existe = true,
                nombre = ViewBag.jugador.Nombre,
                intentos = ViewBag.jugador.CantidadIntentos,
                palabra = juego.PalabraActual

            });


            ViewBag.palabra = "palabra";
            ViewBag.username = "username";

            return View("Juego");
        }
        
        return View("Index");
    }
[HttpPost]public IActionResult FinJuego(int intentos)
{
        ViewBag.juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("juego"));
        ViewBag.intentos = intentos;
        ViewBag.juego.FinJuego(intentos);
        return View("Index");
}
    public IActionResult Index()
    {
      ViewBag.juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("juego"));
         
        ViewBag.Jugadores = ViewBag.juego.DevolverListaUsuarios(); 
        return View("Index");
    }
}
