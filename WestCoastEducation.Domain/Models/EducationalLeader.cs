using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class EducationalLeader : Teacher
    {
        public DateTime HiredDate { get; set; }

        public EducationalLeader(string firstName, string lastName, string phoneNumber, int personNumber, Address address, DateTime hiredDate, string knowledgeArea, string responsibleCourse)
        : base(firstName, lastName, phoneNumber, personNumber, address, knowledgeArea, responsibleCourse)
        {
            HiredDate = hiredDate;
        }
        public override string ToString()
        {
            return base.ToString() +
            $"\nAnställningsdatum: {HiredDate.ToShortDateString}";
        }
    }
}