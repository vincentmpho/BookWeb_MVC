using BookNest.Models;
using Microsoft.EntityFrameworkCore;

namespace BookNest.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; } 
       
    }
}
