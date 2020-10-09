using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMDT_Lab2.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(string Category)
        {
            var db = new TMDT_Lab2.Models.TMDTEntities();
            var ListNews = db.New.Where(c => c.Category.Alias == Category);
            return View(ListNews);
        }
    }
}