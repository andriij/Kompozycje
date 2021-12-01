using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Display(Person person)
        {
            Console.WriteLine($"First name: {person.FirstName}");
            Console.WriteLine($"Last name: {person.LastName}");
        }

        static void Main(string[] args)
        {

            Address address = new Address()
            {
                City = "Krakow",
                PostalCode = "31-556",
                Street = "Grodzka 5"
            };

            Person person = new Person()
            {
                FirstName = "John",
                LastName = "Doe",
                Address = address
            };

            Display(person);
        }
    }
}
