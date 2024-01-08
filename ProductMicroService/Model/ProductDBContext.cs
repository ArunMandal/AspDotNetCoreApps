using Microsoft.EntityFrameworkCore;

namespace ProductMicroService.Model
{
    public class ProductDBContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDBContext(DbContextOptions<ProductDBContext> options ):base(options) { }



    }
}
