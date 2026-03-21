using Lociem.Interfaces;
using Lociem.Models;
using System.IO;
using System.Text.Json;

    namespace Lociem.Managers
{
    public class DataManager
    {
        public void SaveItems(List<Item> items)
        {
            string json = JsonSerializer.Serialize(items);
            File.WriteAllText("items.json", json);
        }
        public void SaveLocations(List<StorageLocation> locations) {

            string json = JsonSerializer.Serialize(locations);
            File.WriteAllText("storagelocations.json", json);

        }
        public List<Item> LoadItems() {

            if (!File.Exists("items.json")) {

                return new List<Item>();
            }
            string json = File.ReadAllText("items.json");
            return JsonSerializer.Deserialize<List<Item>>(json) ?? new List<Item>();
        }

        public List<StorageLocation> LoadLocations()
        {

            if (!File.Exists("storagelocations.json")) {

                return new List<StorageLocation>();
            }
            string json = File.ReadAllText("storagelocations.json");
            return JsonSerializer.Deserialize<List<StorageLocation>>(json) ?? new List<StorageLocation>();
        }


        public void ResolveStorageLocationLinks(List<StorageLocation> storageLocations, List<Item> items)
        {
            foreach(var item in items)
            {

                StorageLocation? location = storageLocations.FirstOrDefault(loc => loc.Id == item.StorageLocationId);


                if (location != null)
                {
                    item.StorageLocation = location;

                }

                else
                {
                    throw new Exception($"Storage location with ID {item.StorageLocationId} not found for item {item.Name} (ID: {item.Id})");
                }
            }

        }
        public void ClearData()
        {
            if (File.Exists("items.json"))
            {
                File.Delete("items.json");
            }
            if (File.Exists("storagelocations.json"))
            {
                File.Delete("storagelocations.json");
            }
        }
    }
}
