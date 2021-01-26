using Pizzeria.Classes;
using Pizzeria.Controls;
using Pizzeria.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        private DataBaseManager Manager;
        OrderForm Order;
        private bool Access = false;
        public Form1()
        {
            InitializeComponent();

            Manager = new DataBaseManager();
            List<Product> products = Manager.GetAllProducts();
            foreach (Product product in products)
            {
                ProductCard temp = new ProductCard();
                temp.FullProductName = product.Name;
                temp.Price = int.Parse(product.Price);
                ProductsListPanel.Controls.Add(temp);
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Access = Manager.SignIn
            (
                login: LoginTextBox.Text,
                password: PasswordTextBox.Text
            );

            if (Access)
            {
                MessageBox.Show($"Добро пожаловать, {LoginTextBox.Text}", "Вход", MessageBoxButtons.OK);
                LoginTextBox.Enabled = PasswordTextBox.Enabled = false;
                ProductsListPanel.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Ошибка входа", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginTextBox.Text = PasswordTextBox.Text = string.Empty;
                ProductsListPanel.Enabled = false;
            }
        }

        private void MakeOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Username = LoginTextBox.Text;
            foreach (var ProductCard in ProductsListPanel.Controls.OfType<ProductCard>())
            {
                if (ProductCard.IsSelected)
                    order.Products.Add(ProductCard);
            }
            if (order.Products.Count > 0)
            {
                Order = new OrderForm(order);
                Order.Show();
            }
        }
    }
}
