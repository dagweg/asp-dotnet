using System.Diagnostics;
using asp_dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_dotnet.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        // int hour = DateTime.Now.Hour;
        // string greeting = hour > 12 ? "Good Morning" : "Good Afternoon";
        // return View("MyView", greeting);
        return View();
    }

    public ViewResult Rspvform() => View();
}
