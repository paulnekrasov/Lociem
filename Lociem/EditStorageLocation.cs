using System;
using System.Windows.Forms;

namespace Lociem
{
    public partial class EditStorageLocation : Form
    {
        public string NewName => textBoxName.Text;

        public string NewDescription => textBoxDescription.Text;

        public EditStorageLocation(string NewName, string NewDescription)
        {
            InitializeComponent();
            textBoxName.Text = NewName;
            textBoxDescription.Text = NewDescription;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewName))
            {
                MessageBox.Show("Name cannot be empty.");
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
