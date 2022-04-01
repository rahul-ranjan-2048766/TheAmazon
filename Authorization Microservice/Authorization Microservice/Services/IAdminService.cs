using Authorization_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Services
{
    public interface IAdminService
    {
        public void AddAdmin(Admin admin);
        public void DeleteAdmin(int id);
        public List<Admin> GetAdmins();
        public Admin GetAdminById(int id);
        public void UpdateAdmin(Admin admin);
    }
}
