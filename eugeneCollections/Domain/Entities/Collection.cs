using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Entities
{
    public class Collection
    {
        public Collection() => DateCreating = DateTime.UtcNow;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreating { get; set; }
        public int ThemeId { get; set; }
        public string UserId { get; set; }
        public string PathImg { get; set; }
        public User User { get; set; }
        public Theme Theme { get; set; }
    }
}
