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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MegaDesk megaDesk = new MegaDesk();
            megaDesk.Show();
            this.Close();
        }
    }
}
