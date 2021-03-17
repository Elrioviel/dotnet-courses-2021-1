using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        public string Birth;
        public string Last;
        public string Patronym;
        public string First;
        
        public User(string BirthDate, string LastName, string Patronymic, string FirstName)
        {
            this.Birth = BirthDate;
            this.Last = LastName;
            this.Patronym = Patronymic;
            this.First = FirstName;
        }
    }
}
