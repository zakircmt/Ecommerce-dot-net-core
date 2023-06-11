
using Ecommerce.Services.UserServices;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.UserType
{
    public class UserTypeController : Controller
    {
        ApplicationDbContext db;
        private readonly IUserServices userService;
        public UserTypeController(ApplicationDbContext _db, IUserServices _userService)
        {
            db = _db;
            userService = _userService;
        }
        // GET: UserType
        public ActionResult Index()
        {
            var userlist = userService.GetAllUserType();
            ViewBag.userList = userlist;
            return View();
        }
        public ActionResult AddUserType()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUserType(Ecommerce.Entities.UserType userType)
        {
            if (ModelState.IsValid)
            {
                db.UserTypes.Add(userType);
                db.SaveChanges();
            }
            return View(userType);
        }
    }
}