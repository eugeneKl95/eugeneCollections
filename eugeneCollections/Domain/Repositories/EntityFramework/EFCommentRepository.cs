using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.EntityFramework
{
    public class EFCommentRepository : ICommentRepository
    {
        private readonly AppDbContext context;
        public EFCommentRepository(AppDbContext context) => this.context = context;

        public void AddComment(Comment comment) => context.Comments.Add(comment);
        
        public IQueryable<Comment> GetComments(int id)
        {
            return context.Comments.Where(g => g.ItemId == id);
        }
    }
}
