//using LoansMonitoring.ClassLib.DTOs.Client;

//namespace LoansMonitoring.API.Repositories;

//public class ClientRepository : IClientRepository
//{
//   private readonly DbConnection _connection;

//   public ClientRepository(DbConnection connection)
//   {
//      _connection = connection;
//   }

//   public async Task<IEnumerable<Client>> GetClients()
//   {
//      var result = await _connection.Clients.ToListAsync();
//      return result;
//   }
//   public async Task<Client> GetClient(int id)
//   {
//      var result = await _connection.Clients.SingleOrDefaultAsync(c => c.Id == id);
//      return result;

//   }
//   public async Task<Client> UpdateClient(int id, ClientUpdateDto dto)
//   {
//      var client = await _connection.Clients.FindAsync(id);
//      if (client != null)
//      {
//         client.FirstName = dto.FirstName;
//         client.LastName = dto.LastName;
//         client.MiddleName = dto.MiddleName;
//         await _connection.SaveChangesAsync();
//         return client;
//      }
//      return null;


//   }
//   public async Task<Client> DeleteClient(int id)
//   {
//      var client = await _connection.Clients.FindAsync(id);
//      if (client != null)
//      {
//         _connection.Clients.Remove(client);
//         await _connection.SaveChangesAsync();
//      }
//      return null;
//   }

//   public async Task<Client> AddClient(Client client)
//   {
//      var result = await _connection.AddAsync(client);
//      await _connection.SaveChangesAsync();
//      return result.Entity;
//   }
//}
