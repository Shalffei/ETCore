using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCore.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MoneyBalance { get; set; }
        public List<Order> UserOrders { get; set; } = new List<Order>();

    }
}
