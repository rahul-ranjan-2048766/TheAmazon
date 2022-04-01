using Authorization_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authorization_Microservice.Repositories;

namespace Authorization_Microservice.Services
{
    public class MetaDataService : IMetaDataService
    {
        private readonly IMetaDataRepository repository;
        public MetaDataService(IMetaDataRepository metaDataRepository)
        {
            repository = metaDataRepository;
        }

        public void AddMeta(MetaData data)
        {
            repository.AddMeta(data);
        }

        public void DeleteMeta(int id)
        {
            repository.DeleteMeta(id);
        }

        public MetaData GetMetaById(int id)
        {
            return repository.GetMetaById(id);
        }

        public List<MetaData> GetMetas()
        {
            return repository.GetMetas();
        }

        public void UpdateMeta(MetaData data)
        {
            repository.UpdateMeta(data);
        }
    }
}
