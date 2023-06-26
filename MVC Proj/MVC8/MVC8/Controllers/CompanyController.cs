using Microsoft.AspNetCore.Mvc;
using MVC8.Models;

namespace MVC8.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CompanyModel c)
        {
            ViewBag.empid = c.empid;
            ViewBag.empname = c.empname;
            ViewBag.empsalary = c.empsalary;
            ViewBag.designation = c.designation;
            ViewBag.empbonus = c.empbonus;
            
            int totalsalary;
            if(c.designation =="manager")
            {
                c.empbonus = 10000;
                ViewBag.totalsalary = 10000 + c.empsalary;
            }
            else if(c.designation =="clerk")
            {
                c.empbonus = 5000;
                ViewBag.totalsalary = 5000 + c.empsalary;
            }
            else if (c.designation =="peon")
            {
                c.empbonus = 1000;
                ViewBag.totalsalary = 1000 + c.empsalary;
            }
            return View();
        }
    }
}
