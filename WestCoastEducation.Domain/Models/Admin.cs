using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class Admin : EducationalLeader
    {
        public Admin(string firstName, string lastName, string phoneNumber, int personNumber, string adress, int zipcode, string city, DateTime hiredDate)
        : base(firstName, lastName, phoneNumber, personNumber, adress, zipcode, city, hiredDate)
        {
        }

    }
}