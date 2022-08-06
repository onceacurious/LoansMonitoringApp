using LoansMonitoring.ClassLib.Models;


namespace LoansMonitoring.ClassLib.DataAccess;
public class DbConnection : DbContext
{
   public DbConnection(DbContextOptions<DbConnection> options) : base(options)
   {

   }

   public DbSet<Product> Products { get; set; }
   public DbSet<ProductCategory> ProductCategories { get; set; }
}
