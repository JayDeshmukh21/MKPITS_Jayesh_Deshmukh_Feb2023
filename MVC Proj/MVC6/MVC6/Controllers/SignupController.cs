using Microsoft.AspNetCore.Mvc;
using MVC6.Models;

namespace MVC6.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Signup(SignupModel x)
        {
            ViewBag.username = x.username;
            ViewBag.password = x.password;
            return View();
        }
    }
}
