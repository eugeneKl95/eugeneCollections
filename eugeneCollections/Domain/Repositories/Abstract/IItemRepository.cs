using eugeneCollections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    interface IItemRepository
    {
        public void AddItem(Item item);
        public void DeleteItem(int id);
        public void UpdateItem(int id);
        public Item GetItemById(int id);
        public IQueryable<Item> GetAllItems();
        public IQueryable<Item> GetItemByCollectionId(int id);//collectionId
    }
}
