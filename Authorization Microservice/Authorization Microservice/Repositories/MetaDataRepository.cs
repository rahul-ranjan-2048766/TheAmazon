using Authorization_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Repositories
{
    public class MetaDataRepository : IMetaDataRepository
    {
        private readonly ApplicationDbContext _context;
        public MetaDataRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddMeta(MetaData data)
        {
            _context.MetaDatas.Add(data);
            _context.SaveChanges();
        }

        public void DeleteMeta(int id)
        {
            var data = _context.MetaDatas.FirstOrDefault(x => x.Id == id);
            if (data == null)
                throw new SystemException();
            _context.MetaDatas.Remove(data);
            _context.SaveChanges();
        }

        public MetaData GetMetaById(int id)
        {
            var data = _context.MetaDatas.FirstOrDefault(x => x.Id == id);
            if (data == null)
                throw new SystemException();
            return data;
        }

        public List<MetaData> GetMetas()
        {
            return _context.MetaDatas.ToList();
        }

        public void UpdateMeta(MetaData data)
        {
            _context.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
