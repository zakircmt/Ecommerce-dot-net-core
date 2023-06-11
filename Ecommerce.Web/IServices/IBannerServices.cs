using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface IBannerServices
    {
        public List<Banner> GetAllBanner();
        public void SaveBanner(Banner banner);
        public void DeleteBanner(Banner banner);
        public bool UpdateBanner(Banner banner);
        public Banner GetBannerByID(int ID);
    }
}
