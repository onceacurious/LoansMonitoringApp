using LoansMonitoring.API.Repositories.Contracts;
using LoansMonitoring.ClassLib.DTOs.Product;
using LoansMonitoring.ClassLib.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace LoansMonitoring.API.Controllers;
[Route("api/products")]
[ApiController]
public class ProductController : ControllerBase
{
	private readonly IProductRepository _repo;

	public ProductController(IProductRepository repo)
	{
		_repo = repo;
	}
	[HttpGet]
	public async Task<ActionResult<ProductDto>> GetProducts()
	{
		try
		{
			var products = (await _repo.GetProducts())
				.Select(p => p.AsProductDto());
			if (products == null)
			{
				return NotFound();
			}
			return Ok(products);
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	[HttpPost]
	public async Task<ActionResult<ProductDto>> AddProduct([FromBody] ProductCreateDto dto)
	{
		Product product = new()
		{
			Name = dto.Name,
			Description = dto.Description,
			LoanId = dto.LoanId
		};
		await _repo.AddProduct(product);
		return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product.AsProductDto());
	}

	[HttpGet("{id:int}")]
	public async Task<ActionResult<ProductDto>> GetProduct(int id)
	{
		var result = await _repo.GetProduct(id);
		if (result == null)
		{
			return BadRequest();
		}
		return Ok(result);
	}
	[HttpPatch("{id:int}")]
	public async Task<ActionResult<ProductDto>> UpdateProduct(int id, ProductUpdateDeleteDto dto)
	{
		try
		{
			var prod = await _repo.UpdateProduct(id, dto);
			if (prod == null)
			{
				return NotFound();
			}
			var result = prod.AsProductDto();
			return Ok(result);
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	[HttpDelete("{id:int}")]
	public async Task<ActionResult<ProductDto>> DeleteProduct(int id)
	{
		try
		{
			var prod = await _repo.DeleteProduct(id);
			if (prod == null)
			{
				return NotFound();
			}
			var result = prod.AsProductDto();
			return result;
		}
		catch (Exception ex)
		{
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}


}
