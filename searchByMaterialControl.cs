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
            nameLabel.Text = $"{deskQuote.FirstName} {deskQuote.LastName}";   
            dateLabel.Text = $"Ordered On: {deskQuote.QuoteDate.ToString("MMMM dd yyyy")}";
            widthLabel.Text = deskQuote.Desk.Width.ToString();
            depthLabel.Text = deskQuote.Desk.Depth.ToString();
            areaLabel.Text = deskQuote.surfaceArea.ToString();
            materialLabel.Text = deskQuote.Desk.Material.ToString();
            drawerLabel.Text = deskQuote.Desk.NumberOfDrawers.ToString();
            priceLabel.Text = "$" + deskQuote.totalPrice.ToString();
        }

    }
}
