using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Position:Interface<User>
    {
        public Position(string name, List<User> users)
        {
            Name = name.Trim();
            Users = users;
        }
        public string Name { get; set; }
        public List<User> Users { get; set; }

        public void Add(User user)
        {
            Users.Add(user);
        }
        public void Remove(User user)
        {
            throw new NotImplementedException();
        }
    }
}
