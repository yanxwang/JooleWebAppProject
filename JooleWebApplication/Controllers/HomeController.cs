<<<<<<< HEAD:JooleWebApplication/Controllers/HomeController.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleWebApplication.Models;

namespace JooleWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
=======
﻿using System;
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
>>>>>>> 69a762f6cd11d79ffdbab7181355d8b9a1ba6c36:Joole Application/Controllers/HomeController.cs
}