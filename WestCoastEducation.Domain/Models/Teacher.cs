using WestCoastEducation.Domain.Models;




namespace WestCoastEducation.Domain.Models
{
    public class Teacher : PersonalInfo
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public int PersonNummer { get; set; }
        public string Adress { get; set; } = "";
        public int ZipCode { get; set; }
        public string City { get; set; } = "";

        public Teacher(string firstName, string lastName, string phoneNumber, int personNumber, string adress, int zipcode, string city)
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

