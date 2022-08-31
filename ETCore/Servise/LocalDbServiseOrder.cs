using ETCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ETCore.Servise
{
    public static class LocalDbServiseOrder
    {
        public static void AddToDbOrder(ApplicationContextOrder db, Order order)
        {

            db.Orders.Add(order);
            db.SaveChanges();

            Console.WriteLine("Object order added");
        }
        public static void RemoveFromDbOrder(ApplicationContextOrder db, Order order)
        {
            db.Remove(order);
            db.SaveChanges();
            Console.WriteLine("Order remuve successfuly");
        }
        public static void ChangesToDbOrder(ApplicationContextOrder db, Order order)
        {
            db.Orders.Update(order);
            db.SaveChanges();
            Console.WriteLine("Order changes was saved");
        }

        public static List<Order> GetFromDbOrders(ApplicationContextOrder db)
        {
            List<Order> result = db.Orders.ToList();
            return result;

        }
    }
}
