using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole_Application.Models;

namespace Joole_Application.Controllers
{
    public class HomeController : Controller
    {
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