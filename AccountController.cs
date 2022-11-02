using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupProjectWeb.Models;

namespace GroupProjectWeb.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=GroupProjectData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        [HttpPost]
        public ActionResult Verify(Account acc) 
        {
            connectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from tblUser where User_Email ='" + acc.Name + "' and User_Password = '" + acc.Password + "' ";
            dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Searchmain");
            }
            else { 
                con.Close();
                return View();
            }
            con.Close();
            return View();    
        }
        private GroupProjectDataEntities db = new GroupProjectDataEntities();
        public ActionResult Searchmain() { 
            return View();
        }
        public ActionResult Search(string cat, string subcat)
        {
            return View(db.tblProducts.Where(x => x.Category_Name.Contains(cat) && x.SubCategory_Name.Contains(subcat)).ToList());
        }
    }
}