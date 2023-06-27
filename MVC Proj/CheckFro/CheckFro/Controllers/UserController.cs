using CheckFro.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckFro.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserModel y)
        {
            ViewBag.name = y.name;
            ViewBag.tea = y.tea;
            ViewBag.coffee = y.coffee;
            ViewBag.breakfast = y.breakfast;
            return View();
        }
    }
}
