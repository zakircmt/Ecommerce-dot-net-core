using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface IBrandServices
    {
        public List<Branding> GetAllBrand();
        public void SaveBrand(Branding brand);
        public Branding GetBrandByID(int ID);
        public bool UpdateBrand(Branding branding);
    }
}
