using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void addBackButton_Click(object sender, EventArgs e)
        {
            MegaDesk back = new MegaDesk();
            back.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drawerUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updateEstimate(object sender, EventArgs e)
        {
            estimatedPriceLabel.Text = $"${calculatePrice()}";
        }

        private int calculatePrice()
        {
            string nameOrder = name.Text;
            string rushOrder = rushCB.SelectedItem?.ToString() ?? "None";
            string materialOrder = materialCB.SelectedItem?.ToString();
            int drawersOrder = (int)drawerUpDown.Value;
            int widthOrder = (int)widthUpDown.Value;
            int depthOrder = (int)depthUpDown.Value;

            int sqInches = widthOrder * depthOrder;
            int sizePrice = 0;
            int deskPrice = 200;
            int drawerPrice = drawersOrder * 50;

            if (sqInches > 1000)
            {
                sizePrice = sqInches - 1000;
            }

            Dictionary<string, int> materialCosts = new Dictionary<string, int>
            {
                { "Oak", 200 },
                { "Laminate", 100 },
                { "Pine", 50 },
                { "Rosewood", 300 },
                { "Veneer", 125 }
            };

            int materialsPrice = 0;
            if (materialCB.SelectedItem != null)
            {
                materialsPrice = materialCosts[materialOrder];
            }

            deskPrice += materialsPrice + drawerPrice + sizePrice;

            return deskPrice;
        }

        private void addSubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) ||
                string.IsNullOrEmpty(materialCB.SelectedItem?.ToString()))

            {
                MessageBox.Show("Please input all information");
                return;
            }

            string nameOrder = name.Text;
            string rushOrder = rushCB.SelectedItem?.ToString() ?? "None";
            string materialOrder = materialCB.SelectedItem?.ToString();  
            int drawersOrder = (int)drawerUpDown.Value;
            int widthOrder = (int)widthUpDown.Value;
            int depthOrder = (int)depthUpDown.Value;

            int sqInches = widthOrder * depthOrder;
            int sizePrice = 0;
            int deskPrice = 200;
            int drawerPrice = drawersOrder * 50;

            if (sqInches > 1000)
            {
                sizePrice = sqInches - 1000;
            }

            Dictionary<string, int> materialCosts = new Dictionary<string, int>
            {
                { "Oak", 200 },
                { "Laminate", 100 },
                { "Pine", 50 },
                { "Rosewood", 300 },
                { "Veneer", 125 }
            };

            int materialsPrice = materialCosts[materialOrder];

            deskPrice += materialsPrice + drawerPrice + sizePrice;

            MessageBox.Show($"Order placed!\n" +
                $"Name: {name.Text}\n" +
                $"Rush Order: {rushOrder}\n" +
                $"Material: {materialOrder}\n" +
                $"Number of Drawers: {drawersOrder}\n" +
                $"Width: {widthOrder}\n" +
                $"Depth: {depthOrder}\n" +
                $"Total: ${deskPrice}");
            return;
        }
    }
}
