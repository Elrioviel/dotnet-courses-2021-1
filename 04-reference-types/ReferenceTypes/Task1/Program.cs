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
                
                Console.WriteLine("The first user is: {0} {1} {2}, date of birth: {3}", u1.first, u1.last, u1.patronym, u1.birth);
                Console.WriteLine("The second user is: {0} {1}", u2.first, u2.last);
            }

            catch
            {
                Console.WriteLine("Error occured");
            }
        }
    }
}
