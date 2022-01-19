using eugeneCollections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    interface ICollectionRepository
    {
        public void AddCollection(Collection collection);
        public void DeleteCollection(int id);
        public void UpdateCollection(int id);
        public void SaveCollection(Collection entity);//?
        public IQueryable<Collection> GetCollections();
        public IQueryable<Collection> GetCollectionsByUser(Guid Id);
    }
}
