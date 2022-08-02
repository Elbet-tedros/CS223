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
                        inventorNum = int.Parse(txt_num.Text)
                    };
                    cl.save();
                    gdv.DataSource = null;
                    gdv.DataSource = Class1.getAll();
                }
                catch (Exception)
                {
                    MessageBox.Show("Type Mismatch");
                };
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
