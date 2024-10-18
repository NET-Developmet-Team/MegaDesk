using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Alexander
{
    public partial class searchByMaterialControl : UserControl
    {
        public searchByMaterialControl(DeskQuote deskQuote)
        {
            InitializeComponent();
            nameLabel.Text = (deskQuote.FirstName + " " + deskQuote.LastName);
            dateLabel.Text = deskQuote.QuoteDate.ToString("dd MMMM yyyy");
            widthLabel.Text = "Width: " + deskQuote.Desk.Width.ToString();
            depthLabel.Text = "Depth: " + deskQuote.Desk.Depth.ToString();
            areaLabel.Text = "Area: " + deskQuote.surfaceArea.ToString();
            materialLabel.Text = "Material: " + deskQuote.Desk.Material.ToString();
            drawerLabel.Text = "Drawer Count: " + deskQuote.Desk.NumberOfDrawers.ToString();
            priceLabel.Text = "Price: " + deskQuote.totalPrice.ToString();
        }

        private void depthLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
