using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using TfouFlash.Models;

namespace TfouFlash.Controllers;

public class TikiIslandController : Controller
{
    private readonly ILogger<TikiIslandController> _logger;


    public TikiIslandController(ILogger<TikiIslandController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("niveaux/{niveau}")]
    public IActionResult Niveaux(string niveau)
    {
        var path = "/swf/tiki-island/niveaux/" + niveau;
        return File(path, "application/x-shockwave-flash");
    }

    public IActionResult Game()
    {
        var path = "/swf/tiki-island/game-10626298rmpsu.swf";
        return File(path, "application/x-shockwave-flash");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
