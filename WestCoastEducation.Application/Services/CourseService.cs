using System.Text.Json;
using WestCoastEducation.Domain.Models;
using WestCoastEducation.Persistence;
using System.Text.Encodings.Web;


namespace WestCoastEducation.Application.Services
{
    public class CourseService
    {
        public List<Course> Courses { get; set; } = new();

        private static JsonSerializerOptions _options = new()
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        private readonly string _path;

        private readonly FileStorage fileStorage = new();

        public CourseService(string path)
        {
            _path = path;
        }

        public List<Course> FetchCourses()
        {
            var json = fileStorage.ReadJsonlist(_path);
            var courses = JsonSerializer.Deserialize<List<Course>>(json, _options);
            return courses ?? [];

        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
            var json = JsonSerializer.Serialize(Courses, _options);
            fileStorage.WriteJson(_path, json);
        }

    }
}