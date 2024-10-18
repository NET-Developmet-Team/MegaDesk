namespace MegaDesk_Alexander
{
    partial class ViewAllQuotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.Return = new System.Windows.Forms.Button();
            this.dataGridViewQuotes = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceAreaSurcharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrawerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseDeskPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushOrderDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushOrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(13, 507);
            this.Return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(216, 123);
            this.Return.TabIndex = 1;
            this.Return.Text = "Back to Main Menu";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // dataGridViewQuotes
            // 
            this.dataGridViewQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.TotalPrice,
            this.SurfaceArea,
            this.SurfaceAreaSurcharge,
            this.DeskMaterial,
            this.MaterialPrice,
            this.DeskDrawers,
            this.DrawerPrice,
            this.BaseDeskPrice,
            this.RushOrderDays,
            this.RushOrderPrice,
            this.DeskWidth,
            this.DeskDepth,
            this.QuoteDate});
            this.dataGridViewQuotes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewQuotes.Name = "dataGridViewQuotes";
            this.dataGridViewQuotes.RowHeadersWidth = 62;
            this.dataGridViewQuotes.RowTemplate.Height = 28;
            this.dataGridViewQuotes.Size = new System.Drawing.Size(864, 487);
            this.dataGridViewQuotes.TabIndex = 2;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.Width = 150;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "totalPrice";
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 8;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 150;
            // 
            // SurfaceArea
            // 
            this.SurfaceArea.DataPropertyName = "surfaceArea";
            this.SurfaceArea.HeaderText = "Surface Area";
            this.SurfaceArea.MinimumWidth = 8;
            this.SurfaceArea.Name = "SurfaceArea";
            this.SurfaceArea.Width = 150;
            // 
            // SurfaceAreaSurcharge
            // 
            this.SurfaceAreaSurcharge.DataPropertyName = "surfaceAreaSurcharge";
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.SurfaceAreaSurcharge.DefaultCellStyle = dataGridViewCellStyle2;
            this.SurfaceAreaSurcharge.HeaderText = "Surface Area Subcharge";
            this.SurfaceAreaSurcharge.MinimumWidth = 8;
            this.SurfaceAreaSurcharge.Name = "SurfaceAreaSurcharge";
            this.SurfaceAreaSurcharge.Width = 150;
            // 
            // DeskMaterial
            // 
            this.DeskMaterial.DataPropertyName = "DeskMaterial";
            this.DeskMaterial.HeaderText = "Desk Material";
            this.DeskMaterial.MinimumWidth = 8;
            this.DeskMaterial.Name = "DeskMaterial";
            this.DeskMaterial.Width = 150;
            // 
            // MaterialPrice
            // 
            this.MaterialPrice.DataPropertyName = "materialPrice";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.MaterialPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaterialPrice.HeaderText = "Material Price";
            this.MaterialPrice.MinimumWidth = 8;
            this.MaterialPrice.Name = "MaterialPrice";
            this.MaterialPrice.Width = 150;
            // 
            // DeskDrawers
            // 
            this.DeskDrawers.DataPropertyName = "DeskDrawers";
            this.DeskDrawers.HeaderText = "Desk Drawers";
            this.DeskDrawers.MinimumWidth = 8;
            this.DeskDrawers.Name = "DeskDrawers";
            this.DeskDrawers.Width = 150;
            // 
            // DrawerPrice
            // 
            this.DrawerPrice.DataPropertyName = "drawerPrice";
            dataGridViewCellStyle4.Format = "C0";
            this.DrawerPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.DrawerPrice.HeaderText = "Drawer Price";
            this.DrawerPrice.MinimumWidth = 8;
            this.DrawerPrice.Name = "DrawerPrice";
            this.DrawerPrice.Width = 150;
            // 
            // BaseDeskPrice
            // 
            this.BaseDeskPrice.DataPropertyName = "BaseDeskPrice";
            dataGridViewCellStyle5.Format = "C0";
            this.BaseDeskPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.BaseDeskPrice.HeaderText = "Base Desk Price";
            this.BaseDeskPrice.MinimumWidth = 8;
            this.BaseDeskPrice.Name = "BaseDeskPrice";
            this.BaseDeskPrice.Width = 150;
            // 
            // RushOrderDays
            // 
            this.RushOrderDays.DataPropertyName = "RushOrderDays";
            this.RushOrderDays.HeaderText = "Rush Order Days";
            this.RushOrderDays.MinimumWidth = 8;
            this.RushOrderDays.Name = "RushOrderDays";
            this.RushOrderDays.Width = 150;
            // 
            // RushOrderPrice
            // 
            this.RushOrderPrice.DataPropertyName = "rushOrderPrice";
            dataGridViewCellStyle6.Format = "C0";
            this.RushOrderPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.RushOrderPrice.HeaderText = "Rush Order Price";
            this.RushOrderPrice.MinimumWidth = 8;
            this.RushOrderPrice.Name = "RushOrderPrice";
            this.RushOrderPrice.Width = 150;
            // 
            // DeskWidth
            // 
            this.DeskWidth.DataPropertyName = "DeskWidth";
            this.DeskWidth.HeaderText = "Desk Width";
            this.DeskWidth.MinimumWidth = 8;
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Width = 150;
            // 
            // DeskDepth
            // 
            this.DeskDepth.DataPropertyName = "DeskDepth";
            this.DeskDepth.HeaderText = "Desk Depth";
            this.DeskDepth.MinimumWidth = 8;
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Width = 150;
            // 
            // QuoteDate
            // 
            this.QuoteDate.DataPropertyName = "QuoteDate";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.QuoteDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.QuoteDate.HeaderText = "Quote Date";
            this.QuoteDate.MinimumWidth = 8;
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.Width = 150;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.dataGridViewQuotes);
            this.Controls.Add(this.Return);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.DataGridView dataGridViewQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceAreaSurcharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrawerPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseDeskPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushOrderDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushOrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
    }
}