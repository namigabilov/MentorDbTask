using System.Runtime.CompilerServices;

namespace Mentor.Models
{
    public class About
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Counter { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }

}
