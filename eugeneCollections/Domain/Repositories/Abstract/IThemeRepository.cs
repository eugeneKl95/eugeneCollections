using eugeneCollections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    interface IThemeRepository
    {
        public IQueryable<Theme> GetThemes();
    }
}
