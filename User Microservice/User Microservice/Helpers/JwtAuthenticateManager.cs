using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using User_Microservice.Models;
using User_Microservice.Services;

namespace User_Microservice.Helpers
{
    public class JwtAuthenticateManager : IJwtAuthenticateManager
    {
        private readonly IUserService userService;
        private readonly IConfiguration _configuration;
        public JwtAuthenticateManager(IUserService service, IConfiguration configuration)
        {
            userService = service;
            _configuration = configuration;
        }
        public Response Authenticate(UserCred userCred)
        {
            var user = userService.GetUsers().FirstOrDefault(x => x.UserName.Equals(userCred.UserName));

            if (user == null)
                return null;

            if (!user.Password.Equals(userCred.Password))
                return null;

            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                { 
                    new Claim(ClaimTypes.Name, userCred.UserName),
                    new Claim(ClaimTypes.Role, "USER")
                }),
                Expires = DateTime.Now.AddMinutes(15),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:UserSecret"])), SecurityAlgorithms.HmacSha256Signature)
            };

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

            return new Response 
            { 
                UserName = userCred.UserName,
                Token = jwtSecurityTokenHandler.WriteToken(token),
                ValidFrom = token.ValidFrom,
                ValidTo = token.ValidTo
            };
        }
    }
}
