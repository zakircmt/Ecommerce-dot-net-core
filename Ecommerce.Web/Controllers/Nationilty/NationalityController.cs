
using Ecommerce.Web.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.Nationilty
{
    public class NationalityController : Controller
    {
        private readonly ApplicationDbContext db;
        public NationalityController(ApplicationDbContext _db)
        {
            db = _db;
        }
        // GET: Nationality
        public ActionResult Index()
        {
            var nationalityList = db.Nationilities.ToList();
            return View(nationalityList);
        }

        public ActionResult AddNationality()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNationality(Ecommerce.Entities.Nationility nationilty)
        {
            if (ModelState.IsValid)
            {
                db.Nationilities.Add(nationilty);
                db.SaveChanges();
            }
            return View(nationilty);
        }
    }
}