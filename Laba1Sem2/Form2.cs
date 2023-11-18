using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1Sem2
{
    public partial class YourCart : Form
    {
        private Cart<IFood> cart = new Cart<IFood>();
        public YourCart(Cart<IFood> cart)
        {
            this.cart = cart;
            InitializeComponent();
            if (cart != null)
            {
                foreach (IFood item in cart)
                {
                    listBox1.Items.Add(item.Name);
                }
                Controls.Add(listBox1);
            }
            else
            {
                listBox1.Items.Add("Здесь пусто:(");
            }
        }

        private void YourCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm(cart);
            this.Hide();
            mainForm.Show();
        }
    }
}
