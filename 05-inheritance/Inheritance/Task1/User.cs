using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        public string FirstName;
        public string LastName;
        public string Patronymic;
        public DateTime BirthDate;
        public User(string FirstName, string LastName, string Patronymic, DateTime BirthDate)
        {
            if (BirthDate > DateTime.Now)
            {
                throw new ArgumentException("Invalid Birthday date!");
            }
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Patronymic = Patronymic;
            this.BirthDate = BirthDate;
        }
    }
}
