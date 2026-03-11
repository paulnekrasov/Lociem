using Lociem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Lociem.Interfaces;

namespace Lociem.Services
{
    public class StorageLocationManager : IRepository<StorageLocation>
    {
        List<StorageLocation> storageLocations = new List<StorageLocation>();

        public void Add(StorageLocation storageLocation)
        {
            storageLocations.Add(storageLocation);
        }

        public void Delete(StorageLocation storageLocation)
        {

            StorageLocation? locationToDelete = storageLocations.Find(s => s.Id == storageLocation.Id);

            if (locationToDelete != null)
            {
                storageLocations.Remove(locationToDelete);
            }

        }

        public void Update(StorageLocation storageLocation)
        {
            StorageLocation? locationCheck = storageLocations.Find(s => s.Id == storageLocation.Id);
            locationCheck?.Rename(storageLocation.Name);
            locationCheck?.ChangeDescription(storageLocation.Description);
        }

        public StorageLocation? FindbyName(string name)
        {
            return storageLocations.Find(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public StorageLocation? FindbyId(int id)
        {
            return storageLocations.Find(s => s.Id == id);
        }
        public List<StorageLocation> GetAll() {

            return new List<StorageLocation>(storageLocations);
        }
    }
}
