using Lociem.Models;
using Lociem.Interfaces;

namespace Lociem.Managers
{
    public class StorageLocationManager : RepositoryManagerBase<StorageLocation>
    {
        public override void Update(StorageLocation storageLocation)
        {
            ArgumentNullException.ThrowIfNull(storageLocation);
            StorageLocation? existinglocationCheck = _entities.Find(s => s.Id == storageLocation.Id);

            if (existinglocationCheck == null)
            {
                throw new InvalidOperationException($"StorageLocation with Id of {storageLocation.Id} was not found.");
            }
            existinglocationCheck.Rename(storageLocation.Name);
            existinglocationCheck.ChangeDescription(storageLocation.Description);
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
                throw new InvalidOperationException($"Cannot delete StorageLocation with Id of {location.Id} because it has associated items.");
            }

            else
            {
                _entities.Remove(location);
            }
        }

         public override void Delete(StorageLocation location) { 
            throw new InvalidOperationException("Use Delete(location, items) instead to ensure there is no associated items with the location."); 
        
        }

    }
    }
