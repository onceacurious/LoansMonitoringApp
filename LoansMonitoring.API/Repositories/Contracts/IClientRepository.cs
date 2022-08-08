using LoansMonitoring.ClassLib.DTOs.Client;

namespace LoansMonitoring.API.Repositories.Contracts;

public interface IClientRepository
{
   Task<Client> AddClient(Client client);
   Task<Client> UpdateClient(int id, ClientUpdateDto dto);
   Task<Client> GetClient(int id);
   Task<IEnumerable<Client>> GetClients();
   Task<Client> DeleteClient(int id);
}