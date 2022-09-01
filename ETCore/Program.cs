using ETCore.Models;
using Microsoft.EntityFrameworkCore;
using ETCore.Servise;

using (ApplicationContext db = new ApplicationContext())
{
    User user = new User { Name = "Tim", MoneyBalanse = 1000.28m };
    User user1 = new User { Name = "Bob", MoneyBalanse = 135.28m };
    User user2 = new User { Name = "Filip", MoneyBalanse = 1420.28m };
    User user3 = new User { Name = "Tomas", MoneyBalanse = 880.28m };
    List<User> users = new List<User> { user, user1, user2, user3};
    LocalDbServiseUser.AddToDbUser(db, users);
    Order order = new Order { Name = "Shoes", User = user };
    Order order1 = new Order { Name = "T-Short", User = user };
    Order order2 = new Order { Name = "Socks", User = user };
    Order order3 = new Order { Name = "Sweater", User = user };
    Order order4 = new Order { Name = "Blouse", User = user };
    Order order5 = new Order { Name = "Shoes", User = user1 };
    Order order6 = new Order { Name = "T-Short", User = user1 };
    Order order7 = new Order { Name = "Socks", User = user1 };
    Order order8 = new Order { Name = "Shoes", User = user1 };
    Order order9 = new Order { Name = "T-Short", User = user2 };
    Order order10 = new Order { Name = "Socks", User = user2 };
    Order order11 = new Order { Name = "Blouse", User = user2 };
    Order order12 = new Order { Name = "Sweater", User = user2 };
    Order order13 = new Order { Name = "Blouse", User = user3 };
    Order order14 = new Order { Name = "Sweater", User = user3 };
    Order order15 = new Order { Name = "Blouse", User = user3 };
    List<Order> orders = new List<Order> { order1, order2, order3, order4, order5, order6, order7, order8, order9, order10, order11, order12, order13, order14, order15 };
    LocalDbServiseOrder.AddToDbOrder(db, orders);
    LocalDbServiseOrder.GetUserOrders(db, 2);
    Console.b
}
Console.ReadKey();



