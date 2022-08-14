using LoansMonitoring.ClassLib.DTOs.Status;

namespace LoansMonitoring.API.Repositories.Contracts;

public interface IStatusRepository
{
   Task<IEnumerable<Status>> GetStatuses();
   Task<Status> GetStatus(int id);
   Task<Status> CreateStatus(Status status);
   Task<Status> UpdateStatus(int id, StatusUpdateDto dto);
   Task<Status> DeleteStatus(int id);

}