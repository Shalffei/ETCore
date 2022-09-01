using ETCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCore.Servise
{
    public static class LocalDbServiseOrder
    {
        public static void AddToDbOrder(ApplicationContext db, Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            Console.WriteLine("Object Added");
        }
        public static void AddToDbOrder(ApplicationContext db, List<Order> order)
        {
            foreach (var item in order)
            {
                db.Orders.Add(item);
                db.SaveChanges();

            }
            Console.WriteLine("Object Added");
        }
        public static void RemoveFromDbOrder(ApplicationContext db, Order order)
        {
            db.Remove(order);
            db.SaveChanges();
            Console.WriteLine("Remuve successfuly");
        }
        public static void ChangesToDbOrder(ApplicationContext db, Order order)
        {
            db.Orders.Update(order);
            db.SaveChanges();
            Console.WriteLine("Changes was saved");
        }
        public static List<Order> GetFromDbOrderList(ApplicationContext db)
        {
            List<Order> result = db.Orders.ToList();
            return result;
        }
        public static List<Order> GetUserOrders(ApplicationContext db, int UserId)
        {
            var result = db.Orders.Include(x => x.User).Where(x => x.UserId == 1).OrderBy(x => x.Price).ToList();
            int count = 0;
            foreach (var item in result)
            {
                if (count == 0)
                {
                    Console.WriteLine($"User {item.User.Name} have orders:");

                }
                count++;
                Console.WriteLine($"{count}. {item.Name} \t Price: {item.Price} \t OrerID: {item.Id} ");
            }
            return result;
        }
    }
}
