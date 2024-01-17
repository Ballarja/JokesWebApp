using Microsoft.AspNetCore.Mvc;

namespace JokesWebApp.Controllers;

public class JokesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}