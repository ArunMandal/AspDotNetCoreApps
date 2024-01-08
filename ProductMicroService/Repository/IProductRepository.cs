using ProductMicroService.Model;

namespace ProductMicroService.Repository
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetProducts();

        Product GetProductById(int productid);

        void InsertProduct(Product product);

        void DelProduct(int productid);

        void UpdateProduct(Product product);

        void Save();

    }
}
