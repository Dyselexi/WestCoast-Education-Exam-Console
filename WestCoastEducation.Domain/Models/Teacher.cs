using WestCoastEducation.Domain.Models;




namespace WestCoastEducation.Domain.Models
{
    public class Teacher : PersonalInfo
    {

        public string KnowledgeArea { get; set; } = "";
        public string ResponsibleCourse { get; set; } = "";
        public Teacher(string firstName, string lastName, string phoneNumber, int personNumber, Address address, string knowledgeArea, string responsibleCourse)
        :base(firstName, lastName,phoneNumber,personNumber,address)
        {
            
        }

        public override string ToString()
        {
            return $"Förnamn: {FirstName}\n" +
                $"Efternamn: {LastName}\n" +
                $"Telefonnummer: {PhoneNumber}\n" +
                $"Personnummer: {PersonNummer}\n" +
                $"Adress: {Address}" +
                $"Kunskapsområde: {KnowledgeArea}" +
                $"Kursansvarig: {ResponsibleCourse}";
                
        }
    }
}

