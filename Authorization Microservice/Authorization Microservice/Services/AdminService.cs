using Authorization_Microservice.Models;
using Authorization_Microservice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository repository;
        public AdminService(IAdminRepository adminRepository)
        {
            repository = adminRepository;
        }
        public void AddAdmin(Admin admin)
        {
            repository.AddAdmin(admin);
        }

        public void DeleteAdmin(int id)
        {
            repository.DeleteAdmin(id);
        }

        public Admin GetAdminById(int id)
        {
            return repository.GetAdminById(id);
        }

        public List<Admin> GetAdmins()
        {
            return repository.GetAdmins();
        }

        public void UpdateAdmin(Admin admin)
        {
            repository.UpdateAdmin(admin);
        }
    }
}
