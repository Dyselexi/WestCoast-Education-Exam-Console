using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class WestCoast
    {
        public string FirstName { get; set; } ="";
        public string LastName { get; set; } ="";
        public int PhoneNumber { get; set; }
        public int PersonNummer { get; set; }
        public string Adress { get; set; } = "";
        public int ZipCode { get; set; } 
        public string City { get; set; } = "";
        public int CourseNumber { get; set; }
        public string Title { get; set; } = "";
        public int LengthWeek { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string KnowledgeArea { get; set; } ="";
        public DateTime HiredDate { get; set; }
        public string ResponsibleCourse { get; set; }="";
        public bool IsClassRoom { get; set; }
        
    }
}