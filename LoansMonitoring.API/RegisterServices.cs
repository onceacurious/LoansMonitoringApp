using LoansMonitoring.API.Repositories;
using LoansMonitoring.API.Repositories.Contracts;

namespace LoansMonitoring.API;

public static class RegisterServices
{
   public static void ConfigureServices(this WebApplicationBuilder builder)
   {
      builder.Services.AddControllers();

      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();

      // User Code
      builder.Services.AddMemoryCache();
      builder.Services.AddDbContextPool<DbConnection>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("DevConn"))
      );

      // Repositories
      builder.Services.AddScoped<ILoanRepository, LoanRepository>();
      builder.Services.AddScoped<IProductRepository, ProductRepository>();
      //builder.Services.AddScoped<IClientRepository, ClientRepository>();
   }
}
