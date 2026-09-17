using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppActivity
{
    public class OrderItem
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderCalculator
    {
        public decimal CalculateSubtotal(IEnumerable<OrderItem> items)
        {
            decimal subtotal = 0;
            foreach (var item in items)
            {
                subtotal += item.Price * item.Quantity;
            }
            return subtotal;
        }

        public decimal CalculateTotal(IEnumerable<OrderItem> items, IDiscountStrategy discountStrategy)
        {
            decimal subtotal = CalculateSubtotal(items);
            return discountStrategy.Apply(subtotal);
        }
    }
}
