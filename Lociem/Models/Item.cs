using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lociem.Models
{
    public class Item
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public StorageLocation StorageLocation { get; private set; }

        public Item(int Id, string Name, string Description, StorageLocation storageLocation)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.StorageLocation = storageLocation;
        }
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

        }
    }
}
