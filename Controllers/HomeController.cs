
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
    [HttpPost]
    public IActionResult Comenzar(string username, int dificultad)
    {
        Juego juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Juego"));

        if (juego == null)
        {
            Juego juego2 = new Juego();
            juego2.InicializarJuego(username, dificultad);
            HttpContext.Session.SetString("Juego", Objeto.ObjectToString(juego));


        }

          Usuario jugador = juego.Jugadores.FirstOrDefault(j => j.Nombre == username);
    ViewBag.jugador = jugador;

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

            return View("Index");
        }
         else
    {
        // Si no existe, crear el nuevo jugador y agregarlo
        ViewBag.jugador = new Usuario(username, 0); 
        juego.Jugadores.Add(ViewBag.jugador);

        // Guardar el juego actualizado en sesión
        HttpContext.Session.SetString("Juego", Objeto.ObjectToString(juego));

        // Mandar datos a la vista
        ViewBag.palabra = juego.PalabraActual;
        ViewBag.username = ViewBag.jugador.Nombre;
        ViewBag.intentos = ViewBag.jugador.CantidadIntentos;

        return View("Index");
    }
    }
[HttpPost]public IActionResult FinJuego(int intentos)
{
        ViewBag.juego = Objeto.StringToObject<Usuario>(HttpContext.Session.GetString("Juego"));
        ViewBag.intentos = "intentos";
        ViewBag.juego.FinJuego(intentos);
        return View("Index");
}
    public IActionResult Index()
    {
        ViewBag.juego = Objeto.StringToObject<Usuario>(HttpContext.Session.GetString("Juego"));
         
        ViewBag.Jugadores = ViewBag.juego.DevolverListaUsuarios(); 
        return View();
    }
}
