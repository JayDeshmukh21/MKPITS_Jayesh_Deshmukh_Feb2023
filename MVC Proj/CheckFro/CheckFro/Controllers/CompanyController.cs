using CheckFro.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckFro.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CompanyModel r)
        {
            ViewBag.empname = r.empname;
            ViewBag.desig = r.desig;
            ViewBag.basicsal = r.basicsal;
            ViewBag.ta = r.ta;
            ViewBag.da = r.da;
            ViewBag.hra = r.hra;
            ViewBag.totalsal = r.totalsal;

            if(r.desig == "manager" )
            {
                ViewBag.ta = r.basicsal * 0.15;
                ViewBag.da = r.basicsal * 0.45;
                ViewBag.hra = r.basicsal * 0.25;
                ViewBag.totalsal = r.basicsal + ViewBag.ta + ViewBag.da + ViewBag.hra;
            }
            else if(r.desig == "clerk")
            {
                ViewBag.ta = r.basicsal * 0.13;
                ViewBag.da = r.basicsal * 0.40;
                ViewBag.hra = r.basicsal * 0.20;
                ViewBag.totalsal = r.basicsal + ViewBag.ta + ViewBag.da + ViewBag.hra;
            }
            else if(r.desig =="peon")
            {
                ViewBag.ta = r.basicsal * 0.10;
                ViewBag.da = r.basicsal * 0.30;
                ViewBag.hra = r.basicsal * 0.15;
                ViewBag.totalsal = r.basicsal + ViewBag.ta + ViewBag.da + ViewBag.hra;
            }

            return View();
        }
    }
}
