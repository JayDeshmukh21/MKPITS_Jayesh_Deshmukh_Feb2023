using Microsoft.AspNetCore.Mvc;

namespace mcv2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
