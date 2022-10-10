using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Login(string Email, string Password)
        {
            return new AuthenticationResult
            {
                Id = Guid.NewGuid(),
                Email = Email,
                Token = "token"
            };
        }

        public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
        {
            return new AuthenticationResult
            {
                Id = Guid.NewGuid(),
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Token = "token"
            };
        }
    }
}