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

    //////////

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

    public IActionResult editCadete(int dataId)
    {
        return View(laDBCadeteria.LaCadeteria.Cadetes.Find(x => x.Id_persona == dataId));

    }

    [HttpPost]
    public IActionResult editCadete(int dataId, string dataNombre, string dataTelefono, string dataDireccion)
    {
        Cadete selectCadete = laDBCadeteria.LaCadeteria.Cadetes.Find(x => x.Id_persona == dataId);
        selectCadete.Nombre = dataNombre;
        selectCadete.Telefono = dataTelefono;
        selectCadete.Direccion = dataDireccion;

        return RedirectToAction("Index");
    }

    //////////

    public IActionResult altaPedido()
    {
        return View(laDBCadeteria);

    }

    [HttpPost]
    public IActionResult altaPedido(string dataNombre, string dataTelefono, string dataDireccion, string dataReferencia, string dataObservaciones)
    {
        laDBCadeteria.PedidosSinAsignar.Add(new Pedido(id_pedido, dataObservaciones, 1, new Cliente(id_pedido, dataNombre, dataTelefono, dataDireccion, dataReferencia)));
        id_pedido++;

        return RedirectToAction("Index");
    }

    //////////

    public IActionResult Privacy()
    {
        return View(laDBCadeteria);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
