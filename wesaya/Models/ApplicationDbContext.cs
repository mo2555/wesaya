using Microsoft.EntityFrameworkCore;

namespace wesaya.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }


        public DbSet<CategoryModel> Categories { get; set; }

    }
}
