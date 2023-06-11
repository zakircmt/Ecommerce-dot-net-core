
using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.BannerServices
{
    public class BannerServices : IBannerServices
    {
        ApplicationDbContext db;
        public BannerServices(ApplicationDbContext _db)
        {
            db = _db;
        }
        public List<Banner> GetAllBanner()
        {
            var bannerList = db.Banners.Include(p=>p.BannerPictures).ThenInclude(s=>s.Picture).ToList();
            return bannerList;
        }

        public void SaveBanner(Banner banner)
        {
            db.Banners.Add(banner);
            db.SaveChanges();
        }
        public bool UpdateBanner(Banner banner)
        {
            var existingBanner = db.Banners.Find(banner.ID);
            db.BannerPictures.RemoveRange(existingBanner.BannerPictures);
            db.Entry(existingBanner).CurrentValues.SetValues(banner);
            db.BannerPictures.AddRange(banner.BannerPictures);
            return db.SaveChanges() > 0;
        }

        public void DeleteBanner(Banner banner)
        {
            db.Entry(banner).State = EntityState.Deleted;
            db.SaveChanges();
        }
        public Banner GetBannerByID(int ID)
        {
            var findBanner = db.Banners.Include(p => p.BannerPictures).ThenInclude(s => s.Picture).Where(x => x.ID == ID).FirstOrDefault();
            return findBanner;
        }
    }
}
