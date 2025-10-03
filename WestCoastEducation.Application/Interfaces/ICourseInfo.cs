using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WestCoastEducation.Domain.Models;


namespace WestCoastEducation.Application.Interfaces
{
    public interface ICourseInfo
    {
        public Course? courses { get; set; }
        

        
    }
}