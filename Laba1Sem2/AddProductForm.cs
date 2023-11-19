using Snack;
using Healthy;
using Semi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace Laba1Sem2
{
    public partial class AddProductForm : Form
    {
        private Cart<IFood> cart;
        protected string lookcarzina;
        private List<IThing> things;
        public AddProductForm(Cart<IFood> cart, List<IThing> things)
        {
            InitializeComponent();
            this.things = things;
            this.cart = cart;
            foreach (var item in things)
            {
                listBox1.Items.Add(item.Name);
            }
            if (cart != null)
            {
                foreach (IFood thing in cart)
                {
                    listBox2.Items.Add(thing.Name);
                }
                Controls.Add(listBox1);
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Вы ничего не выбрали");
            }
            else
            {
                if (listBox1.SelectedItem.ToString() != "Ноутбук" & listBox1.SelectedItem.ToString() != "Ручка")
                {
                    string selection = listBox1.SelectedItem.ToString();
                    cart.Add(selection, things);
                    listBox2.Items.Add(listBox1.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Выбранный предмет не является продовльственным продуктом");
                }
            }
        }

        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(cart);
            this.Hide();
            mainForm.Show();
        }
    }
}
