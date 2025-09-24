using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class EducationalLeader : Teacher
    {
        public DateTime HiredDate { get; set; }

        public EducationalLeader(string firstName, string lastName, string phoneNumber, int personNumber, string adress, int zipcode, string city, DateTime hiredDate)
        : base(firstName, lastName, phoneNumber, personNumber, adress, zipcode, city)
        {
            HiredDate = hiredDate;
        }
        public override string ToString()
        {
            return 
            base.ToString() +
            $"\nAnställningsdatum: {HiredDate}";
        }
    }
}