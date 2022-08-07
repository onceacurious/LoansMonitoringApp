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
}
