using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Lociem.Models;
using Lociem.Managers;

namespace Lociem
{
    public partial class AddItem : Form
    {
        private readonly List<StorageLocation> _storageLocations = new List<StorageLocation>();

        public string ItemName => textBox1.Text;
        public string ItemDescription => textBox2.Text;
        public StorageLocation? SelectedStorageLocation => comboBox1.SelectedItem as StorageLocation;

        public AddItem(List<StorageLocation> storageLocations)
        {
            InitializeComponent();

            if (storageLocations != null)
            {
                _storageLocations.AddRange(storageLocations);
            }

            comboBox1.DataSource = _storageLocations;
            comboBox1.DisplayMember = nameof(StorageLocation.Name);
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select storage location";
        }

    

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItemName))
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }
       
    }
}
