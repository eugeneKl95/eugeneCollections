using System;

namespace eugeneCollections.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int ItemId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateAdd { get; set; }
    }
}