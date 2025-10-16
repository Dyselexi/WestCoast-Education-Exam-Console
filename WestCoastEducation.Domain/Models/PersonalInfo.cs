using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public abstract class PersonalInfo(string firstName,string lastName, string phoneNumber, int personNumber, Address address)
    {
        protected string FirstName { get; set; } = firstName;
        protected string LastName { get; set; }= lastName;
        protected string PhoneNumber { get; set; }= phoneNumber;
        protected int PersonNummer { get; set; }= personNumber;
        protected Address? Address { get; set; } = address;
    }
}