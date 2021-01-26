using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria.Classes
{
    class DataBaseManager
    {
        private string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PizzeriaDB.accdb";
        public List<Product> GetAllProducts()
        {
            List<Product> result = new List<Product>();

            DataTable products = GetTable("Блюда");

            for (int i = 0; i < products.Rows.Count; i++)
            {
                string name = products.Rows[i].Field<string>("Название");
                string price = products.Rows[i].Field<decimal>("Цена").ToString();
                result.Add(new Product(name, price));
            }

            return result;
        }


        // Получить таблицу по названию
        public DataTable GetTable(string tableName)
        {
            DataTable result = new DataTable(tableName);
            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    string query = "SELECT * FROM " + tableName;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        // Вход 
        public bool SignIn(string login, string password)
        {
            bool access = false;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    DataTable table = new DataTable();
                    string query = $"SELECT * FROM Сотрудники WHERE Логин LIKE '{login}' AND Пароль LIKE '{password}'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                        access = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return access;
        }

        // Получить скидку по промокоду
        // Если промокод не действительный, то скидка = 0р.
        public int GetDiscountByPromoCode(string promoCode)
        {
            int discountSum = 0;
            DataTable table = new DataTable();
            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    string query = $"SELECT * FROM Промокоды WHERE Код LIKE '{promoCode}'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (table.Rows.Count > 0)
                discountSum = Convert.ToInt32(table.Rows[0].Field<decimal>("Скидка"));

            return discountSum;
        }

        // Регистрация Чека в БД
        public void RegisterCheck(Order order)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    string query = $"INSERT INTO Чек ([Время заказа], Стоимость, [Стоимость без скидки], [Размер скидки], [№ Сотрудника]) VALUES" +
                        $"('{DateTime.Now.ToShortTimeString()}', {order.AmountWithoutDiscount}, {order.DiscountSum}, {order.TotalAmount}, {GetIdOfByUsername(order.Username)});";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(new DataTable());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Получить ID по имени пользователя
        private int GetIdOfByUsername(string username)
        {
            DataTable table = new DataTable();
            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    string query = $"SELECT * FROM Сотрудники WHERE Логин LIKE '{username}'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (table.Rows.Count > 0)
                return table.Rows[0].Field<int>("№ Сотрудника");
            return -1;
        }

        // Заполнить таблицу "БлюдаЧек" 
        public void RegisterProductCheck(Order order)
        {
            // Костыль - Получаю последний номер чека в таблице "Чек"
            // Другую реализациюю ещё не придумал, т. к. тип номера чека - это счётчик
            DataTable table = GetTable("Чек");
            int ID = table.Rows[table.Rows.Count - 1].Field<int>("№ Чека");

            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    for (int i = 0; i < order.Products.Count; i++)
                    {
                        string query = $"INSERT INTO БлюдаЧек ([№ Блюда], Чек) " +
                                $"VALUES({GetIDOfProductByName(order.Products[i].FullProductName)}, {ID})";
                    OleDbCommand command = new OleDbCommand(query, connection);
                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetIDOfProductByName(string productName)
        {
            DataTable table = new DataTable();
            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    string query = $"SELECT * FROM Блюда WHERE Название LIKE '{productName}'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (table.Rows.Count > 0)
                return table.Rows[0].Field<int>("№ Блюда");
            return -1;
        }
    }
}
