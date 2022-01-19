using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.EntityFramework
{
    
    public class EFTagRepository: ITagRepository
    {
        private readonly AppDbContext context;

        public EFTagRepository(AppDbContext context) =>this.context=context;
        public void AddTag(Tag tag)
        {
            context.Tags.Add(tag);
            context.SaveChanges();
        }

        public IQueryable<Tag> GetAllTags()
        {
            return context.Tags;
        }

        public IQueryable<Tag> GetTagByItem(int id)
        {
            return context.Tags.Where(j=>j.ItemId==id);
        }
    }
}
