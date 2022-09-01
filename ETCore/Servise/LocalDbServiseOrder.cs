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
        public static void AddToTrashOrders(ApplicationContext db, List<Order> order, int userId)
        {
            foreach (var item in order)
            {
                item.UserId = userId;
            }

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
        public static void BuyOrders(ApplicationContext db, int userId, List<int> ordersId)
        {
            List<Order> orders = db.Orders.Where(x=> x.UserId == userId).ToList();
            User user = db.Users.Where(x => x.Id == userId).Single();
            decimal totalOrdersPrice = 0;
            foreach (var item in orders)
            {
               totalOrdersPrice = orders.Sum(x => x.Price);
            }
            if (totalOrdersPrice <= user.MoneyBalance)
            {
                user.MoneyBalance -= totalOrdersPrice;
                db.Users.Update(user);
                foreach (var item in orders)
                {
                    item.IsPaid = true;
                }
                db.SaveChanges();
                Console.WriteLine("Order successfully purchased");
            }
            else
            {
                Console.WriteLine("You don't have enough money");
            }
        }
        public static void RemoveOrderFromTrash (ApplicationContext db, int userId, List<int> ordersId)
        {
            List<Order> orders = db.Orders.Where(x => x.UserId == userId).ToList();

            for (int i = 0; i < orders.Count; i++)
            {
                for (int j = 0; j < ordersId.Count; j++)
                {
                    if (orders[i].Id == ordersId[j] && orders[i].IsPaid != true)
                    {
                        db.Orders.Remove(orders[i]);
                        db.SaveChanges();
                    }
                    else
                        continue;
                }
            }
        }
    }
}
