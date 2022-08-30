using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCore.Models
{
    public class UserList
    {
        public List<User> DbUsersList { get; set; }
        public UserList (string userName, int countUsers)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < countUsers; i++)
            {
                if (DbUsersList == null)
                {
                    DbUsersList = new List<User>();
                }
                User user = new User { Name = userName + a.ToString(), Age = b };
                DbUsersList.Add(user);
                a++;
                b++;
            }

        }
        public UserList()
        {
        }
    }
}
