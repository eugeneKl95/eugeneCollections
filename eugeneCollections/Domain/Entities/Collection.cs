﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Entities
{
    public class Collection
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateCreating { get; set; }
        public int ThemeId { get; set; }
        public Guid UserId { get; set; }
    }
}