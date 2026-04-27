using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sample Data

            List<Product> ProductList = new List<Product>
            {
                new Product{ ProductName="Chai", Category="Beverages", UnitPrice=18, UnitsInStock=39 },
                new Product{ ProductName="Chang", Category="Beverages", UnitPrice=19, UnitsInStock=17 },
                new Product{ ProductName="Aniseed Syrup", Category="Condiments", UnitPrice=10, UnitsInStock=13 },
                new Product{ ProductName="Chef Anton", Category="Condiments", UnitPrice=22, UnitsInStock=0 },
                new Product{ ProductName="Ikura", Category="Seafood", UnitPrice=31, UnitsInStock=20 },
                new Product{ ProductName="Konbu", Category="Seafood", UnitPrice=6, UnitsInStock=0 },
                new Product{ ProductName="Cajun Seasoning", Category="Condiments", UnitPrice=22, UnitsInStock=53 }
            };

            List<Order> Orders = new List<Order>
            {
                new Order{ CustomerID="ALFKI", OrderDate=new DateTime(1996,5,1)},
                new Order{ CustomerID="BONAP", OrderDate=new DateTime(1998,7,10)},
                new Order{ CustomerID="CACTU", OrderDate=new DateTime(1997,3,15)}
            };

            #endregion

            #region 1 Seafood Products

            //var seafood = ProductList
            //    .Where(p => p.Category == "Seafood");

            //foreach (var p in seafood)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion

            #region 2 Only Names

            //var names = ProductList.Select(p => p.ProductName);

            //foreach (var n in names)
            //    Console.WriteLine(n);

            #endregion

            #region 3 Sort by Price

            //var sorted = ProductList
            //    .OrderBy(p => p.UnitPrice);

            //foreach (var p in sorted)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion

            #region 4 Price between 10 and 30

            //var range = ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            #endregion

            #region 5 In stock + Condiments

            //var condiments = ProductList
            //    .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            #endregion

            #region 6 Anonymous Type

            //var anon = ProductList
            //    .Select(p => new
            //    {
            //        Name = p.ProductName,
            //        Price = p.UnitPrice,
            //        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //    });

            //foreach (var x in anon)
            //    Console.WriteLine($"{x.Name} - {x.Price} - {x.StockStatus}");

            #endregion

            #region 7 Position (1-based)

            //var withIndex = ProductList
            //    .Select((p, i) => new { Index = i + 1, Name = p.ProductName });

            //foreach (var x in withIndex)
            //    Console.WriteLine($"{x.Index}. {x.Name}");

            #endregion

            #region 8 Sort Category then Price Desc

            var multiSort = ProductList
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.UnitPrice);

            #endregion
        }
    }

    class Product
    {
        public string ProductName;
        public string Category;
        public double UnitPrice;
        public int UnitsInStock;
    }

    class Order
    {
        public string CustomerID;
        public DateTime OrderDate;
    }
}
