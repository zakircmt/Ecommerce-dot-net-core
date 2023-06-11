using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface IAdsServices
    {
        public List<SecoundBanner> GetAllSecoundBanner();
        public void SaveSecoundBanner(SecoundBanner secoundBanner);
        public bool UpdateAds(SecoundBanner secoundBanner);
        public SecoundBanner GetAdsByID(int ID);
        public void DeleteAds(SecoundBanner secoundBanner);
    }
}
