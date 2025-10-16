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


            DateTime startDate = ReadDate("Startdatum: ");
            
            //jag förstår att det finns risker med nedan metod, men tänkte de var kul med variation och ville testa om man kunde skippa ett steg när
            //registrera en kurs..
            DateTime endDate = startDate.AddDays(lengthWeek * 7);

            Console.Write("Klassrum eller distans? (K/D): ");
            bool isClassRoom = Console.ReadLine()!.ToUpper() == "K";

            Console.WriteLine("Kurs skapad!");

            return new Course(title, lengthWeek, startDate, endDate, isClassRoom);
        }

        private DateTime ReadDate(string Date)
        {
            while (true)
            {
                Console.Write($"{Date} (ÅÅÅÅ-MM-DD): ");
                string? input = Console.ReadLine();

                if (DateTime.TryParse(input, out DateTime date))
                {
                    return date;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ogiltigt datumformat. Försök igen.");
                Console.ResetColor();
            }
        }

            
        }

    }


