using ETCore.Models;
using Microsoft.EntityFrameworkCore;
using ETCore.Servise;

User user = new User { Age = 31, Name = "Bob", Id = 45 };

using (ApplicationContext db = new ApplicationContext())
{
    LocalDbServise.RemuveFromDbUser(db, user);
    Console.ReadKey();
}



