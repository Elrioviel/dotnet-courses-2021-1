using System;
using System.Collections.Generic;
using Entities;

namespace Department.DAL
{
    public class UserDAO : IUserDAO
    {
        private List<User> users = new List<User>();

        public void Add(User user)
        {
            if (user == null)
                throw new ArgumentException("user");
            users.Add(user);
        }
        public IEnumerable<User> GetList()
        {
            return users;
        }
    }
    public class UserDAOdb : IUserDAO
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
