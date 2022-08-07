using LoansMonitoring.ClassLib.DTOs.Category;
using LoansMonitoring.ClassLib.DTOs.Client;
using LoansMonitoring.ClassLib.DTOs.Product;

namespace LoansMonitoring.ClassLib.Extensions;
public static class DtosConvertion
{
   public static IEnumerable<ProductCategotyDto> ConvertToDto(this IEnumerable<ProductCategory> productCategories, IEnumerable<Product> products)
   {
      var result = from productCategory in productCategories
                   join product in products
                   on productCategory.Product.Id equals product.Id
                   select new ProductCategotyDto
                   {
                      Id = productCategory.Id,
                      Name = productCategory.Name,
                      Description = productCategory.Description,
                      ProductId = productCategory.Product.Id,
                      ProductName = productCategory.Product.Name,
                      ProductDescription = productCategory.Product.Description,
                   };
      return result.ToList();

   }
   public static ProductCategotyDto ConvertToDto(this ProductCategory productCategory, Product product)
   {
      return new ProductCategotyDto
      {
         Id = productCategory.Id,
         Name = productCategory.Name,
         Description = productCategory.Description,
         ProductId = productCategory.Product.Id,
         ProductName = productCategory.Product.Name,
         ProductDescription = productCategory.Product.Description,
      };

   }

   public static ProductDto AsProductDto(this Product obj)
   {
      return new ProductDto
      {
         Id = obj.Id,
         Name = obj.Name,
         Description = obj.Description
      };
   }

   public static ClientDto AsClientDto(this Client obj)
   {
      return new ClientDto
      {
         Id = obj.Id,
         FullName = obj.FullName,
         LastName = obj.LastName,
         FirstName = obj.FirstName,
         MiddleName = obj.MiddleName
      };
   }

}
