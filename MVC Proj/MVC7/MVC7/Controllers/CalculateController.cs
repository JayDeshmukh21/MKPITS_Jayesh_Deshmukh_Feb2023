using Microsoft.AspNetCore.Mvc;
using MVC7.Models;

namespace MVC7.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calculate(CalculateModel xy)
        {
            int n1 = xy.num1;
            int n2 = xy.num2;
            int res = n1 + n2;
            ViewBag.result = res;
            return View();
        }
    }
}
