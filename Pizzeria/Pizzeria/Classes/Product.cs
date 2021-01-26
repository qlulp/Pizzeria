using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Classes
{
    class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public Product(string name, string price)
        {
            Name = name;
            Price = price;
        }
    }
}
