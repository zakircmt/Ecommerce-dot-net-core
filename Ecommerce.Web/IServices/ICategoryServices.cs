using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface ICategoryServices
    {
        public List<Category> GetAllCategories();
        public void GetAllCategory();
        public void SaveCategory(Category category);
        public List<Category> GetNineCategory();
        public List<CategoryPicture> GetAllCategoryPicture();
        public Category GetCategoryByID(int ID);
    }
}
