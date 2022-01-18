using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CollectionId { get; set; }
        public Tag tag { get; set; }
        List<Comment> Comments { get; set; }
    }
}
