using System;

namespace Task1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User u1 = new User();
                u1.Birth = "06.10.1975";
                u1.FirstName = "Mike";
                u1.LastName = "Jones";
                u1.Patronymic = "Williamson";
                User u2 = new User();
                u2.Birth = "16.03.1989";
                u2.FirstName = "Jone";
                u2.LastName = "Davis";
                u2.Patronymic = "MacDonald";

                Console.WriteLine("The first user is: {0} {1} {2}, date of birth: {3}", u1.FirstName, u1.LastName, u1.Patronymic, u1.Birth);
                Console.WriteLine("The second user is: {0} {1}", u2.FirstName, u2.LastName);
            }

            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
        }
    }
}
