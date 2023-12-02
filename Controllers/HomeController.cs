using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lazzerini.davide._5i.primaWeb.Models;

namespace lazzerini.davide._5i.primaWeb.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public IActionResult Prenota(){
        return View();
    }

    [HttpPost]
     public IActionResult Prenota(Prenotazione p){
        return View();
    }
}
