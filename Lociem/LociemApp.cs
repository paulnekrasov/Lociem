using Lociem.Managers;
using Lociem.Models;
using System;
using System.Collections.Generic;

namespace Lociem
{
    public partial class LociemApp : Form
    {
        public LociemApp()
        {
            _dataManager = new DataManager();
            _itemManager = new ItemManager(_dataManager);
            _locationManager = new StorageLocationManager(_dataManager);
            InitializeComponent();
        }

        private readonly DataManager _dataManager;
        private readonly ItemManager _itemManager;
        private readonly StorageLocationManager _locationManager;

        private List<Item> GetFilteredItems()
        {
            string searchText = textBoxSearchItems.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _itemManager.GetAll();
            }

            return _itemManager.FindByName(searchText);
        }

        private List<StorageLocation> GetFilteredLocations()
        {
            string searchText = textBoxSearchStorageLocations.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _locationManager.GetAll();
            }

            return _locationManager.FindByName(searchText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var storageLocations = _dataManager.LoadLocations();
            var items = _dataManager.LoadItems();
            _locationManager.LoadAll(storageLocations);
            _itemManager.LoadAll(items);

            _dataManager.ResolveStorageLocationLinks(storageLocations, items);

            ApplyItemsFilter();
            ApplyStorageLocationsFilter();
        }

        private void ApplyItemsFilter()
        {
            List<Item> items = GetFilteredItems();

            listBoxItems.Items.Clear();
            foreach (var item in items)
            {
                listBoxItems.Items.Add(item);
            }
        }

        private void ApplyStorageLocationsFilter()
        {
            List<StorageLocation> locations = GetFilteredLocations();

            listBoxStorageLocations.DataSource = null;
            listBoxStorageLocations.DataSource = locations;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            var storageLocations = _locationManager.GetAll();
            var form = new AddItem(storageLocations);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.SelectedStorageLocation == null)
                {
                    MessageBox.Show("Please select a storage location.");
                    return;
                }

                Item item = new Item(form.ItemName, form.ItemDescription, form.SelectedStorageLocation);
                _itemManager.Add(item);
                ApplyItemsFilter();
            }

        }

        private void buttonEditItems_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem is not Item item)
            {
                MessageBox.Show("Please select an item to edit.");
                return;
            }

            var storageLocations = _locationManager.GetAll();
            var form = new EditItem(item.Name, item.Description, storageLocations, item.StorageLocation);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.SelectedStorageLocation == null)
                {
                    MessageBox.Show("Please select a storage location.");
                    return;
                }

                item.Rename(form.NewName);
                item.ChangeDescription(form.NewDescription);
                item.AssignToStorageLocation(form.SelectedStorageLocation);

                _itemManager.Update(item);
                ApplyItemsFilter();
            }

        }

        private void buttonDeleteItems_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem is not Item item)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            _itemManager.Delete(item);
            ApplyItemsFilter();

        }

        private void buttonEditStorageLocation_Click(object sender, EventArgs e)
        {
            if (listBoxStorageLocations.SelectedItem is not StorageLocation location)
            {
                MessageBox.Show("Please select a location to edit.");
                return;
            }

            var form = new EditStorageLocation(location.Name, location.Description);

            if (form.ShowDialog() == DialogResult.OK)
            {
                location.Rename(form.NewName);
                location.ChangeDescription(form.NewDescription);
                _locationManager.Update(location);
                ApplyStorageLocationsFilter();
            }
        }

        private void buttonAddStorageLocation_Click(object sender, EventArgs e)
        {
            var form = new AddStorageLocation();

            if (form.ShowDialog() == DialogResult.OK)
            {

                StorageLocation location = new StorageLocation(form.LocationName, form.LocationDescription);
                _locationManager.Add(location);
                ApplyStorageLocationsFilter();
            }
        }

        private void buttonDeleteStorageLocation_Click(object sender, EventArgs e)
        {
            if (listBoxStorageLocations.SelectedItem is not StorageLocation location)
            {

                MessageBox.Show("Please select a storage location to delete.");
                return;
            }

            else
            {
                var items = _itemManager.GetAll();

               
                try {
                    _locationManager.Delete(location, items);
                    ApplyStorageLocationsFilter();
                }


                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void textBoxSearchItems_TextChanged(object sender, EventArgs e)
        {
            ApplyItemsFilter();
        }

        private void textBoxSearchStorageLocations_TextChanged(object sender, EventArgs e)
        {
            ApplyStorageLocationsFilter();
        }
              
    }

}