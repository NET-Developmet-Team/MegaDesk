namespace Mega_Desk
{
    partial class AddForm
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
            addBackButton = new Button();
            name = new TextBox();
            nameLabel = new Label();
            label1 = new Label();
            rushCB = new ComboBox();
            label2 = new Label();
            depthLable = new Label();
            drawerLabel = new Label();
            widthLabel = new Label();
            materialLabel = new Label();
            drawerUpDown = new NumericUpDown();
            widthUpDown = new NumericUpDown();
            depthUpDown = new NumericUpDown();
            materialCB = new ComboBox();
            addSubmitButton = new Button();
            costLabel = new Label();
            estimatedPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)drawerUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depthUpDown).BeginInit();
            SuspendLayout();
            // 
            // addBackButton
            // 
            addBackButton.Location = new Point(917, 498);
            addBackButton.Margin = new Padding(4);
            addBackButton.Name = "addBackButton";
            addBackButton.Size = new Size(96, 28);
            addBackButton.TabIndex = 7;
            addBackButton.Text = "Cancel";
            addBackButton.UseVisualStyleBackColor = true;
            addBackButton.Click += addBackButton_Click;
            // 
            // name
            // 
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Location = new Point(153, 47);
            name.Margin = new Padding(4);
            name.Name = "name";
            name.Size = new Size(299, 30);
            name.TabIndex = 0;
            name.TextChanged += updateEstimate;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Garamond", 12F);
            nameLabel.Location = new Point(153, 22);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(56, 22);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            nameLabel.Click += nameLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F);
            label1.Location = new Point(671, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 22);
            label1.TabIndex = 3;
            label1.Text = "Rush Order Deadline";
            label1.Click += label1_Click;
            // 
            // rushCB
            // 
            rushCB.FormattingEnabled = true;
            rushCB.Items.AddRange(new object[] { "3 Days", "5 Days", "7 Days", "None" });
            rushCB.Location = new Point(671, 46);
            rushCB.Margin = new Padding(4);
            rushCB.Name = "rushCB";
            rushCB.Size = new Size(183, 30);
            rushCB.TabIndex = 1;
            rushCB.SelectedValueChanged += updateEstimate;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 20F);
            label2.Location = new Point(153, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(274, 38);
            label2.TabIndex = 6;
            label2.Text = "Desk Specifications";
            // 
            // depthLable
            // 
            depthLable.AutoSize = true;
            depthLable.Location = new Point(153, 246);
            depthLable.Margin = new Padding(4, 0, 4, 0);
            depthLable.Name = "depthLable";
            depthLable.Size = new Size(59, 22);
            depthLable.TabIndex = 7;
            depthLable.Text = "Depth";
            // 
            // drawerLabel
            // 
            drawerLabel.AutoSize = true;
            drawerLabel.Location = new Point(671, 154);
            drawerLabel.Margin = new Padding(4, 0, 4, 0);
            drawerLabel.Name = "drawerLabel";
            drawerLabel.Size = new Size(122, 22);
            drawerLabel.TabIndex = 8;
            drawerLabel.Text = "Drawer Count";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(153, 158);
            widthLabel.Margin = new Padding(4, 0, 4, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(59, 22);
            widthLabel.TabIndex = 9;
            widthLabel.Text = "Width";
            widthLabel.Click += label5_Click;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new Point(671, 241);
            materialLabel.Margin = new Padding(4, 0, 4, 0);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(143, 22);
            materialLabel.TabIndex = 10;
            materialLabel.Text = "Desktop Material";
            materialLabel.Click += materialLabel_Click;
            // 
            // drawerUpDown
            // 
            drawerUpDown.Location = new Point(671, 179);
            drawerUpDown.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            drawerUpDown.Name = "drawerUpDown";
            drawerUpDown.Size = new Size(120, 30);
            drawerUpDown.TabIndex = 4;
            drawerUpDown.ValueChanged += updateEstimate;
            // 
            // widthUpDown
            // 
            widthUpDown.Location = new Point(153, 179);
            widthUpDown.Maximum = new decimal(new int[] { 96, 0, 0, 0 });
            widthUpDown.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
            widthUpDown.Name = "widthUpDown";
            widthUpDown.Size = new Size(120, 30);
            widthUpDown.TabIndex = 2;
            widthUpDown.Value = new decimal(new int[] { 24, 0, 0, 0 });
            widthUpDown.ValueChanged += updateEstimate;
            // 
            // depthUpDown
            // 
            depthUpDown.Location = new Point(153, 267);
            depthUpDown.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            depthUpDown.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            depthUpDown.Name = "depthUpDown";
            depthUpDown.Size = new Size(120, 30);
            depthUpDown.TabIndex = 3;
            depthUpDown.Value = new decimal(new int[] { 12, 0, 0, 0 });
            depthUpDown.ValueChanged += updateEstimate;
            // 
            // materialCB
            // 
            materialCB.FormattingEnabled = true;
            materialCB.Items.AddRange(new object[] { "Laminate", "Oak", "Rosewood", "Veneer", "Pine" });
            materialCB.Location = new Point(671, 266);
            materialCB.Name = "materialCB";
            materialCB.Size = new Size(121, 30);
            materialCB.TabIndex = 5;
            materialCB.SelectedIndexChanged += updateEstimate;
            materialCB.SelectedValueChanged += updateEstimate;
            // 
            // addSubmitButton
            // 
            addSubmitButton.BackColor = SystemColors.GradientActiveCaption;
            addSubmitButton.FlatAppearance.MouseDownBackColor = Color.Yellow;
            addSubmitButton.FlatAppearance.MouseOverBackColor = Color.Cyan;
            addSubmitButton.Location = new Point(153, 334);
            addSubmitButton.Name = "addSubmitButton";
            addSubmitButton.Size = new Size(274, 127);
            addSubmitButton.TabIndex = 6;
            addSubmitButton.Text = "Place Order";
            addSubmitButton.UseVisualStyleBackColor = false;
            addSubmitButton.Click += addSubmitButton_Click;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Garamond", 20F);
            costLabel.Location = new Point(671, 334);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(220, 38);
            costLabel.TabIndex = 11;
            costLabel.Text = "Estimated Cost";
            // 
            // estimatedPriceLabel
            // 
            estimatedPriceLabel.AutoSize = true;
            estimatedPriceLabel.Location = new Point(671, 386);
            estimatedPriceLabel.Name = "estimatedPriceLabel";
            estimatedPriceLabel.Size = new Size(28, 22);
            estimatedPriceLabel.TabIndex = 12;
            estimatedPriceLabel.Text = "$0";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(estimatedPriceLabel);
            Controls.Add(costLabel);
            Controls.Add(addSubmitButton);
            Controls.Add(materialCB);
            Controls.Add(depthUpDown);
            Controls.Add(widthUpDown);
            Controls.Add(drawerUpDown);
            Controls.Add(materialLabel);
            Controls.Add(widthLabel);
            Controls.Add(drawerLabel);
            Controls.Add(depthLable);
            Controls.Add(label2);
            Controls.Add(rushCB);
            Controls.Add(label1);
            Controls.Add(nameLabel);
            Controls.Add(name);
            Controls.Add(addBackButton);
            Font = new Font("Garamond", 12F);
            Margin = new Padding(4);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Place Order";
            ((System.ComponentModel.ISupportInitialize)drawerUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)depthUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBackButton;
        private TextBox name;
        private Label nameLabel;
        private Label label1;
        private ComboBox rushCB;
        private Label label2;
        private Label depthLable;
        private Label drawerLabel;
        private Label widthLabel;
        private Label materialLabel;
        private NumericUpDown drawerUpDown;
        private NumericUpDown widthUpDown;
        private NumericUpDown depthUpDown;
        private ComboBox materialCB;
        private Button addSubmitButton;
        private Label costLabel;
        private Label estimatedPriceLabel;
    }
}