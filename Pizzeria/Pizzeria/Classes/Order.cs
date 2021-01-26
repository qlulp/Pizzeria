using Pizzeria.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Classes
{
    public class Order
    {
        // Сумма без скидок
        public int AmountWithoutDiscount = 0;

        // Сумма скидки
        public int DiscountSum = 0;

        // Итогово (с учётом скидки)
        public int TotalAmount = 0;

        public List<ProductCard> Products;

        public string Username;

        public Order()
        {
            Products = new List<ProductCard>();
        }
    }
}
