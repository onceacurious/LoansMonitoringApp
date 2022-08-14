namespace LoansMonitoring.ClassLib.DataAccess;
public class DbConnection : DbContext
{
   public DbConnection(DbContextOptions<DbConnection> options) : base(options)
   {

   }
   public DbSet<Loan> Loans { get; set; } = null!;
   public DbSet<Product> Products { get; set; } = null!;
   public DbSet<User> Users { get; set; } = null!;
   public DbSet<Status> Statuses { get; set; }
   //public DbSet<Client> Clients { get; set; }

}
