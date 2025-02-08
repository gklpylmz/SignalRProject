using SignalRBLL.ManagerServices.Abstracts;
using SignalRDAL.Repositories.Abstracts;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBLL.ManagerServices.Concretes
{
    public class SliderManager:BaseManager<Slider>,ISliderManager
    {
        ISliderRepository _sliderRepository;

        public SliderManager(ISliderRepository sliderRepository):base(sliderRepository)
        {
            _sliderRepository = sliderRepository;
        }
    }
}
