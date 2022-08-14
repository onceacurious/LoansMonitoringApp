using LoansMonitoring.API.Repositories.Contracts;
using LoansMonitoring.ClassLib.DTOs.Status;

namespace LoansMonitoring.API.Repositories;

public class StatusRepository : IStatusRepository
{
	private readonly DbConnection _db;

	public StatusRepository(DbConnection db)
	{
		_db = db;
	}

	public async Task<IEnumerable<Status>> GetStatuses()
	{
		var statuses = await _db.Statuses.ToListAsync();
		return statuses;
	}
	public async Task<Status> GetStatus(int id)
	{
		var status = await _db.Statuses.SingleOrDefaultAsync(s => s.Id == id);
		return status;
	}
	public async Task<Status> CreateStatus(Status status)
	{
		var result = await _db.AddAsync(status);
		await _db.SaveChangesAsync();
		return result.Entity;
	}

	public async Task<Status> UpdateStatus(int id, StatusUpdateDto dto)
	{
		var status = await _db.Statuses.FindAsync(id);
		if (status != null)
		{
			status.Title = dto.Title;
			status.Description = dto.Description;
			await _db.SaveChangesAsync();
			return status;
		}
		return null;
	}

	public async Task<Status> DeleteStatus(int id)
	{
		var status = await _db.Statuses.FindAsync(id);
		if (status != null)
		{
			_db.Statuses.Remove(status);
			await _db.SaveChangesAsync();
			return status;
		}

		return null;
	}
}
