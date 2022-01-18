using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Entities
{
    public class Like
    {
        public Guid UserId { get; set; }
        public int ItemId { get; set; }
    }
}
