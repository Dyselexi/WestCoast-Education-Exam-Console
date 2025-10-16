using WestCoastEducation.Domain.Models;

namespace WestCoastEducation.Domain.Models
{
    public class Student : PersonalInfo
    {

        public Student(string firstName, string lastName, string phoneNumber, int personNumber, Address address)
        :base(firstName, lastName,phoneNumber,personNumber, address)
        
        {
            
        }

        public override string ToString()
        {
            return $"Förnamn: {FirstName}\n" +
                $"Efternamn: {LastName}\n" +
                $"Telefonnummer: {PhoneNumber}\n" +
                $"Personnummer: {PersonNummer}\n" +
                $"Adress: {Address}";
        }

    }
}