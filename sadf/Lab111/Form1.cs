using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; //for regex
using System.Threading.Tasks;
using System.Windows.Forms;

using Lab111;

namespace Lab111
{
    public partial class Form1 : Form
    {
        private object txtNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ErrPro.Clear();
            Regex r = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(txt_num.Text))
            {
                ErrPro.SetError(txt_num, "Num is required");
            }
            else if (string.IsNullOrEmpty(txt_inv.Text))
            {
                ErrPro.SetError(txt_inv, "Inv num is required");
            }
            else if (string.IsNullOrEmpty(txt_price.Text))
            {
                ErrPro.SetError(txt_price, "Price is required");
            }
            else if (string.IsNullOrEmpty(txt_count.Text))
            {
                ErrPro.SetError(txt_count, "Count is required");
            }
            else if (string.IsNullOrEmpty(txt_obj.Text))
            {
                ErrPro.SetError(txt_obj, "Obj name is required");
            }
            else if (!r.IsMatch(txt_obj.Text))
            {
                ErrPro.SetError(txt_obj, "Obj name should not have numbers");
            }
            else
            {
                try
                {
                    Class1 cl = new Class1
                    {
                        count = int.Parse(txt_count.Text),
                        price = int.Parse(txt_price.Text),
                        number = int.Parse(txt_num.Text),
                        object_name = txt_obj.Text,
                        inventorNum = int.Parse(txt_num.Text),
                        isAvailable= chkAvailability.Checked,
                        urgent=rbu.Checked,
                        noturgent=rbn.Checked,
                    };
                    cl.save();
                    gdv.DataSource = null;
                    gdv.DataSource = Class1.getAll();
                }
                catch (Exception)
                {
                    MessageBox.Show("Type Mismatch");
                };
                txt_inv.Text = "";
                txt_count.Text = "";
                txt_price.Text = "";
                txt_num.Text = "";
                txt_obj.Text = "";
                chkAvailability.Checked = false;
                rbu.Checked = false;
                rbn.Checked = false; 
                
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblInventoryNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblObjectNumber_Click(object sender, EventArgs e)
        {

        }

        private void gdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
