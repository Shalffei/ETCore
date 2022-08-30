using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace ETCore.Servise
{
    public static class LocalDbServise
    {
        public static void AddToDb(ApplicationContext db, UserList userList)
        {
            foreach (var item in userList.DbUsersList)
            {
                db.Users.Add(item);
                db.SaveChanges();
            }
            Console.WriteLine("Object Added");
        }
        public static void RemuveFromDbUser(ApplicationContext db, User user)
        {
            db.Remove(user);
            db.SaveChanges();
            Console.WriteLine("Remuve successfuly");
        }
        public static void ChangesToDbUser(ApplicationContext db, User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
            Console.WriteLine("Changes was saved");
        }

        public static List<User> GetFromDb(ApplicationContext db)
        {
            List<User> result = db.Users.ToList();
            return result;    

        }
    }
}
