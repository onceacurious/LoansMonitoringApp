using LoansMonitoring.ClassLib.DTOs.User;
using System.Security.Cryptography;

namespace LoansMonitoring.API.Repositories;

public class UserRepository : IUserRepository
{
	private readonly DbConnection _db;
	public static User user = new();

	public UserRepository(DbConnection db)
	{
		_db = db;
	}

	public async Task<IEnumerable<User>> GetUsers()
	{
		var users = await _db.Users.ToListAsync();
		return users;
	}

	public async Task<User> GetUser(int id)
	{
		var user = await _db.Users.SingleOrDefaultAsync(x => x.Id == id);
		return user;
	}

	public async Task<User> CreateUser(UserCreateDto dto)
	{
		CreatePasswordHash(dto.Password, out byte[] passwordHash, out byte[] passwordSalt);
		user.PasswordSalt = passwordSalt;
		user.PasswordHash = passwordHash;
		await _db.AddAsync(dto);
		await _db.SaveChangesAsync();
		return user;
	}
	public async Task<User> DeleteUser(int id)
	{
		var user = await _db.Users.FindAsync(id);
		if (user != null)
		{
			_db.Users.Remove(user);
			await _db.SaveChangesAsync();
			return user;
		}
		return null;
	}
	public async Task<User> UpdatUser(int id, UserUpdateDto dto)
	{
		var user = await _db.Users.FindAsync(id);
		if (user != null)
		{
			user.FirstName = dto.FirstName;
			user.MiddleName = dto.MiddleName;
			user.LastName = dto.LastName;
			await _db.SaveChangesAsync();
			return user;
		}
		return null;
	}

	public async Task<User> GetUserByDisplayName(string name)
	{
		var users = await _db.Users.ToListAsync();
		var user = users.First(u => u.Username == name);
		return user;
	}

	private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
	{
		using (var hmac = new HMACSHA512())
		{
			passwordSalt = hmac.Key;
			passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
		}
	}
}
