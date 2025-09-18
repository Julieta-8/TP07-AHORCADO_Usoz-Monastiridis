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

    public IActionResult Index()
    {
        return View();
    }
}
