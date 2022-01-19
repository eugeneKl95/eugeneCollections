using eugeneCollections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    public interface ILikeRepository 
    {
        public IQueryable<Like> GetLikes(int ItemId);
        public void AddLike(string UserId, int ItemId);
    }
}
