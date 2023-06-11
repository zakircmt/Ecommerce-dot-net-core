using Ecommerce.Service;
using Ecommerce.Services.BrandService;
using Ecommerce.Services.ManufactureServices;
using Ecommerce.Web.IServices;
using Ecommerce.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ecommerce.Web.Controllers.Product
{
    public class SeachingProductController : Controller
    {
        private readonly ICategoryServices categoryServices;
        private readonly IProductServices productServices;
        private readonly IBrandServices brandServices;
        private readonly IManufacturerServices manufacturerServices;
        public SeachingProductController(ICategoryServices _categoryServices, IProductServices _productServices,
            IBrandServices _brandServices, IManufacturerServices _manufacturerServices)
        {
            categoryServices = _categoryServices;
            productServices = _productServices;
            brandServices = _brandServices;
            manufacturerServices = _manufacturerServices;
        }
        // GET: SeachingProduct
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryWiseProduct(int ID)
        {
            ProductListViewModel model = new ProductListViewModel();
            var category = categoryServices.GetNineCategory();
            ViewBag.NineCategory = category;

            model.Products=productServices.CategoryWiseNineProduct(ID);
            model.Branding = brandServices.GetAllBrand();

            return View(model);
        }
        public ActionResult ManufactureWiseProduct(int ID)
        {
            ProductListViewModel model = new ProductListViewModel();
            var category = categoryServices.GetNineCategory();
            ViewBag.NineCategory = category;

            var manufacture = manufacturerServices.GetAllManufacturer().Take(6).ToList();
            ViewBag.manufacture = manufacture;

            model.ManufactureList = manufacturerServices.GetSixManufacture();
            model.Products = productServices.CategoryWiseNineProduct(ID);
            model.Branding = brandServices.GetAllBrand();
            model.Manufacturers = productServices.ManufactureWiseProduct(ID);

            return View(model);
        }

    }
}