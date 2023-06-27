using BankAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult index(AccountModel z)
        {
            ViewBag.name = z.name;
            ViewBag.amount = z.amount;
            ViewBag.actype = z.actype;
            ViewBag.amt = 3000;
            ViewBag.bal = z.bal;
            

           
            if (z.actype == "deposite")
            {
                
                ViewBag.bal = 3000 + ViewBag.amount;
            }
            else if(z.actype == "withdraw")
            {
                ViewBag.bal = 3000 - ViewBag.amount;
                if(ViewBag.amount > 3000)
                {
                    ViewBag.bal = "Insufficient amount";
                }
            }
            return View();
        }
    }
}
