using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class ProductItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public int TotalPrice { get; set; }

        public ProductItem(int Id, Product Product, int Count, int TotalPrice)
        {
            this.Id = Id;
            this.Product = Product;
            this.Count = Count;
            this.TotalPrice = TotalPrice;

        }



    }
}
