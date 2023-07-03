using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;
using Validation.Models;

namespace Validation.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //it is a server-side code...
        [HttpPost]
        public IActionResult Index(ValidationModel sm)
        {
            if(string.IsNullOrEmpty(sm.Name))
            {
                ModelState.AddModelError("Name", "Name required");
            }
            if(sm.Age == 0 || sm.Age ==120)
            {
                ModelState.AddModelError("Age", "Please Enter Valid Age between 1-120");
            }
            if(ModelState.IsValid)
            {
                ViewBag.Name = sm.Name;
                ViewBag.Age = sm.Age;
                return View();
            }
            else
            {
                ViewBag.Name = "No Data";
                ViewBag.Age = "NO Data";
                return View();
            }
        }
    }
}
