using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Data
{
    public class MockUsersStore
    {
        public static List<User> Users = new List<User>
        {
            new User { Id = 1, Name = "Rivka" },
            new User { Id = 2, Name = "Moshe" },
            new User { Id = 3, Name = "Dana" }
        };
    }
}