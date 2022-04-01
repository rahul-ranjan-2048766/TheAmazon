using Authorization_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _context;
        public AdminRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        public void DeleteAdmin(int id)
        {
            var admin = _context.Admins.FirstOrDefault(x => x.Id == id);
            if (admin == null)
                throw new SystemException();
            _context.Admins.Remove(admin);
            _context.SaveChanges();
        }

        public Admin GetAdminById(int id)
        {
            var admin = _context.Admins.FirstOrDefault(x => x.Id == id);
            if (admin == null)
                throw new SystemException();
            return admin;
        }

        public List<Admin> GetAdmins()
        {
            return _context.Admins.ToList();
        }

        public void UpdateAdmin(Admin admin)
        {
            _context.Entry(admin).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
