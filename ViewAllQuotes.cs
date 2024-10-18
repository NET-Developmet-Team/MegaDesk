using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MegaDesk_Alexander
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            LoadQuotes();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Hide();
        }

        private void LoadQuotes()
        {
            // Get the project directory
            string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "Assets", "quotes.json");

            try
            {
                if (File.Exists(filePath))
                {
                    // Read the JSON file
                    string json = File.ReadAllText(filePath);

                    // Deserialize the JSON to a list of DeskQuote objects
                    var quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

                    // Flatten the Desk properties for display
                    var quotesForDisplay = quotes.Select(q => new
                    {
                        q.FullName,
                        q.totalPrice,
                        q.QuoteDate,
                        q.BaseDeskPrice,
                        q.RushOrderDays,
                        q.surfaceAreaSurcharge,
                        q.surfaceArea,
                        q.materialPrice,
                        q.rushOrderPrice,
                        q.drawerPrice,
                        DeskWidth = q.Desk.Width,
                        DeskDepth = q.Desk.Depth,
                        DeskDrawers = q.Desk.NumberOfDrawers,
                        DeskMaterial = q.Desk.Material
                    }).ToList();

                    dataGridViewQuotes.AutoGenerateColumns = false;

                    // Bind the flattened list to the DataGridView
                    dataGridViewQuotes.DataSource = quotesForDisplay;
                }
                else
                {
                    MessageBox.Show("No quotes found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading quotes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
