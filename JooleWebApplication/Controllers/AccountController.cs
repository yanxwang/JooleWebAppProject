<<<<<<< HEAD:JooleWebApplication/Controllers/AccountController.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleWebApplication.Models;

namespace Joole_Application.Controllers
{
    public class AccountController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            //1.根据传递过来的用户名和密码，到数据库中查询是否存在
            tblUser user = db.tblUsers.FirstOrDefault(t => t.User_Name == UserName && t.User_Password == Password);
            if (user != null)
            {
                Session["login"] = user;
                return RedirectToAction("Search", "tblProducts");
            }
            else
            {
                TempData["msg"] = "wrong username/email or password!";
                return View();
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(tblUser user)
        {

            if (user != null)
            {
                db.tblUsers.Add(user);
                db.SaveChanges();
                TempData["msg"] = "Congrats! You have registered successfully, please log in.";
                return View("login");
            }
            else
            {
                TempData["msg"] = "Register failed, please register again!";
                return View();
            }
        }

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
    public class AccountController : Controller
    {
        jooledatabaseEntities2 db = new jooledatabaseEntities2();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            //1.根据传递过来的用户名和密码，到数据库中查询是否存在
            tblUser user = db.tblUsers.FirstOrDefault(t => t.User_Name == UserName && t.User_Password == Password);
            if (user != null)
            {
                Session["login"] = user;
                return RedirectToAction("Searchmain", "product");
            }
            else
            {
                TempData["msg"] = "wrong username/email or password!";
                return View();
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(tblUser user)
        {
            tblUser a = user;
            if (user != null)
            {
                db.tblUsers.Add(user);
                db.SaveChanges();
                TempData["msg"] = "Congrats! You have registered successfully, please log in.";
                return View("login");
            }
            else
            {
                TempData["msg"] = "Register failed, please register again!";
                return View();
            }
        }
    }
}
>>>>>>> 69a762f6cd11d79ffdbab7181355d8b9a1ba6c36:Joole Application/Controllers/AccountController.cs
