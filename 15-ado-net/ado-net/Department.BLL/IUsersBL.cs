using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Department.DAL;
using System.ComponentModel;

namespace Department.BLL
{
    interface IUsersBL
    {
        IEnumerable<User> GetList();
        void Add(User user);
        void Remove(int ID);
        IEnumerable<User> InitList();
        IEnumerable<User> SortUserByAgeDesc();
        IEnumerable<User> SortUserByAgeAsc();
    }
}
