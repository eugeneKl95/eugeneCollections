using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Entities
{
    public class User: IdentityUser
    {
        public List<Collection> userCollections { get; set; }
        public string State { get; set; }
    }
}
