using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Application.Services
{
    public interface IAuthenticationService
    {
        AuthenticationResult Register(string FirstName, string LastName, string Email, string Password);

        AuthenticationResult Login(string Email, string Password);

    }
}