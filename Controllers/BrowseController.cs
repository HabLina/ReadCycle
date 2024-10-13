using Microsoft.AspNetCore.Mvc;

namespace ReadCycle.Controllers;

public class BrowseController : Controller
{
    // GET
    public IActionResult BrowseFeed()
    {
        return View();
    }
}