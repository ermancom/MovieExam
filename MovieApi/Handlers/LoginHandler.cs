using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Movie.BusinessLayer.Queries;
using Movie.Entities;
using Movie.Entities.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Movie.BusinessLayer.Handlers
{
    public class LoginHandler : IRequestHandler<LoginRequestQuery, LoginModel>
    {
        private IBusinessService businessService;
        private IConfiguration config;

        public LoginHandler(IBusinessService businessService, IConfiguration config)
        {
            this.businessService = businessService;
            this.config = config;
        }

        public Task<LoginModel> Handle(LoginRequestQuery request, CancellationToken cancellationToken)
        {
            var user = businessService.Authentications.GetUser(request.Username, request.Password);
            if(user is null)
            {
                return null;
            }

            return Task.FromResult(new LoginModel() { Token = GenerateToken(user) });
        }

        public string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
 
            var claims = new[]
            {
              new Claim(JwtRegisteredClaimNames.Sub, user.ID.ToString()),
              new Claim(JwtRegisteredClaimNames.Sub, user.Username),
              new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddDays(1), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
         }
    }
}
