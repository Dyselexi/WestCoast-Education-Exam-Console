using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestCoastEducation.Domain.Models
{
    public class Address
    {
        public string? StreetName { get; set; }
        public int ZipCode { get; set; }
        public string? City { get; set; }


        public Address(string streetName, int zipCode, string city)
        {
            StreetName = streetName;
            ZipCode = zipCode;
            City = city;
        }

        public override string ToString()
        {
            return ($"{StreetName}, {ZipCode} - {City}");
        }

    }
}