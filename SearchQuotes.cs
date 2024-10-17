using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Alexander
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            surfaceMaterialComboBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        // Return to MainMenu
        private void mainMenuReturnButton_Click(object sender, EventArgs e)
        {
            var viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Hide();
        
        }

        // Exit if someone hits exit button in top right
        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void surfaceMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchByMaterialGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   

        }
        
        private void submitNewQuoteButton_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();

            // Get the project directory
            string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "Assets", "quotes.json");

            string json = File.ReadAllText(filePath);
            List<DeskQuote> quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

            List<DeskQuote> results = new List<DeskQuote>();

            foreach (DeskQuote quote in quotes)
            {
                if (quote.GetMaterialName() == surfaceMaterialComboBox.Text)
                {
                    results.Add(quote);

                    var reportItem = new searchByMaterialControl(quote);
                    reportItem.Width = flowLayoutPanel1.ClientSize.Width - 40; // Slight margin
                    flowLayoutPanel1.Controls.Add(reportItem);
                }
            }
            flowLayoutPanel1.Padding = new Padding(10);


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
