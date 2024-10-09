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

            MessageBox.Show($"Order placed!\n" +
                $"Name: {name.Text}\n" +
                $"Rush Order: {rushOrder}\n" +
                $"Material: {materialOrder}\n" +
                $"Number of Drawers: {drawersOrder}\n" +
                $"Width: {widthOrder}\n" +
                $"Depth: {depthOrder}\n" +
                $"Total: $1,000,000");
            return;
        }
    }
}
