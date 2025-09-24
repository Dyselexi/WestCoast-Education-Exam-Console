namespace WestCoastEducation.App;

using System.ComponentModel;
using System.Text.Json.Serialization;
using WestCoastEducation.Domain.Models;

class Program
{
    static void Main(string[] args)
    {
        Student elev = Student.CreateStudent();
        // Teacher lärare = new Teacher("Marie");
        // EducationalLeader administratör = new EducationalLeader("Gittan");
        // Admin adm = new Admin("Chrille");


        Console.WriteLine("Studentinformation: ");
        Console.WriteLine(elev);
        

        // Console.WriteLine(elev);
        // Console.WriteLine("");
        // Console.WriteLine("===========");
        // Console.WriteLine("");
        // Console.WriteLine(lärare);
        // Console.WriteLine("");
        // Console.WriteLine("===========");
        // Console.WriteLine("");
        // Console.WriteLine(administratör);
        // Console.WriteLine("");
        // Console.WriteLine("===========");
        // Console.WriteLine(adm);
        // Console.WriteLine("");
        // Console.WriteLine("===========");


    }
}
