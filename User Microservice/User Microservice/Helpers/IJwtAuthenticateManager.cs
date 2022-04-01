using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Models;

namespace User_Microservice.Helpers
{
    public interface IJwtAuthenticateManager
    {
        public Response Authenticate(UserCred userCred);
    }
}
