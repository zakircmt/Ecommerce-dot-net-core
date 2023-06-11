
using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.ManufactureServices
{
    public class ManufacturerServices : IManufacturerServices
    {
        ApplicationDbContext db;
        public ManufacturerServices(ApplicationDbContext _db)
        {
            db = _db;
        }
        public List<Manufacturer> GetAllManufacturer()
        {
            var manufacturerList = db.Manufacturers.ToList();
            return manufacturerList;
        }
        public List<Manufacturer> GetSixManufacture()
        {
            var manufacture = db.Manufacturers.Take(6).ToList();
            return manufacture;
        }
    }
}
