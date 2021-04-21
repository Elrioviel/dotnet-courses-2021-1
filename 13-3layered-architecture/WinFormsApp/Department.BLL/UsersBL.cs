using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Department.DAL;

namespace Department.BLL
{
    public class UsersBL
    {
        private readonly IUserDAO usersDAO;
        public static int idUser = 0;
        public UsersBL()
        {
            usersDAO = new UserDAO();
        }
        public IEnumerable<User> GetList()
        {
            return usersDAO.GetList();
        }
        public void Add(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("user");
            }
            usersDAO.Add(user);
        }
        public IEnumerable<User> InitList()
        {
            Add(new User()
            {
                ID = idUser,
                FirstName = "David",
                LastName = "Bowie",
                BirthDate = new DateTime(1973, 05, 08)
            }) ;
            idUser++;
            return GetList();
        }
        public IEnumerable<User> SortUserByAgeAsc()
        {
            return (from u in GetList()
                    orderby u.Age ascending
                    select u);
        }
        public IEnumerable<User> SortUserByAgeDesc()
        {
            return (from u in GetList()
                    orderby u.Age descending
                    select u);
        }
        public void Add(string firstName, string lastName, DateTime birthDate)
        {
            User user = new User
            {
                ID = idUser,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
            };
            idUser++;
            this.Add(user);
        }
    }
}
