using LoansMonitoring.ClassLib.DTOs.Client;
using LoansMonitoring.ClassLib.Extensions;

namespace LoansMonitoring.API.Controllers;
[Route("api/client")]
[ApiController]
public class ClientController : ControllerBase
{
   private readonly IClientRepository _repository;

   public ClientController(IClientRepository repository)
   {
      _repository = repository;
   }

   [HttpGet]
   public async Task<ActionResult<ClientDto>> GetClients()
   {
      try
      {
         var result = (await _repository.GetClients()).Select(c => c.AsClientDto());
         if (result == null)
         {
            return NotFound();
         }
         else
         {
            return Ok(result);
         }
      }
      catch (Exception)
      {
         return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving the data");
      }
   }
   [HttpGet("{id:int}")]
   public async Task<ActionResult<ClientDto>> GetClient(int id)
   {
      var result = await _repository.GetClient(id);
      if (result == null)
      {
         return BadRequest();
      }
      return Ok(result);
   }
   [HttpPost]
   public async Task<ActionResult<ClientDto>> AddClient([FromBody] ClientAddDto obj)
   {
      Client client = new()
      {
         LastName = obj.LastName,
         FirstName = obj.FirstName,
         MiddleName = obj.MiddleName
      };

      await _repository.AddClient(client);
      return CreatedAtAction(nameof(GetClient), new { id = client.Id }, client.AsClientDto());
   }
   [HttpPatch("{id:int}")]
   public async Task<ActionResult<ClientDto>> UpdateClient(int id, ClientUpdateDto dto)
   {
      try
      {
         var client = await _repository.UpdateClient(id, dto);
         if (client == null)
         {
            return NotFound();
         }
         else
         {
            var result = client.AsClientDto();
            return Ok(result);
         }
      }
      catch (Exception ex)
      {
         return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
      }
   }
   [HttpDelete("{id:int}")]
   public async Task<ActionResult<ClientDto>> DeleteClient(int id)
   {
      try
      {
         var client = await _repository.DeleteClient(id);
         if (client == null)
         {
            return NotFound();
         }
         var result = client.AsClientDto();
         return result;
      }
      catch (Exception ex)
      {
         return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
      }
   }
}
