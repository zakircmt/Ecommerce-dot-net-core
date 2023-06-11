using Ecommerce.Web.Models.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Ecommerce.Entities;
using Ecommerce.Services.BrandService;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Web.IServices;

namespace Ecommerce.Web.Controllers.Brand
{
    public class BrandController : Controller
    {
        private readonly IBrandServices brandServices;
        public BrandController(IBrandServices _brandServices)
        {
            brandServices = _brandServices;
        }
        // GET: Brand
        public ActionResult Index()
        {
            var brand = brandServices.GetAllBrand();

            return View(brand);
        }
        public ActionResult AddBrand()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBrand(CreateBrandModel model)
        {
            Branding brand = new Branding();
            brand.BrandName = model.BrandName;
            brand.Description = model.Description;
            brand.Status = model.Status;
           

            if (!string.IsNullOrEmpty(model.BrandPictures))
            {
                var pictureIDs = model.BrandPictures
                    .Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(ID => int.Parse(ID)).ToList();

                brand.BrandingPictures = new List<BrandingPicture>();
                brand.BrandingPictures.AddRange(pictureIDs
                    .Select(x => new BrandingPicture() { PictureID = x }).ToList());
            }
            brandServices.SaveBrand(brand);

            return RedirectToAction("Index");
        }
        public IActionResult EditBrand(int ID)
        {
            CreateBrandModel model = new CreateBrandModel();
            Branding brand = brandServices.GetBrandByID(ID);
            model.ID = brand.ID;
            model.Description = brand.Description;
            model.BrandName = brand.BrandName;
            model.BrandPictureList = brand.BrandingPictures;
            return View();
        }
        [HttpPost]
        public IActionResult EditBrand(CreateBrandModel model)
        {
            Branding brand = new Branding();
            brand.ID = model.ID;
            brand.BrandName = model.BrandName;
            brand.Description = model.Description;

            if (!string.IsNullOrEmpty(model.BrandPictures))
            {
                var pictureIDs = model.BrandPictures
                    .Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(ID => int.Parse(ID)).ToList();

                brand.BrandingPictures = new List<BrandingPicture>();
                brand.BrandingPictures.AddRange(pictureIDs
                    .Select(x => new BrandingPicture() { PictureID = x }).ToList());
            }
            brandServices.UpdateBrand(brand);

            return RedirectToAction("Index");
        }
    }
}