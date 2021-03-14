using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        public string birth;
        public string last;
        public string patronym;
        public string first;
        
        public User(string birthDate, string lastName, string patronymic, string firstName)
        {
            this.birth = birthDate;
            this.last = lastName;
            this.patronym = patronymic;
            this.first = firstName;
        }
    }
}
