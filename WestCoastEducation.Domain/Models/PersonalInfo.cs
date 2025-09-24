using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class PersonalInfo
    {
        public string FirstName { get; set; } ="";
        public string LastName { get; set; } ="";
        public int PhoneNumber { get; set; }
        public int PersonNummer { get; set; }
        public string Adress { get; set; } = "";
        public int ZipCode { get; set; } 
        public string City { get; set; } = "";


        public PersonalInfo() { }

        public PersonalInfo(string firstName)
        {
            FirstName = firstName;
        }

        public override string ToString()
        {
            return $"Förnamn: {FirstName}\n" +
            $"Efternamn: {LastName}\n" +
            $"Telefonnummer: {PhoneNumber}\n" +
            $"Personnummer: {PersonNummer}\n" +
            $"Adress: {Adress}\n" +
            $"Postnummer: {ZipCode}\n" +
            $"Stad: {City}\n";
            
        }
    }
}