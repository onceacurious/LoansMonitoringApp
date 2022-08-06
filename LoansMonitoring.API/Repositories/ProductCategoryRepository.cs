namespace LoansMonitoring.ClassLib.Repositories;
public class ProductCategoryRepository : IProductCategoryRepository
{
   private readonly DbConnection _connection;

   public ProductCategoryRepository(DbConnection connection)
   {
      _connection = connection;
   }
   public async Task<IEnumerable<ProductCategory>> GetCategories()
   {
      var result = await _connection.ProductCategories.ToListAsync();
      return result;
   }
   public async Task<ProductCategory> GetCategory(int id)
   {
      var result = await _connection.ProductCategories.FindAsync(id);
      return result;
   }

}
