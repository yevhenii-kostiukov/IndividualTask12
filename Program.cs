using System;
using System.Collections.Generic;

struct Order
{
    public string Product;
    public int Quantity;
    public double Price;
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Dictionary<int, Order> orders = new Dictionary<int, Order>();

        orders.Add(1, new Order
        {
            Product = "Ноутбук",
            Quantity = 2,
            Price = 25000
        });

        orders.Add(2, new Order
        {
            Product = "Мишка",
            Quantity = 3,
            Price = 800
        });

        orders.Add(3, new Order
        {
            Product = "Клавіатура",
            Quantity = 1,
            Price = 1500
        });

        Console.WriteLine("Додавання нового замовлення");

        Console.Write("Введіть номер замовлення: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть назву товару: ");
        string product = Console.ReadLine();

        Console.Write("Введіть кількість: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть ціну: ");
        double price = Convert.ToDouble(Console.ReadLine());

        orders.Add(id, new Order
        {
            Product = product,
            Quantity = quantity,
            Price = price
        });

        Console.WriteLine("Замовлення успішно додано!");
        Console.WriteLine();

        double totalOrders = 0;

        foreach (var item in orders)
        {
            Console.WriteLine($"Номер замовлення: {item.Key}");
            Console.WriteLine($"Товар: {item.Value.Product}");
            Console.WriteLine($"Кількість: {item.Value.Quantity}");
            Console.WriteLine($"Ціна: {item.Value.Price} грн.");

            double total = item.Value.Quantity * item.Value.Price;
            Console.WriteLine($"Загальна вартість: {total} грн.");

            totalOrders += total;

            Console.WriteLine();
        }

        Console.WriteLine($"Загальна сума всіх замовлень: {totalOrders} грн.");
        Console.WriteLine();

        Console.Write("Введіть номер замовлення для пошуку: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        if (orders.ContainsKey(searchId))
        {
            Order foundOrder = orders[searchId];

            Console.WriteLine("Замовлення знайдено!");
            Console.WriteLine($"Товар: {foundOrder.Product}");
            Console.WriteLine($"Кількість: {foundOrder.Quantity}");
            Console.WriteLine($"Ціна: {foundOrder.Price} грн.");
        }
        else
        {
            Console.WriteLine("Замовлення з таким номером не знайдено.");
        }
    }
}