using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMDT_Lab2.Controllers
{
    public class NewsController : Controller
    {
        // GET: Alias
        public ActionResult Index(string Category,string Alias)
        {
            var db = new TMDT_Lab2.Models.TMDTEntities();
            var ListNews = db.New.Where(c => c.Category.Alias == Category && c.Category.Alias == Alias);
            return View(ListNews);
        }
    }
}