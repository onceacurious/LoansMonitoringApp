using LoansMonitoring.ClassLib.DTOs.User;

namespace LoansMonitoring.API.Controllers;
[Route("api/")]
[ApiController]
public class UserController : ControllerBase
{
	private readonly IUserRepository _repo;
	/*
	 Still need to implement user Authentication, Authorization, and Refresh token
	 */
	public UserController(IUserRepository repo)
	{
		_repo = repo;
	}

	[HttpGet("users")]
	public async Task<ActionResult<UserDto>> GetUsers()
	{
		try
		{
			var users = (await _repo.GetUsers())
				.Select(u => u.AsUserDto());
			if (users == null)
			{
				return NotFound();
			}
			return Ok(users);
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	[HttpGet("user/{id:int}")]
	public async Task<ActionResult<UserDto>> GetUser(int id)
	{
		try
		{
			var user = await _repo.GetUser(id);
			if (user == null)
			{
				return BadRequest();
			}
			return Ok(user);

		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}


	}
	[HttpPost("user")]
	public async Task<ActionResult<UserDto>> AddUser([FromBody] UserCreateDto dto)
	{
		User user = new()
		{
			FirstName = dto.FirstName,
			LastName = dto.LastName,
			MiddleName = dto.MiddleName,

		};
		await _repo.CreateUser(user);
		return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user.AsUserDto());
	}
	[HttpDelete("user/{id:int}")]
	public async Task<ActionResult<UserDto>> DeleteUser(int id)
	{
		try
		{
			var user = await _repo.DeleteUser(id);
			if (user == null)
			{
				return NotFound();
			}
			var result = user.AsUserDto();
			return result;
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	[HttpPatch("user/{id:int}")]
	public async Task<ActionResult<UserDto>> UpdateUser(int id, UserUpdateDto dto)
	{
		try
		{
			var user = await _repo.UpdatUser(id, dto);
			if (user == null)
			{
				return NotFound();
			}
			var result = user.AsUserDto();
			return Ok(result);
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	[HttpGet("user/{name}")]
	public async Task<ActionResult<UserDto>> GetUserByDisplayName(string name)
	{
		try
		{
			var user = await _repo.GetUserByDisplayName(name);
			if (user == null)
			{
				return BadRequest();
			}
			return Ok(user);
		}
		catch (Exception ex)
		{

			return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
		}
	}
}
