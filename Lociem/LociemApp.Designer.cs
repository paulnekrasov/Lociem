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
            btn1_Item = new Button();
            btn2_Location = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn1_Item
            // 
            btn1_Item.Location = new Point(63, 276);
            btn1_Item.Name = "btn1_Item";
            btn1_Item.Size = new Size(224, 46);
            btn1_Item.TabIndex = 0;
            btn1_Item.Text = "Show Item Info";
            btn1_Item.UseVisualStyleBackColor = true;
            btn1_Item.Click += button1_Click;
            // 
            // btn2_Location
            // 
            btn2_Location.Location = new Point(440, 276);
            btn2_Location.Name = "btn2_Location";
            btn2_Location.RightToLeft = RightToLeft.Yes;
            btn2_Location.Size = new Size(256, 46);
            btn2_Location.TabIndex = 1;
            btn2_Location.Text = "Show Location Info";
            btn2_Location.UseVisualStyleBackColor = true;
            btn2_Location.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(166, 42);
            label1.Name = "label1";
            label1.Size = new Size(461, 50);
            label1.TabIndex = 2;
            label1.Text = "Lociem Project Showcase";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // LociemApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn2_Location);
            Controls.Add(btn1_Item);
            Name = "LociemApp";
            Text = "Lociem";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1_Item;
        private Button btn2_Location;
        private Label label1;
    }
}
