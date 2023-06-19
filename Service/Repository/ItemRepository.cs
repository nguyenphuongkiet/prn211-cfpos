using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class ItemRepository : RepositoryBase<Item> 
    {
        public ItemRepository() { }

        public Item getItemById(int id)
        {
            Item item = new Item();
            item = this.getAll().FirstOrDefault(p => p.Id == id, null);
            return item;
        }

        public Item getItemByName(string name)
        {
            Item item = new Item();
            item = this.getAll().FirstOrDefault(p => p.Name == name, null);
            return item;
        }

        public void createItem(string name, string description, decimal? price, bool status , int categoryId)
        {
            Item item = new Item
            {
                Name = name,
                Description = description,
                Price = price,
                Status = status,
                CategoryId = categoryId
            };

            this.create(item);
        }

    }
}
