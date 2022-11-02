using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Joole_Application.Models;

namespace Joole_Application.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        private jooledatabaseEntities2 db = new jooledatabaseEntities2();
        //public ActionResult Search(string cat, string subcat)
        //{
        //    //db.tblProducts.Where(x => x.Category_Name.Contains(cat) && x.SubCategory_Name.Contains(subcat)) ToList();
        //    //return View();
        //}


    }
}

