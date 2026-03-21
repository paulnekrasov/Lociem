namespace Lociem
{
    partial class EditItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelStorageLocation = new Label();
            comboBoxStorageLocation = new ComboBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(18, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(166, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Edit Item";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F);
            labelName.Location = new Point(18, 89);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 28);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(18, 120);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(572, 31);
            textBoxName.TabIndex = 2;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 10F);
            labelDescription.Location = new Point(18, 170);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(112, 28);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(18, 200);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(572, 31);
            textBoxDescription.TabIndex = 4;
            // 
            // labelStorageLocation
            // 
            labelStorageLocation.AutoSize = true;
            labelStorageLocation.Font = new Font("Segoe UI", 10F);
            labelStorageLocation.Location = new Point(18, 248);
            labelStorageLocation.Name = "labelStorageLocation";
            labelStorageLocation.Size = new Size(217, 28);
            labelStorageLocation.TabIndex = 5;
            labelStorageLocation.Text = "Select Storage Location";
            // 
            // comboBoxStorageLocation
            // 
            comboBoxStorageLocation.FormattingEnabled = true;
            comboBoxStorageLocation.Location = new Point(18, 278);
            comboBoxStorageLocation.Name = "comboBoxStorageLocation";
            comboBoxStorageLocation.Size = new Size(250, 33);
            comboBoxStorageLocation.TabIndex = 6;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(18, 327);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(115, 36);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(475, 327);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(115, 36);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // EditItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 376);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(comboBoxStorageLocation);
            Controls.Add(labelStorageLocation);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            Name = "EditItem";
            Text = "EditItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelStorageLocation;
        private ComboBox comboBoxStorageLocation;
        private Button buttonCancel;
        private Button buttonSave;
    }
}
