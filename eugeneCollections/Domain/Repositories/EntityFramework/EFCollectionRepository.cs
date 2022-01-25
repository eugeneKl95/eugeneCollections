using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
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
            return context.Collections.Include(t => t.Theme).Include(u=>u.User)
                .Include(f=>f.Comments).Include(d=>d.Tags);
        }

        public IQueryable<Collection> GetCollectionsByUser(string Id)
        {
            return context.Collections.Include(u=>u.User).Include(t=>t.Theme)
                .Include(f => f.Comments).Include(d => d.Tags).Where(t=>t.UserId==Id);
        }

        public Collection GetCollectionById(int id)
        {
            return context.Collections.Where(f => f.Id == id).FirstOrDefault(); 
        }

        public void UpdateCollection(Collection collection)
        {
            context.Collections.Update(collection);
            context.SaveChanges();
        }        

        public IQueryable<Collection> GetCollectionsByThemeId(int id)
        {
            return context.Collections.Include(u => u.User).Include(t => t.Theme)
                .Include(f => f.Comments).Include(d => d.Tags).Where(k => k.ThemeId == id);
        }
    }
}
