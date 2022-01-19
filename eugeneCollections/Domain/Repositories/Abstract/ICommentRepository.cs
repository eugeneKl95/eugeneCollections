using eugeneCollections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    public interface ICommentRepository
    {
        public void AddComment(Comment comment);
        public IQueryable<Comment> GetComments(int id);//get comment by ItemId
    }
}
