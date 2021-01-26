using Pizzeria.Classes;
using Pizzeria.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria.Forms
{
    public partial class OrderForm : Form
    {
        Order CurrentOrder;
        // Сумма без скидок
        private int AmountWithoutDiscount = 0;

        // Сумма скидки
        private int DiscountSum = 0;

        // Итогово (с учётом скидки)
        private int TotalAmount = 0;

        DataBaseManager Manager;

        CheckForm Check;

        public OrderForm(Order order)
        {
            InitializeComponent();
            CurrentOrder = order;
            Manager = new DataBaseManager();

            foreach (ProductCard product in CurrentOrder.Products)
            {
                AmountWithoutDiscount += product.Count * product.Price;
            }
            TotalAmount = AmountWithoutDiscount - DiscountSum;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetCheck_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && PhoneNumberTextBox.Text != "" && AdresTextBox.Text != "")
            {
                CurrentOrder.AmountWithoutDiscount = AmountWithoutDiscount;
                CurrentOrder.DiscountSum = DiscountSum;
                CurrentOrder.TotalAmount = TotalAmount;
                Check = new CheckForm(CurrentOrder);
                Check.Show();
                Close();
            }
            else MessageBox.Show("Необходимо заполнить все контактные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CheckPromoCodeButton_Click(object sender, EventArgs e)
        {
            string promoCode = PromoCodeTextBox.Text;
            if (promoCode != "")
            {
                DiscountSum = Manager.GetDiscountByPromoCode(promoCode);
                TotalAmount = AmountWithoutDiscount - DiscountSum;
                if (TotalAmount < 0)
                    TotalAmount = 0;
                UpdatePrice();
            }
            else
            {
                PromoCodeTextBox.Text = string.Empty;
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            OrderPriceLabel.Text = AmountWithoutDiscount.ToString() + "р.";
            TotalAmountLabel.Text = TotalAmount.ToString();
        }
    }
}
