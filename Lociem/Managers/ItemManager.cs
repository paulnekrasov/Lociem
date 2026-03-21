using Lociem.Models;
using Lociem.Interfaces;

namespace Lociem.Managers
{
    public class ItemManager : RepositoryManagerBase<Item>
    {
        public override void Update(Item item)
        {
            ArgumentNullException.ThrowIfNull(item);

            Item? existingItem = _entities.Find(i => i.Id == item.Id);
            if (existingItem == null)
            {
                throw new InvalidOperationException($"Item with Id of {item.Id} was not found.");
            }

            existingItem.Rename(item.Name);
            existingItem.ChangeDescription(item.Description);
            if (item.StorageLocation != null)
            {
                existingItem.AssignToStorageLocation(item.StorageLocation);
            }
        }

        public override List<Item> FindbyName(string name)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            return _entities.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }


    }
}
