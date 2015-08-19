using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartsInventory_15
{
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            SearchParts searchParts = new SearchParts();
            searchParts.Show();
            this.Hide();
        }

        private void btnDisplayParts_Click(object sender, EventArgs e)
        {
            DisplayParts displayParts = new DisplayParts();
            displayParts.Show();
            this.Hide();
        }
    }
}
