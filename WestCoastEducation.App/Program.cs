namespace WestCoastEducation.App;

using System.ComponentModel;
using WestCoastEducation.Domain.Models;

class Program
{
    static void Main(string[] args)
    {
        Student elev = new Student("Johan");
        Teacher lärare = new Teacher("Marie");
        EducationalLeader administratör = new EducationalLeader("Gittan");
        Admin adm = new Admin("Chrille");

        Console.WriteLine(elev);
        Console.WriteLine("");
        Console.WriteLine("===========");
        Console.WriteLine("");
        Console.WriteLine(lärare);
        Console.WriteLine("");
        Console.WriteLine("===========");
        Console.WriteLine("");
        Console.WriteLine(administratör);
        Console.WriteLine("");
        Console.WriteLine("===========");
        Console.WriteLine(adm);
        Console.WriteLine("");
        Console.WriteLine("===========");

        
    }
}
