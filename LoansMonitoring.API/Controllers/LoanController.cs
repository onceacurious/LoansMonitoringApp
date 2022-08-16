using LoansMonitoring.API.Repositories.Contracts;
using LoansMonitoring.ClassLib.DTOs.Loan;
using LoansMonitoring.ClassLib.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace LoansMonitoring.API.Controllers;
[Route("api/")]
[ApiController]
public class LoanController : ControllerBase
{
   private readonly ILoanRepository _repository;

   public LoanController(ILoanRepository repository)
   {
      _repository = repository;
   }
   [HttpGet("loans")]
   public async Task<ActionResult<LoanDto>> GetLoans()
   {
      try
      {
         var laons = (await _repository.GetLoans())
            .Select(l => l.AsLoanDto());
         if (laons == null)
         {
            return NotFound();
         }
         return Ok(laons);
      }
      catch (Exception ex)
      {
         return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
      }
   }
   [HttpPost("loan")]
   public async Task<ActionResult<LoanDto>> AddLoan([FromBody] LoanAddDto dto)
   {
      Loan loan = new()
      {
         Name = dto.Name,
         Description = dto.Description,

      };
      await _repository.CreateLoan(loan);
      return CreatedAtAction(nameof(GetLoan), new { id = loan.Id }, loan.AsLoanDto());
   }
   [HttpGet("loan/{id:int}")]
   public async Task<ActionResult<LoanDto>> GetLoan(int id)
   {
      var result = await _repository.GetLoan(id);
      if (result == null)
      {
         return BadRequest();
      }
      return Ok(result);
   }
   [HttpPatch("loan/{id:int}")]
   public async Task<ActionResult<LoanDto>> UpdateLoan(int id, LoanUpdateDto dto)
   {
      try
      {
         var loan = await _repository.UpdateLoan(id, dto);
         if (loan == null)
         {
            return NotFound();
         }
         return Ok(loan.AsLoanDto());
      }
      catch (Exception ex)
      {
         return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
      }
   }
   [HttpDelete("loan/{id:int}")]
   public async Task<ActionResult<LoanDto>> DeleteLoan(int id)
   {
      try
      {
         var loan = await _repository.DeleteLoan(id);
         if (loan == null)
         {
            return NotFound();
         }
         var result = loan.AsLoanDto();
         return result;
      }
      catch (Exception ex)
      {
         return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
      }
   }
}
