using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class Student : PersonalInfo
    {
        public Student(string firstName, string lastName, string phoneNumber, int personNumber, string adress, int zipcode, string city)
        : base(firstName, lastName, phoneNumber, personNumber, adress, zipcode, city)
    {
    }
        public static Student CreateStudent()
        {
            Console.WriteLine("Förnamn: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Efternamn: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Telefonnummer: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Personnummer:(ÅÅÅÅMMDD) ");
            int personNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Adress: ");
            string adress = Console.ReadLine();

            Console.WriteLine("Postnummer: ");
            int zipcode = int.Parse(Console.ReadLine());
            Console.WriteLine("Stad: ");
            string city = Console.ReadLine();



            return new Student(firstName, lastName,phoneNumber, personNumber, adress, zipcode, city);

        }
    }
}