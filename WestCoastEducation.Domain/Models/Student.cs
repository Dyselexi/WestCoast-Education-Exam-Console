using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class Student : PersonalInfo
    {
        public Student(string firstName) : base(firstName) { }
    }
}