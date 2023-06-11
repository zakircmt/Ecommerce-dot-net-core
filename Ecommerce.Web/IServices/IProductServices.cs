using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface IProductServices
    {
        public void SaveProduct(Product product);
        public void SaveMostView(MostView mostView);
        public List<Product> GetAllProduct();
        //public List<Product> GetMaxOrderQuantity();
        public Product GetProductByID(int ID);
        public bool UpdateProduct(Product product);
        public List<Product> GetAllHotDealProduct();
        public List<Product> CategoryWiseNineProduct(int categoryID);
        public List<Product> ManufactureWiseProduct(int manufactureID);
        public List<Product> GetProductByIDs(List<int> productIDs);
        public List<Product> GetFeaturedProduct();
        public List<Product> SearchProduct(string searchTerm, int? manufactureID, int? minimum, int? maximum);
        public List<BrandingPicture> GetAllBrand();
        public int GetMinimumPrice();
        public int GetMaximumPrice();
        public List<Product> GetLatestProduct();
        //public List<Product> GetMostViewProduct();
        public List<Product> GetProduct(List<int> productIds);
    }
}
