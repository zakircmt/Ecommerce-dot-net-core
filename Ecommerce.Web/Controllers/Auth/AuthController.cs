
using Ecommerce.Web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.Auth
{
    public class AuthController : Controller
    {
        ApplicationDbContext db;
        public AuthController(ApplicationDbContext _db)
        {
            db = _db;
        }
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var customer = db.TblUsers.Where(u => u.Username == username && u.Password == password && u.UserTypeID == 4).FirstOrDefault();
            var admin = db.TblUsers.Where(user => user.Username == username && user.Password == password && user.UserTypeID==1).FirstOrDefault();
            
            if (admin != null || customer != null)
            {
                if (admin != null)
                {
                    HttpContext.Session.SetInt32("ID", admin.ID);
                    HttpContext.Session.SetInt32("UserTypeID", admin.UserTypeID);
                    HttpContext.Session.SetString("FirstName", admin.FirstName);
                    HttpContext.Session.SetString("LastName", admin.LastName);
                    HttpContext.Session.SetString("Username", admin.Username);
                    HttpContext.Session.SetString("Password", admin.Password);
                    HttpContext.Session.SetString("Email", admin.EmailAddress);

                    return RedirectToAction("Index", "AdminDashboard", new { id = HttpContext.Session.GetInt32("ID") });
                }
                if (customer != null)
                {
                    HttpContext.Session.SetInt32("ID", customer.ID);
                    HttpContext.Session.SetInt32("UserTypeID", customer.UserTypeID);
                    HttpContext.Session.SetString("FirstName", customer.FirstName);
                    HttpContext.Session.SetString("LastName", customer.LastName);
                    HttpContext.Session.SetString("Username", customer.Username);
                    HttpContext.Session.SetString("Password", customer.Password);

                    return RedirectToAction("Index", "UserDashboard", new { id = HttpContext.Session.GetInt32("ID") });
                }
            }
            else
            {

                ViewBag.message = "Username or Password is incorrect !";

            }

            HttpContext.Session.SetInt32("ID", int.Parse(string.Empty));
            HttpContext.Session.SetInt32("UserTypeID", int.Parse(string.Empty));
            HttpContext.Session.SetString("FirstName", string.Empty);
            HttpContext.Session.SetString("LastName", string.Empty);
            HttpContext.Session.SetString("Username", string.Empty);
            HttpContext.Session.SetString("Password", string.Empty);

            ViewBag.message = "Username or Password is incorrect !";
            return View();
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Remove("ID");
            HttpContext.Session.Remove("UserTypeID");
            HttpContext.Session.Remove("LastName");
            HttpContext.Session.Remove("FirstName");
            HttpContext.Session.Remove("Username");
            HttpContext.Session.Remove("Password");
            HttpContext.Session.Remove("Email");

            return RedirectToAction("Login");
        }
    }
}