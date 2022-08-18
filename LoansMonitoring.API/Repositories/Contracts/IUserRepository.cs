using LoansMonitoring.ClassLib.DTOs.User;

namespace LoansMonitoring.API.Repositories.Contracts;

public interface IUserRepository
{
   Task<IEnumerable<User>> GetUsers();
   Task<User> GetUser(int id);
   Task<User> CreateUser(User user);
   Task<User> DeleteUser(int id);
   Task<User> UpdatUser(int id, UserUpdateDto dto);
   Task<User> GetUserByDisplayName(string name);

}