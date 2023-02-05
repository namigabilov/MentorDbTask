using Mentor.Models;
using Microsoft.EntityFrameworkCore;

namespace Mentor.DataAccessLayer
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Home> Homes { get; set; }
        
        public DbSet<About> Abouts { get; set; }   
        
        public  DbSet<Testimonial> Testimonials { get; set; }

        public  DbSet<Contact> Contacts { get; set; }

    }
}
