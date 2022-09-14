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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            var P = Class1.findOne(txtsearch.Text);
            //p either returns the list if match is found
            //nothing if match is not found
            if (P == null)
            {
                MessageBox.Show("No match found");
            }
            else
            {
                MessageBox.Show("Match found");
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
