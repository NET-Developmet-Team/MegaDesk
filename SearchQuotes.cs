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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        // Return to MainMenu
        private void button1_Click(object sender, EventArgs e)
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
    }
}
