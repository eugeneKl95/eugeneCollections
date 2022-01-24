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

        public void AddLike(string UserId, int CollectionId)
        {
            Like like = new Like() { UserId = UserId, CollectiionId=CollectionId};
            context.Likes.Add(like);
            context.SaveChanges();
        }

        public int GetCountLikesByItemId(int CollectionId)
        {
           return context.Likes.Where(p=>p.CollectiionId==CollectionId).Count();
        }
    }
}
