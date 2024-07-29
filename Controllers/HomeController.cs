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
    public IActionResult Inicio()
    {
        return View();
    }

    public IActionResult Victoria()
    {
        return View();
    }
    public IActionResult Creditos()
    {
        return View();
    }
    
    public IActionResult Comenzar()
    {
        string habitacion = "habitacion" +  Escape.GetEstadoJuego();
        return View (habitacion);
    }
    public IActionResult Habitacion(int sala, string clave){
        if(sala != Escape.GetEstadoJuego()){
            return View("habitacion" + Escape.GetEstadoJuego());
        }else{
            if(Escape.ResolverSala(sala, clave)){
                return View("habitacion" +  Escape.GetEstadoJuego());
            }
            else if(sala == 4){
                return View("Victoria");
            }
            else{
                ViewBag.Error="ERROR";
                return View("habitacion" +  Escape.GetEstadoJuego());
            }
        }
    }

    public IActionResult Habitacion1(){
        return View();
    }
    public IActionResult Habitacion2(){
        return View();
    }
    public IActionResult Habitacion3(){
        return View();
    }
    public IActionResult Habitacion4(){
        return View();
    }
}
