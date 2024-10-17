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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuoteForm = new AddQuote();
            viewAddQuoteForm.Tag = this;
            viewAddQuoteForm.Show();
            this.Hide();
        }

        // Naviagte to viewQuotesForm
        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show();   
            this.Hide();
        }

        // Naviagte to searchQuotesForm
        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes(); 
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show();
            this.Hide();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

       
    }
}
