namespace Mega_Desk
{
    partial class MegaDesk
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
            pictureBox1 = new PictureBox();
            exitButton = new Button();
            addButton = new Button();
            viewButton = new Button();
            searchButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.desk_icon_9306;
            pictureBox1.Location = new Point(625, 72);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(45, 272);
            exitButton.Margin = new Padding(4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(240, 60);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(45, 72);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(240, 60);
            addButton.TabIndex = 2;
            addButton.Text = "Add New Quote";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(45, 139);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(240, 60);
            viewButton.TabIndex = 3;
            viewButton.Text = "View Quote";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(45, 205);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(240, 60);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search Quote";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 22F, FontStyle.Bold);
            label1.Location = new Point(541, 225);
            label1.Name = "label1";
            label1.Size = new Size(240, 34);
            label1.TabIndex = 5;
            label1.Text = "M E G A D E S K";
            // 
            // MegaDesk
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(viewButton);
            Controls.Add(addButton);
            Controls.Add(exitButton);
            Controls.Add(pictureBox1);
            Font = new Font("Garamond", 12F);
            Margin = new Padding(4);
            Name = "MegaDesk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button exitButton;
        private Button addButton;
        private Button viewButton;
        private Button searchButton;
        private Label label1;
    }
}
