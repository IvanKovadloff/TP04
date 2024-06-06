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
        ViewBag.Paquetes= ORTWorld.Paquetes;
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
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        return View();
    }
    
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion)
    {
        string hotelElegido = ORTWorld.ListaHoteles[Hotel-1];
        string aereoElegido = ORTWorld.ListaAereos[Aereo-1];
        string excursionElegido = ORTWorld.ListaExcursiones[Excursion-1];

            Paquete paquete = new Paquete(hotelElegido,aereoElegido,excursionElegido);
            
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1],paquete);
            return RedirectToAction("Index");
            

    }
}
