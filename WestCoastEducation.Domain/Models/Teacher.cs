using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class Teacher : PersonalInfo
    {
        public string KnowledgeArea { get; set; } ="";
        public List<Course> ResponsibleCourse { get; set; } = new List<Course>();

        public Teacher(string firstName) : base(firstName)
        {
            
        }
        public override string ToString()
        {
            return base.ToString() +
            $"Kunskapsområde: {KnowledgeArea}\n" +
            $"Kursansvarig: {ResponsibleCourse}";

        }


    }
}