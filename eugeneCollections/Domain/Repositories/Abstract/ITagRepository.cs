using eugeneCollections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    public interface ITagRepository
    {
        public void AddTag(Tag tag);
        public IQueryable<Tag> GetAllTags();
        public IQueryable<Tag> GetTagByCollection(int id);
    }
}
