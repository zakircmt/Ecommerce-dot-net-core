
using Ecommerce.Web.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.Religious
{
    public class ReligiousController : Controller
    {
        private readonly ApplicationDbContext db;
        public ReligiousController(ApplicationDbContext _db)
        {
            db = _db;
        }
        // GET: Religious
        public ActionResult Index()
        {
            var religiousList = db.Religiouses.ToList();
            return View(religiousList);
        }
        public ActionResult AddReligious()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddReligious(Ecommerce.Entities.Religious religious)
        {
            if (ModelState.IsValid)
            {
                db.Religiouses.Add(religious);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}