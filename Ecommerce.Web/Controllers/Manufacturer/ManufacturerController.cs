
using Ecommerce.Services.ManufactureServices;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.Manufacturer
{
    public class ManufacturerController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IManufacturerServices manufacturerServices;
        public ManufacturerController(ApplicationDbContext _db, IManufacturerServices _manufacturerServices)
        {
            db = _db;
            manufacturerServices = _manufacturerServices;
        }
        // GET: Manufacturer
        public ActionResult Index()
        {
            var manufacturerList = manufacturerServices.GetAllManufacturer();
            return View(manufacturerList);
        }
        public ActionResult AddManufacturers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddManufacturers(Ecommerce.Entities.Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                db.Manufacturers.Add(manufacturer);
                db.SaveChanges();
            }
            return View();
        }
    }
}