using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_Alexander
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent(); 
            surfaceMaterialComboBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        // Navigate back to Main Menu
        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            var viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Hide();
        }


        // Make the X in the top right actually exit the program
        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region ValidationMethods
        // Validate input for Width 
        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Check if input is an integer
            if (int.TryParse(widthTextBox.Text, out int width))
            {
                // Check if input is within proper range
                if (width >= Desk.MIN_WIDTH && width <= Desk.MAX_WIDTH)
                {
                    // If input is good, clear error indicators
                    widthTextBox.BackColor = Color.White;
                    widthLabel.ForeColor = Color.Black;
                    widthLabel.Text = $"Width ({Desk.MIN_WIDTH}-{Desk.MAX_WIDTH} inches)";

                }
                // Otherwise input is not in range, flag input as an invalid
                else
                {
                    widthTextBox.BackColor = Color.LightCoral;
                    widthLabel.ForeColor = Color.LightCoral;
                    widthLabel.Text = $"Must be between {Desk.MIN_WIDTH} and {Desk.MAX_WIDTH} inches";
                    e.Cancel = true;
                }
            }
            // Otherwise input is not an integer, flag input as an invalid
            else
            {
                widthTextBox.BackColor = Color.LightCoral;
                widthLabel.ForeColor = Color.LightCoral;
                widthLabel.Text = "Must be an integer";
                e.Cancel = true;
            }

        }


        // Only allow integers as an input for depth
        private void depthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {   // Check if the individual input char is a digit or control character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numberOfDrawersTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int drawerNum = int.Parse(numberOfDrawersTextBox.Text);

                // Check if drawNum is between 0 and 7
                if ((drawerNum >= Desk.MIN_DRAWERS) && (drawerNum <= Desk.MAX_DRAWERS))
                {
                    numberOfDrawersTextBox.BackColor = Color.White;
                    numberOfDrawersLabel.ForeColor = Color.Black;
                    numberOfDrawersLabel.Text = $"Number of Drawers ({Desk.MIN_DRAWERS}-{Desk.MAX_DRAWERS})";
                    return; // Exit early
                }
                else
                {
                    // Otherwise flag as bad input
                    numberOfDrawersTextBox.BackColor = Color.LightCoral;
                    numberOfDrawersLabel.ForeColor = Color.LightCoral;
                    numberOfDrawersLabel.Text = $"Must be between {Desk.MIN_DRAWERS} and {Desk.MAX_DRAWERS}";
                    numberOfDrawersTextBox.Focus();
                }
            }
            catch (FormatException)
            {
                // Handle case where input is not a valid integer
                numberOfDrawersTextBox.BackColor = Color.LightCoral;
                numberOfDrawersLabel.ForeColor = Color.LightCoral;
                numberOfDrawersLabel.Text = "Please enter a valid number.";
                numberOfDrawersTextBox.Focus();
            }

        }


        // Validate input for Depth
        private void depthTextBox_Leave(object sender, EventArgs e)
        {
            // Check if the TextBox is empty
            if (string.IsNullOrWhiteSpace(depthTextBox.Text))
            {
                // Reset to default state when empty
                depthTextBox.BackColor = Color.White;
                depthLabel.ForeColor = Color.Black;
                depthLabel.Text = $"Depth ({Desk.MIN_DEPTH}-{Desk.MAX_DEPTH} inches)";
                return; // Exit early
            }

            // Check if full input is an integer
            if (int.TryParse(depthTextBox.Text, out int depth))
            {
                // Check if input is within proper range
                if (depth >= Desk.MIN_DEPTH && depth <= Desk.MAX_DEPTH)
                {
                    depthTextBox.BackColor = Color.White;
                    depthLabel.ForeColor = Color.Black;
                    depthLabel.Text = $"Depth ({Desk.MIN_DEPTH}-{Desk.MAX_DEPTH} inches)";
                }
                else// 
                {
                    // Input is not in range, flag input as invalid
                    depthTextBox.BackColor = Color.LightCoral;
                    depthLabel.ForeColor = Color.LightCoral;
                    depthLabel.Text = $"Must be between {Desk.MIN_DEPTH} and {Desk.MAX_DEPTH} inches";
                    depthTextBox.Focus();
                }
            }
            else
            {
                // Input is not an integer, flag input as invalid
                depthTextBox.BackColor = Color.LightCoral;
                depthLabel.ForeColor = Color.LightCoral;
                depthLabel.Text = "Must be an integer";
                depthTextBox.Focus();
            }
        }
        private bool ValidateFields()
        {
            bool isValid = true;

            // Create list of controls and label paires
            var fieldsToValidate = new (Control input, Label label, string defaultText)[]
            {
            (firstNameTextBox, firstNameLabel, "First Name"),
            (lastNameTextBox, lastNameLabel, "Last Name"),
            (numberOfDrawersTextBox, numberOfDrawersLabel, "Number Of Drawers"),
            (surfaceMaterialComboBox, surfaceMaterialLabel, "Surface Material"),
            (rushOrderDaysComboBox, rushOrderDaysLabel, "Rush Order Days"),
            (depthTextBox, depthLabel, "Depth"),
            (widthTextBox,  widthLabel, "Width")
            };

            // Iterate through fields and make sure each has a value
            foreach (var (input, label, defaultText) in fieldsToValidate)
            {
                // If a field is still empty, turn it red set isValid = false
                if (string.IsNullOrWhiteSpace(input.Text))
                {
                    input.BackColor = Color.LightCoral;
                    label.ForeColor = Color.LightCoral;
                    label.Text = $"Must enter {defaultText.ToLower()}";
                    isValid = false;
                }
                else
                {
                    input.BackColor = Color.White;
                    label.ForeColor = Color.Black;
                    label.Text = defaultText;
                }
            }

            // Check if a material was selected
            if (surfaceMaterialComboBox.SelectedItem.Equals(DesktopMaterial.None))
            {
                isValid = false;
                surfaceMaterialComboBox.BackColor = Color.LightCoral;
                surfaceMaterialLabel.ForeColor = Color.LightCoral;
                surfaceMaterialLabel.Text = "Please select a material";
            }
            else
            {
                surfaceMaterialComboBox.BackColor = Color.White;
                surfaceMaterialLabel.ForeColor = Color.Black;
                surfaceMaterialLabel.Text = "Surface Material";
            }

            return isValid;
        }

        #endregion
        private void submitNewQuoteButton_Click(object sender, EventArgs e)
        {

            // Check to make sure all inputs are good.
            if (!ValidateFields())
            {
                MessageBox.Show("Please correct the highlighted fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            
            // Save desk related input values into local variables
            int width = int.Parse(widthTextBox.Text);
            int depth = int.Parse(depthTextBox.Text);
            int numberOfDrawers = int.Parse(numberOfDrawersTextBox.Text);
            DesktopMaterial surfaceMaterial = (DesktopMaterial)surfaceMaterialComboBox.SelectedItem;

            // Create a new Desk object
            Desk newDesk = new Desk(width, depth, numberOfDrawers, surfaceMaterial);

            // Save customer information
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            int rushOrderDays = int.Parse(rushOrderDaysComboBox.SelectedItem.ToString());

            // Create a new DeskQoute Object
            DeskQuote newDeskQuote = new DeskQuote(firstName, lastName, newDesk, rushOrderDays);

            // Navigate to DisplayQuote form
            DisplayQuote displayQuoteForm = new DisplayQuote(newDeskQuote);
            displayQuoteForm.Tag = this.Tag;
            displayQuoteForm.Show();
            this.Hide();
        }

        
    }
}
