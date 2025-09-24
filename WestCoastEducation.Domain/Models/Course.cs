using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class Course
    {
        public int CourseNumber { get; set; }
        public string Title { get; set; } = "";
        public int LengthWeek { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClassRoom { get; set; }

        public Teacher ResponsibleTeacher { get; set; }
        public List<Student> Studenter { get; set; } = new List<Student>();        
        public override string ToString()
        {
            return $"{CourseNumber}: {Title},{LengthWeek} veckor, {StartDate.ToShortDateString()}-{EndDate.ToShortDateString()} ({(IsClassRoom ? "Distans" : "Klassrum")})";
        }

        
    }
}