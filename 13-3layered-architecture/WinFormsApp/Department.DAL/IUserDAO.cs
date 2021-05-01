using System;
using Entities;
using System.ComponentModel;

namespace Department.DAL
{
    public interface IUserDAO
    {
        void Add(User user);
        void Remove(User user);
        System.Collections.Generic.IEnumerable<User> GetList();
        System.Collections.Generic.IEnumerable<User> SortUserByAgeAsc();
        System.Collections.Generic.IEnumerable<User> SortUserByAgeDesc();

    }
}
