using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Claims;
using System.Security.Cryptography;
using ApplicationCore.Entities;
using ApplicationCore.Exceptions;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel registerRequest)
        {
            // first check whether the user with same email exists in our database.
            var dbUser = await _userRepository.GetUserByEmail(registerRequest.Email);

            // if user exists
            if (dbUser != null)
            {
                throw new ConflictException("User Already exists, please try to login");
            }

            // generate a unique salt
            var salt = CreateSalt();

            // hash the password with salt generated in the above step
            var hashedPassword = CreateHashedPassword(registerRequest.Password, salt);

            // then create User Object and save it to database with UserRepository 
            var user = new User()
            {
                FirstName = registerRequest.FirstName,
                LastName = registerRequest.LastName,
                Email = registerRequest.Email,
                Salt = salt,
                HashedPassword = hashedPassword,
                DateOfBirth = registerRequest.DateTime,
            };

            // call repository to save User info that included salt and hashed password
            var createdUser = await _userRepository.AddAsync(user);

            // map user object to UserRegisterResponseModel object
            var createdUserResponse = new UserRegisterResponseModel
            {
                Id = createdUser.Id,
                Email = createdUser.Email,
                FirstName = createdUser.FirstName,
                LastName = createdUser.LastName
            };

            return createdUserResponse;
        }

        public async Task<LoginResponseModel> ValidateUser(string email, string password)
        {
            // get the user info my email by using GetUserByEmail

            var dbUser = await _userRepository.GetUserByEmail(email);

            if (dbUser == null)
            {
                return null;
            }

            var hashedPassword = CreateHashedPassword(password, dbUser.Salt);

            if (hashedPassword == dbUser.HashedPassword)
            {
                // passwords match so create response model object

                var loginResponseModel = new LoginResponseModel
                {
                    Id = dbUser.Id, Email = dbUser.Email, FirstName = dbUser.FirstName, LastName = dbUser.LastName
                };
                return loginResponseModel;
            }

            return null;
        }

        public async Task<UserDetailsResponseModel> GetUserById(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                throw new NotFoundException("user does not exist");
            }

            var userDetails = new UserDetailsResponseModel
            {
                Id = user.Id, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName
            };

            return userDetails;
        }

        private string CreateSalt()
        {
            byte[] randomBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            return Convert.ToBase64String(randomBytes);
        }

        private string CreateHashedPassword(string password, string salt)
        {
            var hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Convert.FromBase64String(salt),
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}