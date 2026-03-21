using Lociem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lociem
{
    public partial class EditItem : Form
    {
        private  List<StorageLocation> _storageLocations = new List<StorageLocation>();

        public string NewName => textBoxName.Text;
        public string NewDescription => textBoxDescription.Text;

        public StorageLocation? SelectedStorageLocation => comboBoxStorageLocation.SelectedItem as StorageLocation;

        public EditItem(string name, string description, List<StorageLocation> storageLocations, StorageLocation? selectedStorageLocation)
        {
            InitializeComponent();
            textBoxName.Text = name;
            textBoxDescription.Text = description;
        _storageLocations = storageLocations ?? new List<StorageLocation>();

            comboBoxStorageLocation.DataSource = _storageLocations;
            comboBoxStorageLocation.DisplayMember = "Name";
            if (selectedStorageLocation != null)
                comboBoxStorageLocation.SelectedItem =
                _storageLocations.FirstOrDefault(l => l.Id == selectedStorageLocation.Id);
        }

       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewName))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            if (SelectedStorageLocation == null)
            {
                MessageBox.Show("Please select a storage location.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
