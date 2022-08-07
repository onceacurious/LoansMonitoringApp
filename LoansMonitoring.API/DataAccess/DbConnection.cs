namespace LoansMonitoring.ClassLib.DataAccess;
public class DbConnection : DbContext
{
   public DbConnection(DbContextOptions<DbConnection> options) : base(options)
   {

   }

   public DbSet<Product> Products { get; set; }
   public DbSet<ProductCategory> ProductCategories { get; set; }
   public DbSet<Client> Clients { get; set; }
   public DbSet<LoanApplication> LoanApplications { get; set; }
   public DbSet<Receiver> Receivers { get; set; }
   public DbSet<Status> Statuses { get; set; }
   public DbSet<TransactionType> TransactionTypes { get; set; }

}
