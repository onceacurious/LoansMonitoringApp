namespace LoansMonitoring.API.Repositories;

public class ProductRepository : IProductRepository
{
   private readonly DbConnection _connection;

   public ProductRepository(DbConnection connection)
   {
      _connection = connection;
   }

   public async Task<IEnumerable<Product>> GetProducts()
   {
      var result = await _connection.Products.ToListAsync();
      return result;
   }
   public async Task<Product> GetProduct(int id)
   {
      var result = await _connection.Products.SingleOrDefaultAsync(p => p.Id == id);
      return result;
   }

   public Task<Product> UpdateProduct(int id)
   {
      throw new NotImplementedException();
   }
   public Task<Product> DeleteProduct(int id)
   {
      throw new NotImplementedException();
   }
}
