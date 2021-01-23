using System;

namespace Constructor //Constructors (Yapıcı Metodlar). görevi oluşturulan nesneyi ilk kullanıma hazırlamasıdır.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(){Id=1,FirstName="Özkan",LastName="Göktaş", City="Ankara";
            
            Customer customer2 = new Customer(2, "Mehmet", "Abacıoğlu", "Ankara");
        }
    }
    class Customer
    {
        public Customer() //defoult constracter
        {
        Console.WriteLine("Yapıcı Blok Çalıştı");
        }
        public Customer(int id, string firstName, string lastName, string city ) //ctor TabTab
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; } //prop TabTab
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
