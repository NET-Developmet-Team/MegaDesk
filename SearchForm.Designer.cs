namespace Mega_Desk
{
    partial class SearchForm
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
            searchBackButton = new Button();
            SuspendLayout();
            // 
            // searchBackButton
            // 
            searchBackButton.Location = new Point(917, 498);
            searchBackButton.Margin = new Padding(4);
            searchBackButton.Name = "searchBackButton";
            searchBackButton.Size = new Size(96, 28);
            searchBackButton.TabIndex = 0;
            searchBackButton.Text = "Cancel";
            searchBackButton.UseVisualStyleBackColor = true;
            searchBackButton.Click += button1_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(searchBackButton);
            Font = new Font("Garamond", 12F);
            Margin = new Padding(4);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
        }

        #endregion

        private Button searchBackButton;
    }
}