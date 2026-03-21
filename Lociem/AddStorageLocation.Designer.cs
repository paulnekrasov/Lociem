namespace Lociem
{
    partial class AddStorageLocation
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonSaveAddedStorageLocation = new Button();
            buttonCancelAddingStorageLocation = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8F);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(18, 120);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(572, 29);
            textBox1.TabIndex = 0;
            textBox1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 8F);
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(18, 200);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(572, 29);
            textBox2.TabIndex = 1;
            textBox2.Text = "Description";
            // 
            // buttonSaveAddedStorageLocation
            // 
            buttonSaveAddedStorageLocation.BackColor = SystemColors.ButtonHighlight;
            buttonSaveAddedStorageLocation.Location = new Point(465, 317);
            buttonSaveAddedStorageLocation.Margin = new Padding(2);
            buttonSaveAddedStorageLocation.Name = "buttonSaveAddedStorageLocation";
            buttonSaveAddedStorageLocation.Size = new Size(115, 36);
            buttonSaveAddedStorageLocation.TabIndex = 2;
            buttonSaveAddedStorageLocation.Text = "Save";
            buttonSaveAddedStorageLocation.UseVisualStyleBackColor = false;
            buttonSaveAddedStorageLocation.Click += button1_Click;
            // 
            // buttonCancelAddingStorageLocation
            // 
            buttonCancelAddingStorageLocation.Location = new Point(18, 317);
            buttonCancelAddingStorageLocation.Margin = new Padding(2);
            buttonCancelAddingStorageLocation.Name = "buttonCancelAddingStorageLocation";
            buttonCancelAddingStorageLocation.Size = new Size(115, 36);
            buttonCancelAddingStorageLocation.TabIndex = 3;
            buttonCancelAddingStorageLocation.Text = "Cancel";
            buttonCancelAddingStorageLocation.UseVisualStyleBackColor = true;
            buttonCancelAddingStorageLocation.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(18, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 45);
            label1.TabIndex = 4;
            label1.Text = "Add Storage Location";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(18, 89);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 5;
            label2.Text = "Name";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(18, 170);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // AddStorageLocation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 376);
            Controls.Add(buttonCancelAddingStorageLocation);
            Controls.Add(buttonSaveAddedStorageLocation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "AddStorageLocation";
            Text = "AddStorageLocation";
            Load += AddItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonSaveAddedStorageLocation;
        private Button buttonCancelAddingStorageLocation;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}