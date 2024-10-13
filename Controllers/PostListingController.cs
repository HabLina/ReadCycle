using Microsoft.AspNetCore.Mvc;

namespace ReadCycle.Controllers;

public class PostListingController : Controller
{
    // GET
    public IActionResult AddPost()
    {
        return View();
    }
}