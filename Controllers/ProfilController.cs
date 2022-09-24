using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using TfouFlash.Models;

namespace TfouFlash.Controllers;

public class ProfilController : Controller
{
    private readonly ILogger<ProfilController> _logger;


    public ProfilController(ILogger<ProfilController> logger)
    {
        _logger = logger;
    }

    [Route("profil/{*any}")]
    public IActionResult Xml()
    {
        //return Content("Valid routing for ID : " + ticketId);
        return File("/profil.xml", "text/xml");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
