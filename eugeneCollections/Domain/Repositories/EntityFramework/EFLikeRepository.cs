using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.EntityFramework
{
    public class EFLikeRepository:ILikeRepository
    {
        private readonly AppDbContext context;
        public EFLikeRepository(AppDbContext context)=>this.context=context;

        public void AddLike(string UserId, int ItemId)
        {
            Like like = new Like() { UserId=UserId, ItemId=ItemId};
            context.Likes.Add(like);
            context.SaveChanges();
        }

        public IQueryable<Like> GetLikes(int ItemId)
        {
           return context.Likes.Where(p=>p.ItemId==ItemId);
        }
    }
}
