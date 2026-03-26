using Lociem.Models;
using Lociem.Interfaces;

namespace Lociem.Managers
{
    public class ItemManager : RepositoryManagerBase<Item>
    {
        public ItemManager(DataManager dataManager) : base(dataManager)
        {
        }

        public override void Add(Item item)
        {
            base.Add(item);
            SaveToFile();
        }

        public override void Delete(Item item)
        {
            base.Delete(item);
            SaveToFile();
        }

        public override void Update(Item item)
        {
            ArgumentNullException.ThrowIfNull(item);

            Item? existingItem = _entities.Find(i => i.Id == item.Id);
            if (existingItem == null)
            {
                throw new InvalidOperationException($"Item with ID {item.Id} was not found.");
            }

            existingItem.Rename(item.Name);
            existingItem.ChangeDescription(item.Description);
            if (item.StorageLocation != null)
            {
                existingItem.AssignToStorageLocation(item.StorageLocation);
            }

            SaveToFile();
        }

        public override List<Item> FindByName(string name)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            return _entities.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void SaveToFile()
        {
            _dataManager.SaveItems(GetAll());
        }

    }
}
