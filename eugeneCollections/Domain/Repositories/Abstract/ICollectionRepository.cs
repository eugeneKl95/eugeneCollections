using eugeneCollections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    public interface ICollectionRepository
    {
        public void AddCollection(Collection collection);
        public void DeleteCollection(int id);
        public void UpdateCollection(Collection collection);
        public void SaveCollection(Collection entity);//?
        public IQueryable<Collection> GetCollections();
        public IQueryable<Collection> GetCollectionsByUser(string Id);
    }
}
