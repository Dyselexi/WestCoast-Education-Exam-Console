using WestCoastEducation.Application.Interfaces;
using WestCoastEducation.Domain.Models;


namespace WestCoastEducation.Application.Services
{
    public class CreateCourseConsole : ICourseAdd
    {
        public Course CreateCourse()
        {
            Console.Write("Kursnamn: ");
            string title = Console.ReadLine() ?? "";


            Console.Write("Längd i veckor: ");
            int lengthWeek = int.Parse(Console.ReadLine()!);

            Console.Write("Startdatum (ÅÅÅÅ-MM-DD): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Slutdatum (ÅÅÅÅ-MM-DD): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Klassrum eller distans? (K/D): ");
            bool isClassRoom = Console.ReadLine()!.ToUpper() == "K";

            Console.WriteLine("Kurs skapad!");

            return new Course(title, lengthWeek, startDate, endDate, isClassRoom);
        }

    }

}
