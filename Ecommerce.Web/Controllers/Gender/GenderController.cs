using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers.Gender
{
    public class GenderController : Controller
    {
        private readonly ApplicationDbContext db;
        public GenderController(ApplicationDbContext _db)
        {

        }
        
        // GET: Gender
        public ActionResult Index()
        {
            var genderList = db.Genders.ToList();
            return View(genderList);
        }

        public ActionResult AddGender()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGender(Ecommerce.Entities.Gender gender)
        {
            if (ModelState.IsValid)
            {
                db.Genders.Add(gender);
                db.SaveChanges();
            }
            return View(gender);
        }
    }
}