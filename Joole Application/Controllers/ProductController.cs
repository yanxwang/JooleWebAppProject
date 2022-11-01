using Joole_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole_Application.Controllers
{
    public class ProductController : Controller
    {
        // GET: User
        jooledatabaseEntities2 db = new jooledatabaseEntities2();
        public ActionResult Index()
        {
            //查询，获取所有的产品信息
            //List<tblProduct> list1 = db.tblProducts.OrderByDescending(t => t.ModeL_Year).ToList();
            ViewBag.list = db.tblProducts.OrderByDescending(t => t.ModeL_Year).ToList();
            return View();
        }
    }
}