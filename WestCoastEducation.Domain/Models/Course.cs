using System;
using System.Collections.Generic;

namespace WestCoastEducation.Domain.Models
{
    public class Course
    {
        
        public string Title { get; set; } = "";
        public int LengthWeek { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClassRoom { get; set; }

        public Teacher? ResponsibleTeacher { get; set; }
        public List<Student> Studenter { get; set; } = new List<Student>();

        
        public Course(string title, int lengthWeek, DateTime startDate, DateTime endDate, bool isClassRoom, Teacher? responsibleTeacher, List<Student> studenter)
        {
            
            Title = title;
            LengthWeek = lengthWeek;
            StartDate = startDate;
            EndDate = endDate;
            IsClassRoom = isClassRoom;
            ResponsibleTeacher = responsibleTeacher;
            Studenter = studenter;
        }

        
        public static Course CreateCourse()
        {
            

            Console.Write("Kursnamn: ");
            string title = Console.ReadLine() ?? "";

            Console.Write("Ansvarig lärare: ");
            string teacherName = Console.ReadLine() ?? "Okänd";
            Teacher responsibleTeacher = new Teacher { FirstName = teacherName };

            Console.Write("Längd i veckor: ");
            int lengthWeek = int.Parse(Console.ReadLine()!);

            Console.Write("Startdatum (ÅÅÅÅ-MM-DD): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Slutdatum (ÅÅÅÅ-MM-DD): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Klassrum eller distans? (K/D): ");
            bool isClassRoom = Console.ReadLine()!.ToUpper() == "K";

            List<Student> studenter = new List<Student>();
            Console.WriteLine("Kurs skapad!");

            return new Course(title, lengthWeek, startDate, endDate, isClassRoom, responsibleTeacher, studenter);
        }

        
        public override string ToString()
        {
            return $"{Title}, {LengthWeek} veckor, start: {StartDate:yyyy-MM-dd} slut: {EndDate:yyyy-MM-dd} ({(IsClassRoom ? "Klassrum" : "Distans")})";
        }
    }
}