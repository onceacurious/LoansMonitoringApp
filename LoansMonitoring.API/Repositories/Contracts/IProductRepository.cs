namespace LoansMonitoring.API.Repositories.Contracts;

public interface IProductRepository
{
   Task<Product> DeleteProduct(int id);
   Task<Product> GetProduct(int id);
   Task<IEnumerable<Product>> GetProducts();
   Task<Product> UpdateProduct(int id);
}