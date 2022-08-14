using LoansMonitoring.API.Repositories.Contracts;
using LoansMonitoring.ClassLib.DTOs.Status;
using LoansMonitoring.ClassLib.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace LoansMonitoring.API.Controllers;
[Route("api/Status")]
[ApiController]
public class StatusController : ControllerBase
{
	private readonly IStatusRepository _repo;

	public StatusController(IStatusRepository repo)
	{
		_repo = repo;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<StatusDto>>> GetStatuses()
	{
		try
		{
			var statuses = (await _repo.GetStatuses()).Select(s => s.AsStatusDto());
			if (statuses == null)
			{
				return NotFound();
			}
			return Ok(statuses);
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status404NotFound, ex.Message);
		}
	}
	[HttpGet("{id:int}")]
	public async Task<ActionResult<StatusDto>> GetStatus(int id)
	{
		try
		{
			var status = await _repo.GetStatus(id);
			if (status == null)
			{
				return BadRequest();
			}
			return Ok(status);

		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
		}
	}
	[HttpPost]
	public async Task<ActionResult<StatusDto>> AddStatus([FromBody] StatusAddDto dto)
	{
		try
		{
			Status status = new()
			{
				Title = dto.Title,
				Description = dto.Description,
			};
			await _repo.CreateStatus(status);
			return CreatedAtAction(nameof(GetStatus), new { id = status.Id }, status.AsStatusDto());
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	[HttpPatch("{id:int}")]
	public async Task<ActionResult<StatusDto>> UpdateStatus(int id, StatusUpdateDto dto)
	{
		try
		{
			var status = await _repo.UpdateStatus(id, dto);
			if (status == null)
			{
				return BadRequest();
			}

			return Ok(status.AsStatusDto());
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
		}
	}
	[HttpDelete("{id:int}")]
	public async Task<ActionResult<StatusDto>> DeleteStatus(int id)
	{
		try
		{
			var status = await _repo.DeleteStatus(id);
			if (status == null)
			{
				return BadRequest();
			}
			return status.AsStatusDto();
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
		}
	}
}
