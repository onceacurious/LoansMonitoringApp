namespace LoansMonitoring.API;

public static class RegisterServices
{
   public static void ConfigureServices(this WebApplicationBuilder builder)
   {
      builder.Services.AddControllers();

      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();
   }
}
