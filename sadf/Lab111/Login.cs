using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab111
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtName.Text == "admin") && (txtPass.Text == "admin"))
            {
                Menu m = new Menu();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
