namespace WestCoastEducation.App;
using WestCoastEducation.Domain.Models;

class Program
{
    static void Main(string[] args)
    {
        Students elev = new Students ("Johan");
        Teacher lärare = new Teacher ("Marie");
        
        
        Console.WriteLine(elev);
        Console.WriteLine("===========");
        Console.WriteLine(lärare);
    }
}
