using System;
using Entities;
using System.ComponentModel;
using System.Collections.Generic;

namespace Department.DAL
{
    public interface IUserDAO
    {
        void Add(User user);
        void Remove(int ID);
        List<User> GetList();
        List<User> SortUserByAgeAsc();
        List<User> SortUserByAgeDesc();

    }
}
