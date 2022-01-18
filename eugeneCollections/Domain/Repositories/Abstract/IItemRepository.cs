using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    interface IItemRepository
    {
        public void AddItem();
        public void DeleteItem();
        public void UpdateItem();
        public Item GetItem(int id);
        public IQueryable<Item> GetItems();
    }
}
