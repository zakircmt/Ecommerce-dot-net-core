using Ecommerce.Entities;
using Ecommerce.Service;
using Ecommerce.Services.BrandService;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Ecommerce.Web.Models.Category;
using Ecommerce.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace Ecommerce.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices categoryServices;
        private readonly IBrandServices brandServices;
        private readonly ApplicationDbContext db;
        public CategoryController(ICategoryServices _categoryServices, IBrandServices _brandServices,
            ApplicationDbContext _db)
        {
            categoryServices = _categoryServices;
            brandServices = _brandServices;
        }
        // GET: Category
        public IActionResult Index()
        {
            var categroy = categoryServices.GetAllCategories();
            //var category=db.Categories
           
            return View(categroy);
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(CreateCategoryModel model)
        {
            Category category = new Category();

            category.CategoryName = model.CategoryName;
            category.CategoryDescription = model.CategoryDescription;
            category.Status = model.Status;


            if (!string.IsNullOrEmpty(model.CategoryPictures))
            {
                var pictureIDs = model.CategoryPictures
                    .Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(ID => int.Parse(ID)).ToList();

                category.CategoryPictures = new List<CategoryPicture>();
                category.CategoryPictures.AddRange(pictureIDs
                    .Select(x => new CategoryPicture() { PictureID = x }).ToList());
            }
            categoryServices.SaveCategory(category);

            return RedirectToAction("Index");
        }
        public ActionResult ShwoAllCategories()
        {
            var category = categoryServices.GetNineCategory();
            ViewBag.NineCategory = category;

            CategoryListingViwModel model = new CategoryListingViwModel();
            

            model.Categories = categoryServices.GetAllCategories();
           
            model.CategoryPictures = categoryServices.GetAllCategoryPicture();
            model.Branding = brandServices.GetAllBrand();

            return View(model);
        }
    }
}