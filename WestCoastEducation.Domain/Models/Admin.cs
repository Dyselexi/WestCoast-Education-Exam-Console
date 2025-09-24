using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class Admin : EducationalLeader
    {
        public Admin(string firstName) : base(firstName)
    {
    }

    }
}