namespace LoansMonitoring.API.Repositories;

public class UserAuthRepository
{
   private readonly DbConnection _db;

   public UserAuthRepository(DbConnection db)
   {
      _db = db;
   }
   public Task<UserAuth> RegisterUser(UserAuth userAuth)
   {
      return null;
   }

}
