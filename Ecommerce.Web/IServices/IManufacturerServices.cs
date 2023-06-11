using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface IManufacturerServices
    {
        public List<Manufacturer> GetAllManufacturer();
        public List<Manufacturer> GetSixManufacture();
    }
}
