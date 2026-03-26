using Lociem.Managers;
using Lociem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lociem
{
    public partial class AddStorageLocation : Form
    {

        public string LocationName => textBox1.Text;
        public string LocationDescription => textBox2.Text;


        public AddStorageLocation()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(LocationName))
            {
                MessageBox.Show("Name cannot be empty.");
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
