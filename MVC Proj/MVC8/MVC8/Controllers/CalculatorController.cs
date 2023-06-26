using Microsoft.AspNetCore.Mvc;
using MVC8.Models;

namespace MVC8.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Calculator m)
        {
            ViewBag.result = m.result;
            ViewBag.num1 = m.num1;
            ViewBag.num2 = m.num2;
            char op;

            if(m.op =='+')
            {
                ViewBag.result = m.num1 + m.num2;
            }
            else if(m.op =='-')
            {
                ViewBag.result = m.num1 - m.num2;
            }
            else if(m.op == '*')
            {
                ViewBag.result = m.num1 * m.num2;
            }
            else if(m.op =='/')
            {
                ViewBag.result = m.num1 / m.num2;
            }
            return View();
        }
    }
}
