namespace LoansMonitoring.ClassLib.Repositories.Contracts;

public interface IProductCategoryRepository
{
   Task<ProductCategory> GetCategory(int id);
   Task<IEnumerable<ProductCategory>> GetCategories();
}