using Authorization_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Repositories
{
    public interface IMetaDataRepository
    {
        public void AddMeta(MetaData data);
        public void DeleteMeta(int id);
        public List<MetaData> GetMetas();
        public MetaData GetMetaById(int id);
        public void UpdateMeta(MetaData data);
    }
}
