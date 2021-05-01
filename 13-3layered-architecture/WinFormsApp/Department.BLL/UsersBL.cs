using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Department.DAL;
using System.ComponentModel;

namespace Department.BLL
{
    public class UsersBL : IUsersBL
    {
        private readonly IUserDAO usersDAO;
        public static int idUser = 0;
        public UsersBL(IUserDAO userDAO)
        {
            usersDAO = userDAO;
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
        public void Remove(User user)
        {
            usersDAO.Remove(user);
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
        public IEnumerable<User> SortUserByAgeDesc()
        {
            return usersDAO.SortUserByAgeDesc();
        }
        public IEnumerable<User> SortUserByAgeAsc()
        {
            return usersDAO.SortUserByAgeAsc();
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
        public void AddUserAndAward(string firstName, string lastName, DateTime birthDate, List<Awards> awardsToUser)
        {
            User user = new User
            {
                ID = idUser,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                AwardsUser = awardsToUser,
            };
            idUser++;
            this.Add(user);
            
        }
        public IEnumerator<User> GetEnumerator()
        {
            List<User> myList = usersDAO.GetList().ToList();
            for (int i = 0; i < myList.Count; i++)
            {
                yield return myList[i];

            }
        }
    }
}
