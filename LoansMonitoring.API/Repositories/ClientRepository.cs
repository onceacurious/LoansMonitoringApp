namespace LoansMonitoring.API.Repositories;

public class ClientRepository : IClientRepository
{
   private readonly DbConnection _connection;

   public ClientRepository(DbConnection connection)
   {
      _connection = connection;
   }

   public async Task<IEnumerable<Client>> GetClients()
   {
      var result = await _connection.Clients.ToListAsync();
      return result;
   }
   public async Task<Client> GetClient(int id)
   {
      var result = await _connection.Clients.SingleOrDefaultAsync(c => c.Id == id);
      return result;
   }
   public Task<Client> UpdateClient(int id)
   {
      throw new NotImplementedException();
   }
   public Task<Client> DeleteClient(int id)
   {
      //try
      //{

      //}
      //catch (Exception)
      //{

      //   throw;
      //}
      throw new NotImplementedException();
   }

   public async Task<Client> AddClient(Client client)
   {
      var result = await _connection.AddAsync(client);
      await _connection.SaveChangesAsync();
      return result.Entity;
   }
}
