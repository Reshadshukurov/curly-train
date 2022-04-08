using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            Directory.CreateDirectory(@"C:\Users\user\Desktop\Files");
            File.Create(@"C:\Users\user\Desktop\Files\fayl.json");

            Product prod = new Product(1,"Apple",3);
            Product prod2 = new Product(2, "Water",1);
            Product prod3 = new Product(3, "Bread",2);
            Console.WriteLine(prod.ToString());

            ProductItem proditem = new ProductItem(1, prod,2,6);
            ProductItem proditem2 = new ProductItem(2, prod2, 3, 3);
            ProductItem proditem3 = new ProductItem(3, prod3, 2, 4);

            List<ProductItem> item1 = new List<ProductItem>();
            item1.Add(proditem);
            item1.Add(proditem2);
            List<ProductItem> item2 = new List<ProductItem>();
            item2.Add(proditem2);
            item2.Add(proditem3);
            int result1 = 0;
            foreach (var item in item1)
            {
                result1 += item.TotalPrice;
            }
            int result2 = 0;
            foreach (var item in item2)
            {
                result2 += item.TotalPrice;
            }

            Order o1 = new Order(1,result1,item1);
            Order o2 = new Order(1, result2, item2);

            List<Order> orders = new List<Order>();
            orders.Add(o1);
            orders.Add(o2);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\user\source\repos\ConsoleApp15\ConsoleApp15\json1.json"))
            {
                sw.Write(orders);
            }
            JsonConvert.
        }
    }
}
