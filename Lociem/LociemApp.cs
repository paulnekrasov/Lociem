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
        }

        private void labelItemsWhat_Click(object sender, EventArgs e)
        {

        }
    }

}