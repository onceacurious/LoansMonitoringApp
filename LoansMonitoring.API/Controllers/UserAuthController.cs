using LoansMonitoring.ClassLib.DTOs.UserAuth;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace LoansMonitoring.API.Controllers;
[Route("api/user_auth")]
[ApiController]
public class UserAuthController : ControllerBase
{
   public static UserAuth userAuth = new();

   // User Authentication and Authorization to be implemented
   [HttpPost("register")]
   public async Task<ActionResult<UserAuthDto>> Register(UserAuthRegDto request)
   {
      CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
      userAuth.PasswordHash = passwordHash;
      userAuth.PasswordSalt = passwordSalt;
      request.Username = request.Username;
      return Ok(userAuth);
   }

   [HttpPost("login")]
   public async Task<ActionResult<string>> Login(UserAuthDto request)
   {
      return null!;
   }
   private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
   {
      using (HMACSHA512 hmac = new())
      {
         passwordSalt = hmac.Key;
         passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
      }
   }
}
