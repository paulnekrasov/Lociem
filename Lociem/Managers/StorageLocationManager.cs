using Lociem.Models;
using Lociem.Interfaces;

namespace Lociem.Managers
{
    public class StorageLocationManager : RepositoryManagerBase<StorageLocation>
    {
        public StorageLocationManager(DataManager dataManager) : base(dataManager)
        {
        }

        public override void Add(StorageLocation storageLocation)
        {
            base.Add(storageLocation);
            SaveToFile();
        }

        public override void Update(StorageLocation storageLocation)
        {
            ArgumentNullException.ThrowIfNull(storageLocation);
            StorageLocation? existinglocationCheck = _entities.Find(s => s.Id == storageLocation.Id);

            if (existinglocationCheck == null)
            {
                throw new InvalidOperationException($"Storage location with ID {storageLocation.Id} was not found.");
            }
            existinglocationCheck.Rename(storageLocation.Name);
            existinglocationCheck.ChangeDescription(storageLocation.Description);
            SaveToFile();
        }

        public override List<StorageLocation> FindbyName(string name)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            return _entities.Where(i => i.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void Delete(StorageLocation location, List<Item> items)
        {
            ArgumentNullException.ThrowIfNull(location);
            ArgumentNullException.ThrowIfNull(items);
            bool hasItems = items.Any(i => i.StorageLocationId == location.Id);
            if (hasItems)
            {
                throw new InvalidOperationException($"Cannot delete storage location with ID {location.Id} because it has associated items.");
            }

            else
            {
                Delete(location);
            }
        }

         public override void Delete(StorageLocation location) { 
            base.Delete(location);
            SaveToFile();
        }

        private void SaveToFile()
        {
            _dataManager.SaveLocations(GetAll());
        }


    }
    }
