using Lociem.Models;

namespace Lociem
{
    public partial class LociemApp : Form
    {
        public LociemApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StorageLocation Castle = new StorageLocation(1, "Armory", "A place to store weapons and armor.");
            Item Sword = new Item(1, "Sword", "A sharp blade used for combat.", Castle);
            

            string ItemInfo =
                $"Item: {Sword.Name}\nDescription: {Sword.Description} " +
                $"\nStorage Location: {Sword.StorageLocation.Name}";

            MessageBox.Show(ItemInfo);
        }
        private void button2_Click(object sender, EventArgs e)

        {

            StorageLocation Castle = new StorageLocation(1, "Armory", "A place to store weapons and armor.");
            Item Sword = new Item(1, "Sword", "A sharp blade used for combat.", Castle);

            string StorageInfo =
                $"Storage Location: {Castle.Name}\nDescription: {Castle.Description} " +
                $"\nContains Item: {Sword.Name}";

            MessageBox.Show(StorageInfo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
