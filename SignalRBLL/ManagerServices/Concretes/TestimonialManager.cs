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
    public class TestimonialManager:BaseManager<Testimonial>,ITestimonialManager
    {
        ITestimonialRepository _testimonialRepository;

        public TestimonialManager(ITestimonialRepository testimonialRepository) :base(testimonialRepository) 
        {
            _testimonialRepository = testimonialRepository;
        }
    }
}
