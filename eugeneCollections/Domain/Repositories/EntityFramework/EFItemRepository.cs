using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.EntityFramework
{
    public class EFItemRepository : IItemRepository
    {
        private readonly AppDbContext context;
        public EFItemRepository(AppDbContext context) => this.context=context;
        public void AddItem(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            context.Items.Remove(context.Items.Where(h=>h.Id==id).FirstOrDefault());
            context.SaveChanges();
        }

        public IQueryable<Item> GetAllItems()
        {
            return context.Items;
        }

        public IQueryable<Item> GetItemByCollectionId(int id)
        {
            return context.Items.Where(s=>s.CollectionId==id);
        }

        public Item GetItemById(int id)
        {
            return context.Items.Where(k=>k.Id==id).FirstOrDefault();
        }

        public void UpdateItem(Item item)
        {
            context.Items.Update(item);
            context.SaveChanges();
        }
    }
}
