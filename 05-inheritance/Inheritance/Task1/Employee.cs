using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Employee : User
    {
            public string Title;
            private DateTime _startWorking;
            private int _experience;

            public int Experience
            {
                get
                {
                    return _experience;
                }
                set
                {
                    _experience = value;
                }
            }
            
            public DateTime StartWorking
            {
                get
                {
                    return _startWorking;
                }
                set
                {
                    _startWorking = value;
                }
            }

            public Employee(string FirstName, string LastName, string Patronymic, DateTime BirthDate, string Title, DateTime StartWorking) : base(FirstName, LastName, Patronymic, BirthDate)
            {
                this.StartWorking = StartWorking;
                this.Title = Title;
                if ((BirthDate > StartWorking) || (StartWorking > DateTime.Now))
                {
                    throw new ArgumentException("Invalid date(s)!");
                }
                else
                {
                    Experience = (DateTime.Now.Year - StartWorking.Year);
            }

            }
        
    }
}
