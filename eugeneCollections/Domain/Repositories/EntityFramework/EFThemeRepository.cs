using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.EntityFramework
{
    public class EFThemeRepository:IThemeRepository
    {
        private readonly AppDbContext context;
        public EFThemeRepository(AppDbContext context) => this.context = context;

        public IQueryable<Theme> GetThemes()
        {
            return context.Themes;
        }
    }
}
