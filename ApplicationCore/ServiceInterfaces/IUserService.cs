using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.ServiceInterfaces
{
   public interface IUserService
   {
       Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel registerRequest);
       Task<LoginResponseModel> ValidateUser(string email, string password);
       Task<UserDetailsResponseModel> GetUserById(int id);
   }
}
