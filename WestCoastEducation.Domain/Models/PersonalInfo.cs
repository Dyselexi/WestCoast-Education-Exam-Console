using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class PersonalInfo(string firstName,string lastName, string phoneNumber, int personNumber, string adress, int zipCode, string city)
    {
        string FirstName { get; set; } = firstName;
        string LastName { get; set; }= lastName;
        string PhoneNumber { get; set; }= phoneNumber;
        int PersonNummer { get; set; }= personNumber;
        string Adress { get; set; }= adress;
        int ZipCode { get; set; }= zipCode;
        string City { get; set; } = city;
    }
}