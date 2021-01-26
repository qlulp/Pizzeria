using Pizzeria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria.Controls
{
    public partial class ProductCard : UserControl
    {
        // Выбрано ли
        public bool IsSelected
        {
            get
            {
                if (Count > 0)
                    return true;
                return false;
            }
            set
            {
                IsSelected = value;
            }
        }
        // Количество
        public int Count
        {
            get
            {
                return Convert.ToInt32(CountTextBox.Text);
            }
            set
            {
                if (value >= 0 && value <= 15)
                CountTextBox.Text = Convert.ToString(value);
                if (Count > 0)
                    BackColor = Color.White;
                else
                    BackColor = Color.LightGray;
            }
        }

        // Изображение продука
        public Image ProductImage
        {
            get
            {
                return ProductImagePictureBox.Image;
            }
            set
            {
                ProductImagePictureBox.Image = value;
            }
        }

        // Название продукта
        public string FullProductName
        {
            get
            {
                return ProductNameLabel.Text;
            }
            set
            {
                ProductNameLabel.Text = value;
            }
        }

        // Стоимость
        public int Price
        {
            get
            {
                return Convert.ToInt32(PriceLabel.Text);
            }
            set
            {
                PriceLabel.Text = value.ToString();
            }
        }

        public ProductCard()
        {
            InitializeComponent();
        }

        private void AddLabel_Click(object sender, EventArgs e)
        {
            Count++;
        }

        private void RemoveLabel_Click(object sender, EventArgs e)
        {
            Count--;
        }

        private void CountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CountTextBox.Text, out int result))
            {
                if (!(result >= 0 && result <= 15))
                    CountTextBox.Text = "0";
                Count = Count;
            }
            else
            {
                CountTextBox.Text = "0";
            }
        }
    }
}
