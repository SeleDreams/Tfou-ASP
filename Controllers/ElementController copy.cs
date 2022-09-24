using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using TfouFlash.Models;

namespace TfouFlash.Controllers;

public class ElementController : Controller
{
    private readonly ILogger<ElementController> _logger;


    public ElementController(ILogger<ElementController> logger)
    {
        _logger = logger;
    }

    [Route("element/web/element_id/{element_id}/format/flash")]
    public IActionResult Element(string element_id)
    {
        //return Content("Valid routing for ID : " + ticketId);
        return File("/element/web/element_id/" + element_id + "/format/flash", "image/png");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
