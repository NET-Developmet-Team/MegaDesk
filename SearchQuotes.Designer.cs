namespace MegaDesk_Alexander
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.mainMenuReturnButton = new System.Windows.Forms.Button();
            this.submitNewQuoteButton = new System.Windows.Forms.Button();
            this.surfaceMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuReturnButton
            // 
            this.mainMenuReturnButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainMenuReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuReturnButton.ForeColor = System.Drawing.Color.Black;
            this.mainMenuReturnButton.Location = new System.Drawing.Point(167, 549);
            this.mainMenuReturnButton.Name = "mainMenuReturnButton";
            this.mainMenuReturnButton.Size = new System.Drawing.Size(200, 45);
            this.mainMenuReturnButton.TabIndex = 0;
            this.mainMenuReturnButton.Text = "Return to Main Menu";
            this.mainMenuReturnButton.UseVisualStyleBackColor = false;
            this.mainMenuReturnButton.Click += new System.EventHandler(this.mainMenuReturnButton_Click);
            // 
            // submitNewQuoteButton
            // 
            this.submitNewQuoteButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitNewQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitNewQuoteButton.ForeColor = System.Drawing.Color.Black;
            this.submitNewQuoteButton.Location = new System.Drawing.Point(336, 56);
            this.submitNewQuoteButton.Name = "submitNewQuoteButton";
            this.submitNewQuoteButton.Size = new System.Drawing.Size(135, 33);
            this.submitNewQuoteButton.TabIndex = 8;
            this.submitNewQuoteButton.Text = "Search";
            this.submitNewQuoteButton.UseVisualStyleBackColor = false;
            // 
            // surfaceMaterialComboBox
            // 
            this.surfaceMaterialComboBox.BackColor = System.Drawing.Color.White;
            this.surfaceMaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterialComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surfaceMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.surfaceMaterialComboBox.FormattingEnabled = true;
            this.surfaceMaterialComboBox.ItemHeight = 36;
            this.surfaceMaterialComboBox.Location = new System.Drawing.Point(34, 56);
            this.surfaceMaterialComboBox.Name = "surfaceMaterialComboBox";
            this.surfaceMaterialComboBox.Size = new System.Drawing.Size(270, 44);
            this.surfaceMaterialComboBox.TabIndex = 9;
            this.surfaceMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.surfaceMaterialComboBox_SelectedIndexChanged);
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(30, 33);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(200, 20);
            this.surfaceMaterialLabel.TabIndex = 10;
            this.surfaceMaterialLabel.Text = "Search by Surface Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.surfaceMaterialComboBox);
            this.Controls.Add(this.submitNewQuoteButton);
            this.Controls.Add(this.mainMenuReturnButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuReturnButton;
        private System.Windows.Forms.Button submitNewQuoteButton;
        private System.Windows.Forms.ComboBox surfaceMaterialComboBox;
        private System.Windows.Forms.Label surfaceMaterialLabel;
    }
}