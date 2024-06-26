using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MammaMia.Models;

namespace MammaMia.Controllers;

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
    public IActionResult Tutorial()
    {
        return View();
    }
    public IActionResult Comenzar()
    {
        string habitacion = "habitacion" +  Escape.GetEstadoJuego();
        return View (habitacion);
    }
}
