using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppActivity
{
    public class FakeOrderRepository : IOrderRepository
    {
        public List<(string Email, decimal Total)> SavedOrders { get; } = new List<(string, decimal)>();

        public void SaveOrder(string email, decimal total)
        {
            SavedOrders.Add((email, total));
        }
    }
}
