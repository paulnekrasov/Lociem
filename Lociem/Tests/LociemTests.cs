using Lociem.Models;
using Lociem.Managers;
using System;
using System.Collections.Generic;
using Xunit;


namespace Lociem.Tests
{
    public class LociemTests
    {

        [Fact]
        public void Rename_Item_Name_Description_Test()
        {
            var storageLocation = new StorageLocation("Gym", "A place where you become superhuman");
            var item = new Item("Man", "Super man", storageLocation);

            Assert.Throws<ArgumentException>(() => item.Rename(""));
            Assert.Throws<ArgumentException>(() => item.ChangeDescription(""));
        }


        [Fact]
        public void AssignToStorageLocation_WithNull_ThrowsArgumentNullException()
        {

            var storagelocation = new StorageLocation("Castle", "A place for the storing the swords");
            var item = new Item("Sword", "A sharp blade", storagelocation);
            Assert.Throws<ArgumentNullException>(() => item.AssignToStorageLocation(null!));
        }


        [Fact]
        public void RemoveItem_NotInManager_DoesNotThrow()
        {
            var dataManager = new DataManager();
            var itemManager = new ItemManager(dataManager);
            var storageLocation = new StorageLocation("Castle", "A place for the storing the swords");
            var item = new Item("Sword", "A sharp blade", storageLocation);

            var result = Record.Exception(() => itemManager.Delete(item));
            Assert.Null(result);
        }

        [Fact]
        public void EditItem_ItemNotFound_ThrowsInvalidOperationException()
        {
            var dataManager = new DataManager();
            var itemManager = new ItemManager(dataManager);
            var storageLocation = new StorageLocation("Castle", "A place for the storing the swords");
            var item = new Item("Sword", "A sharp blade", storageLocation);

            Assert.Throws<InvalidOperationException>(() => itemManager.Update(item));
        }
    


        [Fact]
        public void Delete_Storage_Location_With_Associated_Items()
        {
            var dataManager = new DataManager();
            var storageLocationManager = new StorageLocationManager(dataManager);
            var storageLocation = new StorageLocation("Warehouse", "A place to store items");
            var items = new List<Item>
            {
                new Item("Box", "A cardboard box", storageLocation),
                new Item("Crate", "A wooden crate", storageLocation), 
                new Item("Pallet", "A plastic pallet", storageLocation)
            };

            Assert.Throws<InvalidOperationException>(() => storageLocationManager.Delete(storageLocation, items));
        }

    }
}
