using Joole_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole_Application.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        private jooledatabaseEntities2 db = new jooledatabaseEntities2();
        public ActionResult Search(string cat, string subcat)
        {
            
            ViewBag.list1 = db.tblProducts.Where(x => x.Category_Name.Contains(cat) && x.SubCategory_Name.Contains(subcat)).ToList();
            return View();
        }
    }
}

