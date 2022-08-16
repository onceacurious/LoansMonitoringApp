using LoansMonitoring.ClassLib.DTOs.Client;
using LoansMonitoring.ClassLib.DTOs.Loan;
using LoansMonitoring.ClassLib.DTOs.Product;
using LoansMonitoring.ClassLib.DTOs.Status;
using LoansMonitoring.ClassLib.DTOs.TransactionType;
using LoansMonitoring.ClassLib.DTOs.User;
using LoansMonitoring.ClassLib.DTOs.UserAuth;

namespace LoansMonitoring.ClassLib.Extensions;
public static class DtosConvertion
{
   //public static IEnumerable<ProductCategoryDto> ConvertToDto(this IEnumerable<ProductCategory> productCategories, IEnumerable<Product> products)
   //{
   //   var result = from productCategory in productCategories
   //                join product in products
   //                on productCategory.Product.Id equals product.Id
   //                select new ProductCategoryDto   //                {
   //                   Id = productCategory.Id,
   //                   Name = productCategory.Name,
   //                   Description = productCategory.Description,
   //                   ProductId = productCategory.Product.Id,
   //                   ProductName = productCategory.Product.Name,
   //                   ProductDescription = productCategory.Product.Description,
   //                };
   //   return result.ToList();

   //}
   //public static ProductCategoryDto ConvertToDto(this ProductCategory productCategory, Product product)
   //{
   //   return new ProductCategoryDto
   //   {
   //      Id = productCategory.Id,
   //      Name = productCategory.Name,
   //      Description = productCategory.Description,
   //      ProductId = productCategory.Product.Id,
   //      ProductName = productCategory.Product.Name,
   //      ProductDescription = productCategory.Product.Description,
   //   };

   //}
   //public static ProductCategoryDto AsCategoryDto(this ProductCategory productCategory)
   //{
   //   return new ProductCategoryDto
   //   {
   //      Id = productCategory.Id,
   //      Name = productCategory.Name,
   //      Description = productCategory.Description,
   //      ProductId = productCategory.Product.Id,
   //   };

   //}

   public static UserAuthDto AsUserAuthDto(this UserAuth obj)
   {
      return new UserAuthDto
      {
         Id = obj.Id,
         Username = obj.User.Username,
      };
   }

   public static TransactionDto AsTransactioDto(this TransactionType obj)
   {
      return new TransactionDto
      {
         Id = obj.Id,
         Title = obj.Title,
         Description = obj.Description
      };
   }
   public static StatusDto AsStatusDto(this Status obj)
   {
      return new StatusDto
      {
         Id = obj.Id,
         Title = obj.Title,
         Description = obj.Description
      };
   }

   public static UserDto AsUserDto(this User obj)
   {
      return new UserDto
      {
         Id = obj.Id,
         ObjectId = obj.ObjectId,
         FirstName = obj.FirstName,
         LastName = obj.LastName,
         MiddleName = obj.MiddleName,
         Position = obj.Position,
      };
   }

   public static ProductDto AsProductDto(this Product obj)
   {
      return new ProductDto
      {
         Id = obj.Id,
         Name = obj.Name,
         Description = obj.Description,
         LoanId = obj.LoanId
      };
   }

   public static LoanDto AsLoanDto(this Loan obj)
   {
      return new LoanDto
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
         LastName = obj.LastName,
         FirstName = obj.FirstName,
         MiddleName = obj.MiddleName
      };
   }

}
