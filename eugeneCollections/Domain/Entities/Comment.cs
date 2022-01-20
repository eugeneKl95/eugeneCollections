using System;

namespace eugeneCollections.Domain.Entities
{
    public class Comment
    {
        protected Comment() => DateAdd = DateTime.UtcNow;
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int ItemId { get; set; }
        public string UserId { get; set; }
        public DateTime DateAdd { get; set; }
    }
}