using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface ISizeServices
    {
        public void SaveSize(ProductSize productsize);
        public ProductSize GetProductSizeByID(int ID);
        public List<ProductSize> GetProductSizeByIDs(List<int> IDs);
        public List<ProductSize> GetProductSize(List<int> IDs);
        public List<ProductSize> GetAllProductSize();
        public void UpdateAuction(ProductSize productSize);
        public void DeleteAuction(ProductSize productSize);
    }
}
