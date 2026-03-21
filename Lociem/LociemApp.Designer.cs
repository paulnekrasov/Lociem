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
            buttonAddItem = new Button();
            None = new ListBox();
            labelItemsWhat = new Label();
            tabPageStorageLocations = new TabPage();
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
            tabPageItems.Controls.Add(buttonAddItem);
            tabPageItems.Controls.Add(None);
            tabPageItems.Controls.Add(labelItemsWhat);
            tabPageItems.Location = new Point(4, 34);
            tabPageItems.Name = "tabPageItems";
            tabPageItems.Padding = new Padding(3);
            tabPageItems.Size = new Size(1094, 389);
            tabPageItems.TabIndex = 0;
            tabPageItems.Text = "Items";
            tabPageItems.UseVisualStyleBackColor = true;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Font = new Font("Segoe UI", 12F);
            buttonAddItem.Location = new Point(825, 55);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(120, 43);
            buttonAddItem.TabIndex = 2;
            buttonAddItem.Text = "Add";
            buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // None
            // 
            None.FormattingEnabled = true;
            None.Location = new Point(18, 55);
            None.Name = "None";
            None.Size = new Size(790, 304);
            None.TabIndex = 1;
            // 
            // labelItemsWhat
            // 
            labelItemsWhat.AutoSize = true;
            labelItemsWhat.Location = new Point(18, 18);
            labelItemsWhat.Name = "labelItemsWhat";
            labelItemsWhat.Size = new Size(56, 25);
            labelItemsWhat.TabIndex = 0;
            labelItemsWhat.Text = "Items";
            labelItemsWhat.Click += labelItemsWhat_Click;
            // 
            // tabPageStorageLocations
            // 
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
            // buttonAddStorageLocation
            // 
            buttonAddStorageLocation.Font = new Font("Segoe UI", 12F);
            buttonAddStorageLocation.Location = new Point(825, 55);
            buttonAddStorageLocation.Name = "buttonAddStorageLocation";
            buttonAddStorageLocation.Size = new Size(120, 43);
            buttonAddStorageLocation.TabIndex = 2;
            buttonAddStorageLocation.Text = "Add";
            buttonAddStorageLocation.UseVisualStyleBackColor = true;
            // 
            // listBoxStorageLocations
            // 
            listBoxStorageLocations.FormattingEnabled = true;
            listBoxStorageLocations.Location = new Point(18, 55);
            listBoxStorageLocations.Name = "listBoxStorageLocations";
            listBoxStorageLocations.Size = new Size(790, 304);
            listBoxStorageLocations.TabIndex = 1;
            // 
            // labelStorageLocationsWhat
            // 
            labelStorageLocationsWhat.AutoSize = true;
            labelStorageLocationsWhat.Location = new Point(18, 18);
            labelStorageLocationsWhat.Name = "labelStorageLocationsWhat";
            labelStorageLocationsWhat.Size = new Size(54, 25);
            labelStorageLocationsWhat.TabIndex = 0;
            labelStorageLocationsWhat.Text = "What";
            // 
            // LociemApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 451);
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
        private ListBox None;
        private Button buttonAddItem;
        private Label labelStorageLocationsWhat;
        private ListBox listBoxStorageLocations;
        private Button buttonAddStorageLocation;
    }
}
