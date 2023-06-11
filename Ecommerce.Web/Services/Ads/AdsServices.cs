
using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Ads
{
   public  class AdsServices :IAdsServices
    {
        private readonly ApplicationDbContext db;
        public AdsServices(ApplicationDbContext _db)
        {
            db = _db;
        }

        public SecoundBanner GetAdsByID(int ID)
        {
            var findAds = db.SecoundBanners.Include(p=>p.SecoundBannerPictures).ThenInclude(s=>s.Picture).Where(x=>x.ID==ID).FirstOrDefault();
            return findAds;
        }

        public List<SecoundBanner> GetAllSecoundBanner()
        {
            var banner = db.SecoundBanners.Include(p=>p.SecoundBannerPictures).ThenInclude(s=>s.Picture).ToList();
            return banner;
        }
        public void SaveSecoundBanner(SecoundBanner secoundBanner)
        {
            db.SecoundBanners.Add(secoundBanner);
            db.SaveChanges();
        }

        public bool UpdateAds(SecoundBanner secoundBanner)
        {
            var existingAds = db.SecoundBanners.Where(x=>x.ID==secoundBanner.ID).FirstOrDefault();
            var findAdsPicture = db.SecoundBannerPictures.Include(p => p.Picture).Where(x => x.SecoundBannerID == secoundBanner.ID).FirstOrDefault();
            db.SecoundBannerPictures.RemoveRange(findAdsPicture);
            db.Entry(existingAds).CurrentValues.SetValues(secoundBanner);
            db.SecoundBannerPictures.AddRange(secoundBanner.SecoundBannerPictures);
            return db.SaveChanges() > 0;
        }
        public void DeleteAds(SecoundBanner secoundBanner)
        {
            db.Entry(secoundBanner).State =EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
