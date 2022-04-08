using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Order
    {
        public int Id { get; set; }
        public int OrderPrice { get; set; }
        public List<ProductItem> products;

        public Order(int Id, int OrderPrice, List<ProductItem> products)
        {
            this.Id = Id;
            this.OrderPrice = OrderPrice;
            this.products = products;

        }

    }
}
