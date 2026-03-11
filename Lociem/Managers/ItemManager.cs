using Lociem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Lociem.Interfaces;

namespace Lociem.Services
{
    public class ItemManager : IRepository<Item>
    {
        List<Item> items = new List<Item>();
        
        public void Add(Item item)
        {
            items.Add(item);
        }

       public void Delete(Item item)
        {

            Item? itemToDelete = items.Find(i => i.Id == item.Id);

            if (itemToDelete != null)
            {
                items.Remove(itemToDelete);
            }
        }
        public void Update(Item item)
        {

            Item? itemcheck = items.Find(i => i.Id == item.Id);      
            itemcheck?.Rename(item.Name);
            itemcheck?.ChangeDescription(item.Description);
            itemcheck?.AssignToStorageLocation(item.StorageLocation);
        }

        public Item? FindbyName(string name)
        {
            return items.Find(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public Item? FindbyId(int id)
        {
            return items.Find(i => i.Id == id);
        }
        public List<Item> GetAll()
        {
            return new List<Item>(items);
        }


    }
}
