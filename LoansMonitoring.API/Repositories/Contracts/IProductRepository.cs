using LoansMonitoring.ClassLib.DTOs.Product;

namespace LoansMonitoring.API.Repositories.Contracts;

public interface IProductRepository
{
   Task<IEnumerable<Product>> GetProducts();
   Task<Product> AddProduct(Product product);
   Task<Product> GetProduct(int id);
   Task<Product> UpdateProduct(int id, ProductUpdateDto dto);
   Task<Product> DeleteProduct(int id);
   Task<List<Product>> GetProductByLoan(int loanId);
}