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

        public Teacher() : base() { }


        public Teacher(string firstName, string lastName, string phoneNumber, int personNumber, string adress, int zipcode, string city)
        : base(firstName, lastName, phoneNumber, personNumber, adress, zipcode, city)
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