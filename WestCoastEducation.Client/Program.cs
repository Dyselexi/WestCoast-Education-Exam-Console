
using System.ComponentModel;
using System.Text.Json.Serialization;
using WestCoastEducation.Domain.Models;
using WestCoastEducation.Application.Services;
using WestCoastEducation.Persistence;
using WestCoastEducation.Application.Interfaces;

namespace WestCoastEducation.Client;

class Program
{
    static void Main(string[] args)
    {
        string path = $"{Environment.CurrentDirectory}/data/courseInfo.json";
        ICourseAdd courseAdd = new CreateCourseConsole();

        var personAdd = new CreatePersonConsole();
        var CourseService = new CourseService(path);
        var courses = CourseService.FetchCourses();
        
        List<Student> students = new List<Student>();

        while (true)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Välkommen till WestCoast Education!");
            Console.WriteLine("I nedan ser du olika menyval för att skapa en student, kurs, lärare eller administratör.");
            Console.WriteLine("Tryck 1. För att skapa en student");
            Console.WriteLine("Tryck 2. För att skapa en kurs");
            Console.WriteLine("Tryck 3. För att skapa en lärare");
            Console.WriteLine("Tryck 4. För att skapa en administratör");
            Console.WriteLine("Tryck 5. för att kunna lista alla studenter");
            Console.WriteLine("Tryck 6. för att kunna lista alla kurser");
            Console.WriteLine("Tryck på 'x' för att avsluta programmet");
            Console.WriteLine(new string('=', 80));
            Console.ResetColor();

            string keyPress = Console.ReadLine()!;


            if (keyPress == "x")
            {
                Console.WriteLine("Tack för att du använde WestCoast Educations kurs- och studenthanteringssystem!");
                Environment.Exit(0);
            }
            else if (keyPress == "1")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Student elev = personAdd.CreatePerson();
                students.Add(elev);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('=', 80));
                Console.WriteLine("Student skapad!");
                Console.WriteLine(new string('=', 80));
                Console.ResetColor();

            }
            else if (keyPress == "2")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Course kurs = courseAdd.CreateCourse();
                CourseService.AddCourse(kurs);
                // courses.Add(kurs);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('=', 80));
                Console.WriteLine("Kurs skapad!");
                Console.WriteLine(new string('=', 80));
                Console.ResetColor();

            }
            // else if (keyPress == "3")
            // {
            //     Teacher lärare = Teacher.CreateTeacher();
            //     Console.WriteLine("Lärarinformation: ");
            //     Console.WriteLine(lärare);
            // }
            // else if (keyPress == "4")
            // {
            //     Admin administratör = Admin.CreateAdmin();
            //     Console.WriteLine("Administratörinformation: ");
            //     Console.WriteLine(administratör);
            // }
            else if (keyPress == "5")
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lista på alla studenter: ");
                foreach (var student in students)
                {
                    Console.WriteLine(student.ToString());
                    Console.WriteLine("");
                }
                Console.ResetColor();
            }
            else if (keyPress == "6")
            {

                Console.WriteLine("Lista på alla kurser: ");
                foreach (var course in courses)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(course);
                    Console.WriteLine("");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Felaktigt val, försök igen. observera att endast knappval 1,2,5 och 6 är funktionsdugliga.");
            }
        }






    }
}
