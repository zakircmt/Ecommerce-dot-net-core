using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface ICheckoutServices
    {
        public List<Product> GetProductsForCheckout(List<int> IDs);
        public int SaveOrder(Ecommerce.Entities.Order order);
    }
}
