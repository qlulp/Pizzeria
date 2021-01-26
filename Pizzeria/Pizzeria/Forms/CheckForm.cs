using Pizzeria.Classes;
using Pizzeria.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria.Forms
{
    public partial class CheckForm : Form
    {
        Order CurrentOrder;
        DataBaseManager Manager;
        public CheckForm(Order order)
        {
            InitializeComponent();
            Manager = new DataBaseManager();
            CurrentOrder = order;
        }

        private void WriteCheck()
        {
            
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {
            string endLine = Environment.NewLine;
            CheckTextBox.Text = "Организация: \"ООО Рога и копыта\"" + endLine +
                $"Время: {DateTime.Now.ToShortTimeString()}" + endLine +
                "Товары:" + endLine;
            foreach (ProductCard product in CurrentOrder.Products)
            {
                CheckTextBox.Text += $"  - {product.FullProductName} {product.Count}шт. = {product.Price * product.Count}" + endLine;
            }

            CheckTextBox.Text += $"Сумма: {CurrentOrder.AmountWithoutDiscount}" + endLine +
                $"Скидка: {CurrentOrder.DiscountSum}"+ endLine +
                $"Итогово: {CurrentOrder.TotalAmount}";
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Manager.RegisterCheck(CurrentOrder);
            Manager.RegisterProductCheck(CurrentOrder);
            Close();
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("Чек.txt"))
            {
                writetext.WriteLine(CheckTextBox.Text);
            }
        }
    }
}
