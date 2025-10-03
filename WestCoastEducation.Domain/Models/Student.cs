using WestCoastEducation.Domain.Models;




namespace WestCoastEducation.Domain.Models
{
    public class Student : PersonalInfo
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public int PersonNummer { get; set; }
        public string Adress { get; set; } = "";
        public int ZipCode { get; set; }
        public string City { get; set; } = "";

        public Student(string firstName, string lastName, string phoneNumber, int personNumber, string adress, int zipcode, string city)
        :base(firstName, lastName,phoneNumber,personNumber,adress,zipcode,city)
        
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            PersonNummer = personNumber;
            Adress = adress;
            ZipCode = zipcode;
            City = city;
        }

        public static Student CreateStudent()
        {
            Console.WriteLine("Förnamn: ");
            string firstName = Console.ReadLine()!;

            //Kan lägga till (!) efter readline för att bli av med null, tvingar att bli sträng..
            Console.WriteLine("Efternamn: ");
            string lastName = Console.ReadLine()!;

            Console.WriteLine("Telefonnummer: ");
            string phoneNumber = Console.ReadLine()!;

            Console.WriteLine("Personnummer:(ÅÅÅÅMMDD) ");
            int personNumber = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Adress: ");
            string adress = Console.ReadLine()!;

            Console.WriteLine("Postnummer: ");
            int zipcode = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Stad: ");
            string city = Console.ReadLine()!;



            return new Student(firstName, lastName, phoneNumber, personNumber, adress, zipcode, city);

        }
        public override string ToString()
        {
            return $"Förnamn: {FirstName}\n" +
                $"Efternamn: {LastName}\n" +
                $"Telefonnummer: {PhoneNumber}\n" +
                $"Personnummer: {PersonNummer}\n" +
                $"Adress: {Adress}\n" +
                $"Postnummer: {ZipCode}\n" +
                $"Stad: {City}";
        }

    }
}