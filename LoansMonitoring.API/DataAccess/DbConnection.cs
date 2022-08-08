namespace LoansMonitoring.ClassLib.DataAccess;
public class DbConnection : DbContext
{
   public DbConnection(DbContextOptions<DbConnection> options) : base(options)
   {

   }
   public DbSet<Client> Clients { get; set; }
   public DbSet<Receiver> Receivers { get; set; }
   public DbSet<Status> Statuses { get; set; }
   public DbSet<Loan> Loans { get; set; }
   public DbSet<Product> Products { get; set; }

}
