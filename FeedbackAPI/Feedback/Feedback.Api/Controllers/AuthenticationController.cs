using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedback.Application.Services;
using Feedback.Contracts.Authentication;
using Feedback.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Feedback.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        private readonly IAuthenticationInfrastructure _authInfrastructure;

        public AuthenticationController(IAuthenticationService authenticationService,
        IAuthenticationInfrastructure authInfrastructure)
        {
            _authenticationService = authenticationService;
            _authInfrastructure = authInfrastructure;
        }
        
        [HttpPost("Register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);
            _authInfrastructure.StoreInfo();
            var AuthenticationResponse = new AuthenticationResponse
            {
                Id = authResult.Id,
                FirstName = authResult.FirstName,
                LastName = authResult.LastName,
                Email = authResult.Email,
                Token = authResult.Token
            };
            return Ok(AuthenticationResponse);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(request.Email, request.Password);
            var AuthenticationResponse = new AuthenticationResponse
            {
                Id = authResult.Id,
                Email = authResult.Email,
                Token = authResult.Token
            };
            return Ok(authResult);
        }
    }
}