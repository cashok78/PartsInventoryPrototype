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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "admin" && txtPwd.Text == "admin123")
            {
                Chamber chamber = new Chamber();
                chamber.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid UserId and Password");
        }


    }
}
