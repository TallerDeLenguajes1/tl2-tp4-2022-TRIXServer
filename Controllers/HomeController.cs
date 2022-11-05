using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tl2_tp4_2022_TRIXServer.Models;

namespace tl2_tp4_2022_TRIXServer.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    DBCadeteria laDBCadeteria = CadeteriaUniversal.instancia;

    static int id_cadete = 1;
    static int id_pedido = 1;

    public IActionResult Index()
    {
        return View(laDBCadeteria);
    }

    public IActionResult altaCadete()
    {
        return View(laDBCadeteria);
    }

    [HttpPost]
    public IActionResult altaCadete(string dataNombre, string dataTelefono, string dataDireccion)
    {
        laDBCadeteria.LaCadeteria.Cadetes.Add(new Cadete(id_cadete, dataNombre, dataTelefono, dataDireccion));
        id_cadete++;

        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
