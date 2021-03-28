using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Task2
{
    class Employee : User, IEquatable<Employee>
    {
        public string Title;
        private DateTime _startWorking;
        private int _experience;

        public int Experience
        {
            get
            {
                return (DateTime.Now.Year - StartWorking.Year);
            }
            private set
            {
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
            if (BirthDate.Equals(StartWorking))
            {
                throw new ArgumentException("You can't start working the year you were born!");
            }


        }

        //public override bool Equals(Employee other)
        //{
        //    return Equals(other as Employee);
        //}
        public bool Equals(Employee other)
        {
            if (this == other) return true;
            if (other == null) return false;
            if (FirstName != other.FirstName) return false;
            if (LastName != other.LastName) return false;
            return true;
        }
    }
}
