using LoansMonitoring.API.Repositories.Contracts;
using LoansMonitoring.ClassLib.DTOs.Product;

namespace LoansMonitoring.API.Repositories;

public class ProductRepository : IProductRepository
{
	private readonly DbConnection _db;

	public ProductRepository(DbConnection db)
	{
		_db = db;
	}

	public async Task<IEnumerable<Product>> GetProducts()
	{
		var products = await _db.Products.ToListAsync();
		return products;
	}
	public async Task<Product> AddProduct(Product product)
	{
		var result = await _db.AddAsync(product);
		await _db.SaveChangesAsync();
		return result.Entity;
	}
	public async Task<Product> GetProduct(int id)
	{
		var prod = await _db.Products.Include(p => p.Loan).SingleOrDefaultAsync(p => p.Id == id);
		return prod;
	}
	public async Task<Product> UpdateProduct(int id, ProductUpdateDeleteDto dto)
	{
		var prod = await _db.Products.FindAsync(id);
		if (prod != null)
		{
			prod.Name = dto.Name;
			prod.Description = dto.Description;
			prod.LoanId = dto.LoanId;
			await _db.SaveChangesAsync();
			return prod;
		}

		return null;
	}

	public async Task<Product> DeleteProduct(int id)
	{
		var prop = await _db.Products.FindAsync(id);
		if (prop != null)
		{
			_db.Products.Remove(prop);
			await _db.SaveChangesAsync();
			return prop;
		}

		return null;
	}
}
