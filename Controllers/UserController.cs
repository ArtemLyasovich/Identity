using Microsoft.AspNetCore.Mvc;

namespace EventCalendar.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        if (User.Identity.IsAuthenticated)
        {
            ViewBag.UserName = User.Identity.Name;
        }

        return View();
    }
}