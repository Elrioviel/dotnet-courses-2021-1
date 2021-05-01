using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Entities;

namespace Department.DAL
{
    public class UserDAO : IUserDAO
    {
        private BindingList<User> users = new BindingList<User>();
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
        public void Remove(User user)
        {
            users.Remove(user);
        }
        public IEnumerable<User> SortUserByAgeAsc()
        {
            var sortedList = new BindingList<User>(users.OrderBy(x => x.Age).ToList());
            users = sortedList;

            return users;
        }

        public IEnumerable<User> SortUserByAgeDesc()
        {
            var sortedListDesc = new BindingList<User>(users.OrderByDescending(x => x.Age).ToList());
            users = sortedListDesc;
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
        public void Remove(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> SortUserByAgeAsc()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> SortUserByAgeDesc()
        {
            throw new NotImplementedException();
        }
    }
}
