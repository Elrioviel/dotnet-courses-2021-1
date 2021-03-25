using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input employee's first name:");
            string employeeName = Console.ReadLine();
            Console.WriteLine("input employee's last name:");
            string employeeLastName = Console.ReadLine();
            Console.WriteLine("input employee's patronymic:");
            string employeePatron = Console.ReadLine();
            Console.WriteLine("input employee's birth date:");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("input your position:");
            string jobsTitle = Console.ReadLine();
            Console.WriteLine("When did you start working?");
            DateTime workingDate;
            while (true)
            {

                if (!DateTime.TryParse(Console.ReadLine(), out workingDate))
                {
                    Console.WriteLine("invalid date!");
                }
                else
                {
                    break;
                }
            }

            Employee employee1 = new Employee(employeeName, employeeLastName, employeePatron, birthDate, jobsTitle, workingDate);
            Console.WriteLine("Employee's full name: {0} {1} {2}, date of birth: {3}, works here for {4} years, and is a {5}",
              employee1.FirstName, employee1.LastName, employee1.Patronymic, employee1.BirthDate, employee1.Experience, employee1.Title);

            Employee employee2 = new Employee("Sarah", "Wilson", "", new DateTime(1989,05,05), "Director", new DateTime (2009,11,12));
            
            if (employee1.Title.Equals(employee2.Title))
            {
                Console.WriteLine("{0} can't be the director! ", employeeName);
            }

        }
    }
}
