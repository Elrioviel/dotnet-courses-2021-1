using System;

namespace Task1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User u1 = new User("06.10.1975", "Jones", "Williamson", "Mike");
                User u2 = new User("16.03.1989", "Davis", "MacDonald", "Joe");
                
                Console.WriteLine("The first user is: {0} {1} {2}, date of birth: {3}", u1.First, u1.Last, u1.Patronym, u1.Birth);
                Console.WriteLine("The second user is: {0} {1}", u2.First, u2.Last);
            }

            catch
            {
                Console.WriteLine("Error occured");
            }
        }
    }
}
