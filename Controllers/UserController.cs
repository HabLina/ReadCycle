using Microsoft.AspNetCore.Mvc;

namespace ReadCycle.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult DisplayUserProfile()
    {
        return View();
    }
}