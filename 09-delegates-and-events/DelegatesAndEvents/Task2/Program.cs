using System.Collections.Generic;
using System;

namespace Task2
{
    class Program
    {
        class Office : HashSet<Person>
        {
        }
        class Person
        {
            public event OfficeEventHandler Came;
            public event EventHandler Leave;
            public readonly string Name;
            private Office office;

            public Person(string name, Office office)
            {
                Name = name;
                this.office = office;
            }
            void Greeting(Person person)
            {

                Console.WriteLine("Hello {0}! - said {1}", person.Name, Name);
            }
            void Parting(Person person)
            {
                Console.WriteLine("Goodbye {0}! - said {1}", person.Name, Name);
            }
            public void ToCome()
            {
                foreach (var person in office)
                {
                    Came += (sender, args) =>
                    {
                        person.Greeting(this);
                    };
                }
                Console.WriteLine("{0} came to work!", Name);
                Came?.Invoke(this, new OfficeEventArgs());
                office.Add(this);

            }
            public void ToLeave()
            {
                office.Remove(this);
                foreach (var person in office)
                {
                    Leave += (sender, args) => { person.Parting(this); };
                }
                Console.WriteLine("{0} left the office!", Name);
                Leave?.Invoke(this, new EventArgs());
            }
        }
        public delegate void OfficeEventHandler(object sender, OfficeEventArgs args);

        static void Main(string[] args)
        {
            Office office = new Office();
            Person Matt = new Person("Matt", office);
            Person John = new Person("John", office);
            Person Robert = new Person("Robert", office);

            Matt.ToCome();
            John.ToCome();
            Matt.ToLeave();
            Matt.ToCome();
            Robert.ToCome();
            John.ToLeave();
            Matt.ToLeave();
            Robert.ToLeave();
        }
    }
}
