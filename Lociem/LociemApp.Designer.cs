namespace Lociem
{
    partial class LociemApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPageItems = new TabPage();
            textBoxSearchItems = new TextBox();
            buttonDeleteItems = new Button();
            buttonEditItems = new Button();
            buttonAddItem = new Button();
            listBoxItems = new ListBox();
            labelItemsWhat = new Label();
            tabPageStorageLocations = new TabPage();
            textBoxSearchStorageLocations = new TextBox();
            buttonDeleteStorageLocation = new Button();
            buttonEditStorageLocation = new Button();
            buttonAddStorageLocation = new Button();
            listBoxStorageLocations = new ListBox();
            labelStorageLocationsWhat = new Label();
            tabControlMain.SuspendLayout();
            tabPageItems.SuspendLayout();
            tabPageStorageLocations.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageItems);
            tabControlMain.Controls.Add(tabPageStorageLocations);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1102, 427);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageItems
            // 
            tabPageItems.Controls.Add(textBoxSearchItems);
            tabPageItems.Controls.Add(buttonDeleteItems);
            tabPageItems.Controls.Add(buttonEditItems);
            tabPageItems.Controls.Add(buttonAddItem);
            tabPageItems.Controls.Add(listBoxItems);
            tabPageItems.Controls.Add(labelItemsWhat);
            tabPageItems.Location = new Point(4, 34);
            tabPageItems.Name = "tabPageItems";
            tabPageItems.Padding = new Padding(3);
            tabPageItems.Size = new Size(1094, 389);
            tabPageItems.TabIndex = 0;
            tabPageItems.Text = "Items";
            tabPageItems.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchItems
            // 
            textBoxSearchItems.Location = new Point(18, 72);
            textBoxSearchItems.Name = "textBoxSearchItems";
            textBoxSearchItems.PlaceholderText = "Search by name";
            textBoxSearchItems.Size = new Size(790, 31);
            textBoxSearchItems.TabIndex = 7;
            textBoxSearchItems.TextChanged += textBoxSearchItems_TextChanged;
            // 
            // buttonDeleteItems
            // 
            buttonDeleteItems.Font = new Font("Segoe UI", 12F);
            buttonDeleteItems.Location = new Point(827, 194);
            buttonDeleteItems.Name = "buttonDeleteItems";
            buttonDeleteItems.Size = new Size(120, 43);
            buttonDeleteItems.TabIndex = 6;
            buttonDeleteItems.Text = "Delete";
            buttonDeleteItems.UseVisualStyleBackColor = true;
            buttonDeleteItems.Click += buttonDeleteItems_Click;
            // 
            // buttonEditItems
            // 
            buttonEditItems.Font = new Font("Segoe UI", 12F);
            buttonEditItems.Location = new Point(828, 131);
            buttonEditItems.Name = "buttonEditItems";
            buttonEditItems.Size = new Size(120, 43);
            buttonEditItems.TabIndex = 5;
            buttonEditItems.Text = "Edit";
            buttonEditItems.UseVisualStyleBackColor = true;
            buttonEditItems.Click += buttonEditItems_Click;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Font = new Font("Segoe UI", 12F);
            buttonAddItem.Location = new Point(828, 69);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(120, 43);
            buttonAddItem.TabIndex = 2;
            buttonAddItem.Text = "Add";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(18, 112);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(790, 254);
            listBoxItems.TabIndex = 1;
            // 
            // labelItemsWhat
            // 
            labelItemsWhat.AutoSize = true;
            labelItemsWhat.Font = new Font("Segoe UI", 14F);
            labelItemsWhat.Location = new Point(18, 16);
            labelItemsWhat.Name = "labelItemsWhat";
            labelItemsWhat.Size = new Size(84, 38);
            labelItemsWhat.TabIndex = 0;
            labelItemsWhat.Text = "Items";
            labelItemsWhat.Click += labelItemsWhat_Click;
            // 
            // tabPageStorageLocations
            // 
            tabPageStorageLocations.Controls.Add(textBoxSearchStorageLocations);
            tabPageStorageLocations.Controls.Add(buttonDeleteStorageLocation);
            tabPageStorageLocations.Controls.Add(buttonEditStorageLocation);
            tabPageStorageLocations.Controls.Add(buttonAddStorageLocation);
            tabPageStorageLocations.Controls.Add(listBoxStorageLocations);
            tabPageStorageLocations.Controls.Add(labelStorageLocationsWhat);
            tabPageStorageLocations.Location = new Point(4, 34);
            tabPageStorageLocations.Name = "tabPageStorageLocations";
            tabPageStorageLocations.Padding = new Padding(3);
            tabPageStorageLocations.Size = new Size(1094, 389);
            tabPageStorageLocations.TabIndex = 1;
            tabPageStorageLocations.Text = "Storage Locations";
            tabPageStorageLocations.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchStorageLocations
            // 
            textBoxSearchStorageLocations.Location = new Point(18, 72);
            textBoxSearchStorageLocations.Name = "textBoxSearchStorageLocations";
            textBoxSearchStorageLocations.PlaceholderText = "Search by name";
            textBoxSearchStorageLocations.Size = new Size(790, 31);
            textBoxSearchStorageLocations.TabIndex = 5;
            textBoxSearchStorageLocations.TextChanged += textBoxSearchStorageLocations_TextChanged;
            // 
            // buttonDeleteStorageLocation
            // 
            buttonDeleteStorageLocation.Font = new Font("Segoe UI", 12F);
            buttonDeleteStorageLocation.Location = new Point(825, 193);
            buttonDeleteStorageLocation.Name = "buttonDeleteStorageLocation";
            buttonDeleteStorageLocation.Size = new Size(120, 43);
            buttonDeleteStorageLocation.TabIndex = 4;
            buttonDeleteStorageLocation.Text = "Delete";
            buttonDeleteStorageLocation.UseVisualStyleBackColor = true;
            buttonDeleteStorageLocation.Click += buttonDeleteStorageLocation_Click;
            // 
            // buttonEditStorageLocation
            // 
            buttonEditStorageLocation.Font = new Font("Segoe UI", 12F);
            buttonEditStorageLocation.Location = new Point(826, 130);
            buttonEditStorageLocation.Name = "buttonEditStorageLocation";
            buttonEditStorageLocation.Size = new Size(120, 43);
            buttonEditStorageLocation.TabIndex = 3;
            buttonEditStorageLocation.Text = "Edit";
            buttonEditStorageLocation.UseVisualStyleBackColor = true;
            buttonEditStorageLocation.Click += buttonEditStorageLocation_Click;
            // 
            // buttonAddStorageLocation
            // 
            buttonAddStorageLocation.Font = new Font("Segoe UI", 12F);
            buttonAddStorageLocation.Location = new Point(825, 68);
            buttonAddStorageLocation.Name = "buttonAddStorageLocation";
            buttonAddStorageLocation.Size = new Size(120, 43);
            buttonAddStorageLocation.TabIndex = 2;
            buttonAddStorageLocation.Text = "Add";
            buttonAddStorageLocation.UseVisualStyleBackColor = true;
            buttonAddStorageLocation.Click += buttonAddStorageLocation_Click;
            // 
            // listBoxStorageLocations
            // 
            listBoxStorageLocations.FormattingEnabled = true;
            listBoxStorageLocations.Location = new Point(18, 112);
            listBoxStorageLocations.Name = "listBoxStorageLocations";
            listBoxStorageLocations.Size = new Size(790, 254);
            listBoxStorageLocations.TabIndex = 1;
            // 
            // labelStorageLocationsWhat
            // 
            labelStorageLocationsWhat.AutoSize = true;
            labelStorageLocationsWhat.Font = new Font("Segoe UI", 14F);
            labelStorageLocationsWhat.Location = new Point(18, 16);
            labelStorageLocationsWhat.Name = "labelStorageLocationsWhat";
            labelStorageLocationsWhat.Size = new Size(227, 38);
            labelStorageLocationsWhat.TabIndex = 0;
            labelStorageLocationsWhat.Text = "StorageLocations";
            labelStorageLocationsWhat.Click += labelStorageLocationsWhat_Click;
            // 
            // LociemApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 564);
            Controls.Add(tabControlMain);
            Margin = new Padding(2);
            Name = "LociemApp";
            Text = "Lociem";
            Load += Form1_Load;
            tabControlMain.ResumeLayout(false);
            tabPageItems.ResumeLayout(false);
            tabPageItems.PerformLayout();
            tabPageStorageLocations.ResumeLayout(false);
            tabPageStorageLocations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControlMain;
        private TabPage tabPageItems;
        private TabPage tabPageStorageLocations;
        private Label labelItemsWhat;
        private ListBox listBoxItems;
        private Button buttonAddItem;
        private Label labelStorageLocationsWhat;
        private ListBox listBoxStorageLocations;
        private Button buttonAddStorageLocation;
        private Button buttonDeleteItems;
        private Button buttonEditItems;
        private Button buttonDeleteStorageLocation;
        private Button buttonEditStorageLocation;
        private TextBox textBoxSearchItems;
        private TextBox textBoxSearchStorageLocations;
    }
}
