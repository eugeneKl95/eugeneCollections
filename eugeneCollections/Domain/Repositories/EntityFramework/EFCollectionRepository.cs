using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.EntityFramework
{
    public class EFCollectionRepository : ICollectionRepository
    {
        private readonly AppDbContext context;
        public EFCollectionRepository(AppDbContext context) => this.context = context;
        public void AddCollection(Collection collection)
        {
            context.Collections.Add(collection);
            context.SaveChanges();
        }

        public void DeleteCollection(int id)
        {
            context.Collections.Remove(context.Collections.Where(f => f.Id == id).FirstOrDefault());
            context.SaveChanges();
        }

        public IQueryable<Collection> GetCollections() //get all collections
        {
            return context.Collections;
        }

        public IQueryable<Collection> GetCollectionsByUser(string Id)
        {
            return context.Collections.Where(t=>t.UserId==Id);
        }

        public void SaveCollection(Collection entity)//????
        {
            ;
        }

        public void UpdateCollection(Collection collection)
        {
            context.Collections.Update(collection);
        }
    }
}
