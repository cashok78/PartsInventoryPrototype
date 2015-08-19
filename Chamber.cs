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
    public partial class Chamber : Form
    {
        public Chamber()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Parts parts = new Parts();
            parts.Show();
            this.Close();
        }
    }
}
