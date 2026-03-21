using Lociem.Managers;
using Lociem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Versioning;
using System.Xml.Linq;

namespace Lociem
{
    [SupportedOSPlatform("windows")]
    public partial class LociemApp : Form
    {
        public LociemApp()
        {
            InitializeComponent();
        }

        private ItemManager _itemManager = new ItemManager();
        private StorageLocationManager _locationManager = new StorageLocationManager();
        private DataManager _dataManager = new DataManager();

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
            string searchText = textBoxSearchItems.Text;
            var items = string.IsNullOrWhiteSpace(searchText)
                ? _itemManager.GetAll()
                : _itemManager.FindbyName(searchText);

            listBoxItems.Items.Clear();
            foreach (var item in items)
            {
                listBoxItems.Items.Add($"{item.Name} - {item.Description}");
            }
        }

        private void ApplyStorageLocationsFilter()
        {
            string searchText = textBoxSearchStorageLocations.Text;
            var locations = string.IsNullOrWhiteSpace(searchText)
                ? _locationManager.GetAll()
                : _locationManager.FindbyName(searchText);

            listBoxStorageLocations.Items.Clear();
            foreach (var location in locations)
            {
                listBoxStorageLocations.Items.Add($"{location.Name} - {location.Description}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelItemsWhat_Click(object sender, EventArgs e)
        {

        }

        private void labelStorageLocationsWhat_Click(object sender, EventArgs e)
        {

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
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to edit.");
                return;
            }

            string searchText = textBoxSearchItems.Text;
            var items = string.IsNullOrWhiteSpace(searchText)
                ? _itemManager.GetAll()
                : _itemManager.FindbyName(searchText);
            var storageLocations = _locationManager.GetAll();
            var item = items[listBoxItems.SelectedIndex];
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
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            string searchText = textBoxSearchItems.Text;
            var items = string.IsNullOrWhiteSpace(searchText)
                ? _itemManager.GetAll()
                : _itemManager.FindbyName(searchText);
            var item = items[listBoxItems.SelectedIndex];
            _itemManager.Delete(item);
            ApplyItemsFilter();

        }

        private void buttonEditStorageLocation_Click(object sender, EventArgs e)
        {
            if (listBoxStorageLocations.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a location to edit.");
                return;
            }
            string searchText = textBoxSearchStorageLocations.Text;
            var locations = string.IsNullOrWhiteSpace(searchText)
                ? _locationManager.GetAll()
                : _locationManager.FindbyName(searchText);
            var location = locations[listBoxStorageLocations.SelectedIndex];
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
            if(listBoxStorageLocations.SelectedIndex == -1)
            {

                MessageBox.Show("Please select a storage location to delete.");
                return;
            }

            else
            {
                string searchText = textBoxSearchStorageLocations.Text;
                var locations = string.IsNullOrWhiteSpace(searchText)
                    ? _locationManager.GetAll()
                    : _locationManager.FindbyName(searchText);
                var items = _itemManager.GetAll();
                var location = locations[listBoxStorageLocations.SelectedIndex];

               
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

        private void LociemApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dataManager.SaveItems(_itemManager.GetAll());
            _dataManager.SaveLocations(_locationManager.GetAll());
        }
              
    }

}