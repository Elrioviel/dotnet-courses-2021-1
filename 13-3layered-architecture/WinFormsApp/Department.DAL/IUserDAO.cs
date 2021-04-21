using System;
using Entities;
using System.ComponentModel;

namespace Department.DAL
{
    public interface IUserDAO
    {
        void Add(User user);
        System.Collections.Generic.IEnumerable<User> GetList();
       
    }
}
