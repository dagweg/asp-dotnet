using System.Diagnostics;
using asp_dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_dotnet.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Rspvform() {
        return View();
    }

    [HttpPost]
    public IActionResult Rspvform(GuestResponse guestResponse) {
        Repository.AddResponse(guestResponse);
        return View("Thanks", guestResponse);
    }

    public IActionResult ListResponses(){
        return View(Repository.Response.Where(r => r.WillAttend == true));
    }
}
