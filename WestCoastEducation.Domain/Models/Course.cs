
namespace WestCoastEducation.Domain.Models
{
    public class Course
    {
        
        public string Title { get; set; } = "";
        public int LengthWeek { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClassRoom { get; set; }

        
        public Course(string title, int lengthWeek, DateTime startDate, DateTime endDate, bool isClassRoom)
        {
            
            Title = title;
            LengthWeek = lengthWeek;
            StartDate = startDate;
            EndDate = endDate;
            IsClassRoom = isClassRoom;
            
        }

        public Course() { }
        
        public override string ToString()
        {
            return $"{Title}, {LengthWeek} veckor, start: {StartDate:yyyy-MM-dd} slut: {EndDate:yyyy-MM-dd} ({(IsClassRoom ? "Klassrum" : "Distans")})";
        }
    }
}