using Lociem.Models;
using Lociem.Managers;
using System.Runtime.Versioning;

namespace Lociem
{
    [SupportedOSPlatform("windows")]
    public partial class LociemApp : Form
    {
        public LociemApp()
        {
            InitializeComponent();
        }

        private ItemManager itemManager = new ItemManager();
        private StorageLocationManager locationManager = new StorageLocationManager();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StorageLocation Gym = new StorageLocation(1, "Sport Life", "Big Sport Complex in SmartPlaza");
            StorageLocation Garage = new StorageLocation(2, "Garage", "Place where I keep my tools and some old stuff");
            locationManager.Add(Gym);
            locationManager.Add(Garage);

            Item Dumbell = new Item(1, "Dumbbell", "A piece of equipment used for weight training", Gym);
            Item Sweep = new Item(2, "Broom", "A cleaning tool used to sweep floors", Garage);

            itemManager.Add(Dumbell);
            itemManager.Add(Sweep);

            List<Item> items = itemManager.GetAll();
            foreach (Item item in items)
            {

                MessageBox.Show(
                    $"Item: {item.Name}," +
                    $" Description: {item.Description}, " +
                    $"Storage Location: {item.StorageLocation.Name}");

            }

            Item? found = itemManager.FindbyName("Dumbbell");
            if (found != null)
            {

                MessageBox.Show(
                    $"Found Item: {found.Name}, " +
                    $"Description: {found.Description}, " +
                    $"Storage Location: {found.StorageLocation.Name}");
            }
            else
            {
                MessageBox.Show("Item not found.");
            }

            Item? idfound = itemManager.FindbyId(1);

            if (idfound != null)
            {
                MessageBox.Show(
                    $"Found Item Id: {idfound.Id}, " +
                    $"Storage Location: {idfound.StorageLocation.Name}");
            }
            else
            {
                MessageBox.Show("Item not found.");
            }
            StorageLocation? locationFound = locationManager.FindbyName("Sport Life");
            StorageLocation? idLocationFound = locationManager.FindbyId(1);
            if (locationFound != null)
            {
                MessageBox.Show(
                    $"Found Location: {locationFound.Name}, " +
                    $"Description: {locationFound.Description}");
            }
            else
            {
                MessageBox.Show("Location not found.");

            }
            if (idLocationFound != null)
            {
                MessageBox.Show(
                    $"Found Location Id: {idLocationFound.Id}, " +
                    $"Description: {idLocationFound.Description}");
            }
            else
            {
                MessageBox.Show("Location not found.");
            }

            foreach (Item item in itemManager.GetAll())
            {
                MessageBox.Show(
                    $"Before deleting: " +
                    $"Location: {item.Name}, " +
                    $"Description: {item.Description}," +
                    $"Storage Location: {item.StorageLocation.Name}," +
                    $"Location Description: {item.StorageLocation.Description}");
            }

            itemManager.Delete(Dumbell); 

            foreach (Item item in itemManager.GetAll())
            {
                MessageBox.Show(
                    $"After deleting: " +
                    $"Location: {item.Name}, " +
                    $"Description: {item.Description}," +
                    $"Storage Location: {item.StorageLocation.Name}," +
                    $"Location Description: {item.StorageLocation.Description}");
            }



        }
    }
    
    }