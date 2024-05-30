using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.MiPaquete= ORTWorld.Paquetes;
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

    public IActionResult SelectPaquete()
    {
        ViewBag.ListaDestinos=ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles= ORTWorld.ListaHoteles;
        return View();
    }
    
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion)
    {
        if(Destino != null && Hotel != null && Aereo != null && Excursion != null)
        {
            Paquete paquete = new Paquete( ORTWorld.ListaHoteles[Hotel], ORTWorld.ListaAereos[Aereo], ORTWorld.ListaExcursiones[Excursion]);
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino],paquete);
            ViewBag.Excursiones=ORTWorld.ListaExcursiones;
            return View("Index");
        }
        else
        {
            ViewBag.MensajeError = "Los datos cargados son incorrectos";
            return View("SelectPaquete");
        }
        
    }
}
