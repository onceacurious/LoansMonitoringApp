namespace LoansMonitoring.API.Repositories.Contracts;

public interface IClientRepository
{
   Task<Client> AddClient(Client client);
   Task<Client> UpdateClient(int id);
   Task<Client> GetClient(int id);
   Task<IEnumerable<Client>> GetClients();
   Task<Client> DeleteClient(int id);
}