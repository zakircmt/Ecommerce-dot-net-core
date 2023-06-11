

using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service
{
   public class CategoryServices : ICategoryServices
    {
        ApplicationDbContext db;
        public CategoryServices(ApplicationDbContext _db)
        {
            db = _db;
        }
        public List<Category> GetAllCategories()
        {
            var categoryList = db.Categories.Include(p=>p.CategoryPictures).ThenInclude(s=>s.Picture).ToList();
            return categoryList;
        }

        public void GetAllCategory()
        {
             db.Categories.ToList();
        }
        public void SaveCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public List<Category> GetNineCategory()
        {
            var category = db.Categories.Take(9).ToList();

            return category;
        }
        public List<CategoryPicture> GetAllCategoryPicture()
        {
            var category = db.CategoryPictures.ToList();

            return category;
        }
        public Category GetCategoryByID(int ID)
        {
            return db.Categories.Find(ID);
          
        }
    }
}
