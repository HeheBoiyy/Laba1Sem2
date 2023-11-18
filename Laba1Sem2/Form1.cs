using Semi;
using Snack;
using Healthy;
using NonFood;
namespace Laba1Sem2
{
    public partial class MainForm : Form
    {
        private Cart<IFood> cart = new Cart<IFood>();
        public List<IThing> UMarket = new List<IThing>
        {
            new ChocolateBar(),
            new Crisps(),
            new BalykCheese(),
            new DumplingBerries(),
            new DumplingsMeat(),
            new Cheburek(),
            new Chicken(),
            new OliveOil(),
            new Fruit(),
            new NoteBook(),
            new NonFood.Pen()

        };
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(Cart<IFood> cart)
        {
            InitializeComponent();
            this.cart = cart;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(cart, UMarket);
            this.Hide();
            addProductForm.Show();
        }

        private void CartBalance_Click(object sender, EventArgs e)
        {
            if (cart != null)
            {
                cart.Balance();
            }
            else
            {
                MessageBox.Show("Корзина пуста, нечего балансировать");
            }

        }

        private void CorzinaLook_Click(object sender, EventArgs e)
        {
            YourCart yourCart = new YourCart(cart);
            this.Hide();
            yourCart.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}