using Authorization_Microservice.Models;
using Authorization_Microservice.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Authorization_Microservice.Helpers
{
    public class JwtAuthenticateManager : IJwtAuthenticateManager
    {
        private readonly IConfiguration _configuration;
        private readonly IAdminService service;
        public JwtAuthenticateManager(IConfiguration configuration, IAdminService adminService)
        {
            _configuration = configuration;
            service = adminService;
        }

        public Response Authenticate(UserCred userCred)
        {
            var admin = service.GetAdmins().FirstOrDefault(x => x.UserName.Equals(userCred.UserName));
            
            if (admin == null)
                return null;

            if (!admin.Password.Equals(userCred.Password))
                return null;

            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor 
            { 
                Subject = new ClaimsIdentity(new Claim[] 
                { 
                    new Claim(ClaimTypes.Name, userCred.UserName),
                    new Claim(ClaimTypes.Role, "ADMIN")
                }),
                Expires = DateTime.Now.AddMinutes(15),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:SecretKey"])), SecurityAlgorithms.HmacSha256Signature)
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
