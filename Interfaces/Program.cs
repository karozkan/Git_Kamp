using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalManager manager = new PersonalManager;
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Özkan",
                LastName = "Göktaş",
                Address = "Ankara"
            };
            Student student = new Student
            {
                Id = 2,
                FirstName = "Mehmet",
                LastName = "Abacıoğlu",
                Departmant = "Computer Sciences"

            };
            manager.Add(customer);
            manager.Add(student);
            Console.ReadLine();
        }
    }
    interface IPerson       //  Soyut Nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:IPerson  //  Somut Nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

    }
    class Student: IPerson  //  Somut Nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonalManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
