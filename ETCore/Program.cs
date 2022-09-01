using ETCore.Models;
using Microsoft.EntityFrameworkCore;
using ETCore.Servise;

using (ApplicationContext db = new ApplicationContext())
{
    User user = new User { Name = "Tim", MoneyBalance = 1000.28m };
    User user1 = new User { Name = "Bob", MoneyBalance = 135.28m };
    User user2 = new User { Name = "Filip", MoneyBalance = 1420.28m };
    User user3 = new User { Name = "Tomas", MoneyBalance = 880.28m };
    List<User> users = new List<User> { user, user1, user2, user3};
    LocalDbServiseUser.AddToDbUser(db, users);
    Order order = new Order { Name = "Shoes", Price = 100m };
    Order order1 = new Order { Name = "T-Short", Price = 50m }; 
    Order order2 = new Order { Name = "Socks", Price = 20m };
    Order order3 = new Order { Name = "Sweater", Price = 80m };
    Order order4 = new Order { Name = "Blouse", Price = 75m };
    List<Order> orders = new List<Order> {order, order1, order2, order3, order4};
    LocalDbServiseOrder.AddToTrashOrders(db, orders, 2);
    List<int> ordersId = orders.Select(x => x.Id).ToList();
    LocalDbServiseOrder.BuyOrders(db, 2, ordersId);
    List<int> removeOrderId = new List<int> { 1, 3, 5 };
    LocalDbServiseOrder.RemoveOrderFromTrash(db, 2, removeOrderId);
    List<int> newOrderId = new List<int> { 2, 4 };
    LocalDbServiseOrder.BuyOrders(db, 2, ordersId);

}
Console.ReadKey();



