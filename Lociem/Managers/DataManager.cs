using Lociem.Models;
using System.IO;
using System.Text.Json;

namespace Lociem.Managers
{
    public class DataManager
    {

        private readonly string _itemsFilePath;
        private readonly string _storageLocationsFilePath;

        public DataManager()
        {
            _itemsFilePath = Path.Combine(AppContext.BaseDirectory, "items.json");
            _storageLocationsFilePath = Path.Combine(AppContext.BaseDirectory, "storagelocations.json");
        }
        public void SaveItems(List<Item> items)
        {
            string json = JsonSerializer.Serialize(items);
            File.WriteAllText(_itemsFilePath, json);
        }

        public void SaveLocations(List<StorageLocation> locations)
        {

            string json = JsonSerializer.Serialize(locations);
            File.WriteAllText(_storageLocationsFilePath, json);

        }

        public List<Item> LoadItems()
        {

            if (!File.Exists(_itemsFilePath))
            {

                return new List<Item>();
            }
            string json = File.ReadAllText(_itemsFilePath);
            return JsonSerializer.Deserialize<List<Item>>(json) ?? new List<Item>();
        }

        public List<StorageLocation> LoadLocations()
        {
            if (!File.Exists(_storageLocationsFilePath))
            {

                return new List<StorageLocation>();
            }
            string json = File.ReadAllText(_storageLocationsFilePath);
            return JsonSerializer.Deserialize<List<StorageLocation>>(json) ?? new List<StorageLocation>();
        }


        public void ResolveStorageLocationLinks(List<StorageLocation> storageLocations, List<Item> items)
        {
            foreach(var item in items)
            {

                StorageLocation? location = storageLocations.FirstOrDefault(loc => loc.Id == item.StorageLocationId);


                if (location != null)
                {
                    item.AssignToStorageLocation(location);

                }

                else
                {
                    throw new Exception($"Storage location with ID {item.StorageLocationId} not found for item {item.Name} (ID: {item.Id})");
                }
            }

        }
        public void ClearData()
        {
            if (File.Exists(_itemsFilePath))
            {
                File.Delete(_itemsFilePath);
            }
            if (File.Exists(_storageLocationsFilePath))
            {
                File.Delete(_storageLocationsFilePath);
            }
        }
    }
}
