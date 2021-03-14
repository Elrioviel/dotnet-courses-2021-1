using System;

namespace Task1
{
    class Program
    {
        class User
        {
            public string firstName;
            public string lastName;
            public string patronymic;
            public string birthDate;
            public User(string firstName, string lastName, string patronymic, string birthDate)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.patronymic = patronymic;
                this.birthDate = birthDate;
            }
        }
        class Employee : User
        {
                public int experience;
                public string title;
            public Employee(string firstName, string lastName, string patronymic, string birthDate, int experience, string title) : base(firstName,lastName,patronymic,birthDate)
            {
                this.experience = experience;
                this.title = title;
            }
        }
            static void Main(string[] args)
        {
            Employee employee1 = new Employee("Chantal", "Heydens", "de Robert", "26.02.1989", 3, "executive director");
            Console.WriteLine("Employee's full name: {0} {1} {2}, date of birth: {3}, works here for {4} years, and is a {5}", 
                employee1.firstName, employee1.lastName,employee1.patronymic,employee1.birthDate,employee1.experience,employee1.title);
        }
    }
}
