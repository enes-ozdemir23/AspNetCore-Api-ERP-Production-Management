using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.EntityLayer.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Content { get; set; }  
        public string Name { get; set; }      
        public string Title { get; set; }     
        public string ImageUrl { get; set; }  
    }
}
