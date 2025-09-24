using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class EducationalLeader : Teacher
    {
        public DateTime HiredDate { get; set; }

        public EducationalLeader(string firstName) : base(firstName)
        {
            
        }
        public override string ToString()
        {
            return 
            base.ToString() +
            $"\nAnställningsdatum: {HiredDate}";
        }
    }
}