using Microsoft.AspNetCore.Mvc;

namespace ReadCycle.Controllers;

public class OrderController : Controller
{
    // GET
    public IActionResult RegisterOrder()
    {
        return View();
    }
}