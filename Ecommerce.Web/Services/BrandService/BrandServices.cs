
using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.BrandService
{
    public class BrandServices : IBrandServices
    {
        ApplicationDbContext db;
        public BrandServices(ApplicationDbContext _db)
        {
            db = _db;
        }
        public List<Branding> GetAllBrand()
        {
            var brandList= db.Brands.Include(p => p.BrandingPictures).ThenInclude(s => s.Picture).ToList();
            return brandList;
        }

        public Branding GetBrandByID(int ID)
        {
            var findBrand = db.Brands.Include(p => p.BrandingPictures).ThenInclude(s => s.Picture).Where(x => x.ID == ID).FirstOrDefault();
            return findBrand;
        }

        public bool UpdateBrand(Branding branding)
        {
            var existingBrand = db.Brands.Find(branding.ID);
            db.BrandPictures.RemoveRange(existingBrand.BrandingPictures);
            db.Entry(existingBrand).CurrentValues.SetValues(branding);
            db.BrandPictures.AddRange(branding.BrandingPictures);
            return db.SaveChanges() > 0;
        }

        public void SaveBrand(Branding brand)
        {
            db.Brands.Add(brand);
            db.SaveChanges();
        }
    }
}
