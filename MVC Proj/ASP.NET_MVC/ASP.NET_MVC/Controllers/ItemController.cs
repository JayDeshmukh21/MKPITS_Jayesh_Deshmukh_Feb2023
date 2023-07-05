using ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer shop item list page";
            ItemDBHandler iHandler = new ItemDBHandler();
            ModelState.Clear();
            return View(iHandler.GetItemsList());
        }
        [HttpGet] 
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(ItemModel iList)
        {
            if(ModelState.IsValid)
            {
                ItemDBHandler db = new ItemDBHandler();
                if(db.InsertItem(iList))
                {
                    ViewBag.message = "item saved successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }
    }
}