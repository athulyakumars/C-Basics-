using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Contracts.Authentication
{
    public class AuthenticationResponse
    {
        public Guid Id;
        public string FirstName;

        public string LastName;

        public string Email;

        public string Token;
    }
}