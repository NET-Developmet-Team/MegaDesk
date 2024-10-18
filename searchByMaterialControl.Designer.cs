namespace MegaDesk_Alexander
{
    partial class searchByMaterialControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(3, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 34);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold);
            this.dateLabel.Location = new System.Drawing.Point(474, 11);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(273, 31);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(45, 74);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(78, 30);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "width";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(45, 133);
            this.depthLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(79, 30);
            this.depthLabel.TabIndex = 5;
            this.depthLabel.Text = "depth";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depthLabel.Click += new System.EventHandler(this.depthLabel_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(349, 73);
            this.areaLabel.Margin = new System.Windows.Forms.Padding(0);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(61, 30);
            this.areaLabel.TabIndex = 6;
            this.areaLabel.Text = "area";
            this.areaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerLabel.Location = new System.Drawing.Point(328, 133);
            this.drawerLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(102, 30);
            this.drawerLabel.TabIndex = 11;
            this.drawerLabel.Text = "drawers";
            this.drawerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel
            // 
            this.materialLabel.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(514, 67);
            this.materialLabel.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(233, 36);
            this.materialLabel.TabIndex = 12;
            this.materialLabel.Text = "Material: Laminate";
            this.materialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(600, 132);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(147, 30);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchByMaterialControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "searchByMaterialControl";
            this.Size = new System.Drawing.Size(862, 222);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}
