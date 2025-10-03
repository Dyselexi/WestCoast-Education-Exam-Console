
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using WestCoastEducation.Domain.Models;





namespace WestCoastEducation.Persistence
{
    public class FileStorage
    {

        private static JsonSerializerOptions _options = new()
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public static void WriteCourses(string path, List<Course> courses)
        {
            var json = JsonSerializer.Serialize(courses, _options);
            File.WriteAllText(path, json);
        }

       public static List<Course> ReadCourses(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Course>();
            }

            var json = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<Course>();
            }

            try
            {
                return JsonSerializer.Deserialize<List<Course>>(json, _options) ?? new List<Course>();
            }
            catch (JsonException)
            {
                return new List<Course>();
            }
        }




    }
}