using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.IServices
{
    public interface ISliderServices
    {
        public List<Slider> GetAllSliders();
        public void SaveSlider(Slider slider);
    }
}
