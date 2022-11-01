using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole_Application.Models
{
    public class searchController : Controller
    {
        // GET: search
        public string category { get; set; }
        public string subcategory { get; set; }
        public ActionResult Index()
        {
            return View();
        }
    }
}



