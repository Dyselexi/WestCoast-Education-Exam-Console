using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class Admin : EducationalLeader
    {
        public Admin(string firstName, string lastName, string phoneNumber, int personNumber, Address address, DateTime hiredDate, string knowledgeArea, string responsibleCourse)
        : base(firstName, lastName, phoneNumber, personNumber, address ,hiredDate, knowledgeArea, responsibleCourse)
        {
        }

    }
}