using System;
using System.Collections.Generic;
using System.Text;

namespace Lociem.Models
{
    public class StorageLocation
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public StorageLocation(int Id, string Name, string Description) {

            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        
        }

        public void Rename(string newName) {

            if (string.IsNullOrWhiteSpace(newName)) {              
                throw new Exception("Name cannot be empty or whitespace.");
            }
              Name = newName;

        }

        public void ChangeDescription(string newDescription) {

            if (string.IsNullOrWhiteSpace(newDescription))
            {
                throw new Exception("Description cannot be empty or whitespace.");
            }
            Description = newDescription;

        }


    }
}
