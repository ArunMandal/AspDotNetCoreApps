using AspNetCoreWebAPIProject.Model;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebAPIProject
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
    }
}
