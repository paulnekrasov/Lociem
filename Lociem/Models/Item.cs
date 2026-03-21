
using Lociem.Interfaces;
namespace Lociem.Models
{
    public class Item : IEntity
    {
        public int Id { get; private set; }
        int IEntity.Id { get => Id; set => Id = value; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public StorageLocation? StorageLocation { get; internal set; }

        public int StorageLocationId { get; internal set; }

        public Item(string Name, string Description, StorageLocation storageLocation)
        {
            this.Name = Name;
            this.Description = Description;
            this.StorageLocation = storageLocation;
            this.StorageLocationId = storageLocation.Id;
        }

        public Item() { Name = ""; Description = ""; }
        public void Rename(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new Exception("Name cannot be empty or whitespace.");
            }
            Name = newName;
        }
        public void ChangeDescription(string newDescription)
        {

            if (string.IsNullOrWhiteSpace(newDescription))
            {
                throw new Exception("Description cannot be empty or whitespace.");
            }
            Description = newDescription;

        }
        public void AssignToStorageLocation(StorageLocation storageLocation)
        {

            if (storageLocation == null)
            {
                throw new Exception("Storage location cannot be null.");
            }

           this.StorageLocation = storageLocation;
           this.StorageLocationId = storageLocation.Id;

        }
    }
}
