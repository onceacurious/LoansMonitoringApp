using LoansMonitoring.ClassLib.DTOs.Product;
using LoansMonitoring.ClassLib.Extensions;

namespace LoansMonitoring.API.Controllers;
[Route("api/product")]
[ApiController]
public class ProductController : ControllerBase
{
   private readonly IProductRepository _repository;

   public ProductController(IProductRepository repository)
   {
      _repository = repository;
   }
   [HttpGet]
   public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
   {
      try
      {
         var products = (await _repository.GetProducts())
            .Select(p => p.AsProductDto());

         if (products == null)
         {
            return NotFound();
         }
         else
         {
            return Ok(products);
         }
      }
      catch (Exception)
      {
         return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving the data");
      }
   }
   [HttpGet("{id:int}")]
   public async Task<ActionResult<ProductDto>> GetItem(int id)
   {
      try
      {
         var product = await _repository.GetProduct(id);

         if (product == null)
         {
            return BadRequest();
         }
         else
         {
            return Ok(product.AsProductDto());
         }
      }
      catch (Exception)
      {
         return StatusCode(StatusCodes.Status400BadRequest, "Product not found");
      }
   }
}
