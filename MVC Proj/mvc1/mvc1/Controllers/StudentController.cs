using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
