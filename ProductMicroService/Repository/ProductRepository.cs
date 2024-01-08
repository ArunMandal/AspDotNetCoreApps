using ProductMicroService.Model;

namespace ProductMicroService.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly ProductDBContext _dbContext;

        public ProductRepository(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DelProduct(int productid)
        {
            var product = _dbContext.Products.Find(productid);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
            }
            Save();

         
        }

        public Product GetProductById(int productid)
        {

            return _dbContext.Products.Find(productid);
           
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Products.Add(product);
            Save();
           
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            Save();

        }
    }
}
