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
    public partial class DisplayProduct : Form
    {
        public DisplayProduct()
        {
            InitializeComponent();
        }

        private void DisplayProduct_Load(object sender, EventArgs e)
        {
            foreach (var item in Class1.getAll())
            {
                ProductCard pc = new ProductCard();

                pc.MyObjName = item.object_name;

                pc.MyPrice = item.price;
                pc.Click += (object o, EventArgs e2) =>
                {
                    DetailsPage dp = new DetailsPage(item.number,item.inventorNum,item.count);
                    dp.Show();
                };
                flp.Controls.Add(pc);

            }
        }
    }
}
