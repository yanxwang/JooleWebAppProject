using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using compareTest.Models;

namespace compareTest.Controllers
{
    public class tblProductsController : Controller
    {
        private TestDataEntities db = new TestDataEntities();

        // GET: tblProducts
        public ActionResult Index()
        {
            return View(db.tblProducts.ToList());
        }

        // GET: tblProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduct tblProduct = db.tblProducts.Find(id);
            if (tblProduct == null)
            {
                return HttpNotFound();
            }
            return View(tblProduct);
        }

        // GET: tblProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Product_ID,Product_Name,Product_Image,Manufacturer_Name,SubCategory_Name,Category_Name,Series,Model,ModeL_Year,Type,Application,Mounting_Location,Accessories,Air_Flow,Power_Min,Power_Max,Operating_Voltage_Min,Operating_Voltage_Max,Fan_Speed_Min,Fan_Speed_Max,Number_Of_Fan_Speed,Sound_At_Max_Speed,Fan_Sweep_Diameter,Height_Min,Height_Max,Weight,Document_Path")] tblProduct tblProduct)
        {
            if (ModelState.IsValid)
            {
                db.tblProducts.Add(tblProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblProduct);
        }

        // GET: tblProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduct tblProduct = db.tblProducts.Find(id);
            if (tblProduct == null)
            {
                return HttpNotFound();
            }
            return View(tblProduct);
        }

        // POST: tblProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Product_ID,Product_Name,Product_Image,Manufacturer_Name,SubCategory_Name,Category_Name,Series,Model,ModeL_Year,Type,Application,Mounting_Location,Accessories,Air_Flow,Power_Min,Power_Max,Operating_Voltage_Min,Operating_Voltage_Max,Fan_Speed_Min,Fan_Speed_Max,Number_Of_Fan_Speed,Sound_At_Max_Speed,Fan_Sweep_Diameter,Height_Min,Height_Max,Weight,Document_Path")] tblProduct tblProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblProduct);
        }

        // GET: tblProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduct tblProduct = db.tblProducts.Find(id);
            if (tblProduct == null)
            {
                return HttpNotFound();
            }
            return View(tblProduct);
        }

        // POST: tblProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblProduct tblProduct = db.tblProducts.Find(id);
            db.tblProducts.Remove(tblProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Compare()
        {
            var selectedProducts = TempData["temp"];
            ViewBag.Products = selectedProducts;
            return View(db.tblProducts.ToList());
        }

        public ActionResult AddtoCompare()
        {
            return View();
        }

        public ActionResult Testt()
        {
            return View(db.tblProducts.ToList());
        }

        public ActionResult Testtt()
        {
            var selectedFans = TempData["temp"];
            ViewBag.X = selectedFans;
            return View(db.tblProducts.ToList());
            //return View(db.tblProducts.ToList());
        }

        [HttpPost]
        public JsonResult sendData(string ItemList)
        {
            string[] arr = ItemList.Split(',');
            ArrayList arlist = new ArrayList();
            foreach (var id in arr)
            {
                arlist.Add(id);
            };
            TempData["temp"] = ItemList;
            return Json("", JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
