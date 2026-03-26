using System;
using System.Collections.Generic;
using System.Text;
using Lociem.Interfaces;

namespace Lociem.Models
{
    public class StorageLocation : IEntity
    {
        public int Id { get; private set; }
        int IEntity.Id { get => Id; set => Id = value; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public StorageLocation( string Name, string Description) {

            
            this.Name = Name;
            this.Description = Description;
        
        }

        public StorageLocation() { Name = ""; Description = ""; }

        public void Rename(string newName) {

            if (string.IsNullOrWhiteSpace(newName)) {              
                throw new ArgumentException("Name cannot be empty or whitespace.", nameof(newName));
            }
              Name = newName;

        }

        public void ChangeDescription(string newDescription) {

            if (string.IsNullOrWhiteSpace(newDescription))
            {
                throw new ArgumentException("Description cannot be empty or whitespace.", nameof(newDescription));
            }
            Description = newDescription;

        }

        public override string ToString()
        {
            return $"{Name} - {Description}";
        }


    }
}
