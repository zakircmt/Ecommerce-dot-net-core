
using Ecommerce.Entities;
using Ecommerce.Web.Data;
using Ecommerce.Web.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.SliderServices
{
    public class SliderServices : ISliderServices
    {
        ApplicationDbContext db;
        public SliderServices(ApplicationDbContext _db)
        {
            db = _db;
        }
        public List<Slider> GetAllSliders()
        {
            return db.Sliders.ToList();
        }


        public void SaveSlider(Slider slider)
        {
            db.Sliders.Add(slider);
            db.SaveChanges();
        }
    }
}
