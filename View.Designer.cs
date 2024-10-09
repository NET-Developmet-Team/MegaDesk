namespace Mega_Desk
{
    partial class View
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
            viewBackButton = new Button();
            SuspendLayout();
            // 
            // viewBackButton
            // 
            viewBackButton.Location = new Point(888, 491);
            viewBackButton.Margin = new Padding(5, 5, 5, 5);
            viewBackButton.Name = "viewBackButton";
            viewBackButton.Size = new Size(123, 34);
            viewBackButton.TabIndex = 8;
            viewBackButton.Text = "Cancel";
            viewBackButton.UseVisualStyleBackColor = true;
            viewBackButton.Click += cancelButton_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(viewBackButton);
            Font = new Font("Garamond", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "View";
            Text = "View";
            ResumeLayout(false);
        }

        #endregion

        private Button addBackButton;
        private Button viewBackButton;
    }
}