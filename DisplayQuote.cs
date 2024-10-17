using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Alexander
{
    public partial class DisplayQuote : Form
    {
      

        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();

            // Populate labels with DeskQuote data
            baseDeskPriceLabel.Text = quote.BaseDeskPrice.ToString();
            materialPriceLabel.Text = quote.materialPrice.ToString();
            largeSurfaceAreaPriceLabel.Text = quote.surfaceAreaSurcharge.ToString();
            drawerPriceLabel.Text = quote.drawerPrice.ToString();
            rushOrderPriceLabel.Text= quote.rushOrderPrice.ToString();
            totalPriceLabel.Text = quote.totalPrice.ToString();
            nameLabel.Text = quote.FirstName + " " + quote.LastName;
            areaLabel.Text = quote.surfaceArea.ToString();
            dateLabel.Text = quote.QuoteDate.ToString("dd MMMM yyyy");

            // Populate lables with Desk data
            widthLabel.Text = quote.Desk.Width.ToString();
            depthLabel.Text = quote.Desk.Depth.ToString();
            materialLabel.Text = quote.Desk.Material.ToString();
            numberOfDrawersLabel.Text = quote.Desk.NumberOfDrawers.ToString();
        }


        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            var viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Hide();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

