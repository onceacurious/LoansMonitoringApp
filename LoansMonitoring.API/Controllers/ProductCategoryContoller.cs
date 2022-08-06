using LoansMonitoring.ClassLib.DTOs.Category;
using LoansMonitoring.ClassLib.Extensions;

namespace LoansMonitoring.API.Controllers;

[Route("api/product-category")]
[ApiController]
public class ProductCategoryContoller : ControllerBase
{
   private readonly IProductCategoryRepository _prod;
   private readonly IProductRepository _repository;

   public ProductCategoryContoller(IProductCategoryRepository prod, IProductRepository repository)
   {
      _prod = prod;
      _repository = repository;
   }

   [HttpGet]
   public async Task<ActionResult<IEnumerable<ProductCategotyDto>>> GetItems()
   {
      try
      {
         var categories = await _prod.GetCategories();
         var products = await _repository.GetProducts();

         if (categories == null || products == null)
         {
            return NotFound();
         }
         else
         {
            var result = categories.ConvertToDto(products);
            return Ok(result);
         }
      }
      catch (Exception)
      {
         return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving the data");
      }
   }

   [HttpGet("{id:int}")]
   public async Task<ActionResult<IEnumerable<ProductCategotyDto>>> GetItem(int id)
   {
      try
      {
         var categories = await _prod.GetCategory(id);

         if (categories == null)
         {
            return BadRequest();
         }
         else
         {
            var prod = await _repository.GetProduct(id);
            var result = categories.ConvertToDto(prod);
            return Ok(result);
         }
      }
      catch (Exception)
      {
         return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving the data");
      }
   }

}
