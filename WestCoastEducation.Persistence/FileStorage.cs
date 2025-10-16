using System.Text.Encodings.Web;
using System.Text.Json;




namespace WestCoastEducation.Persistence
{
    public class FileStorage
    {

        public void WriteJson(string path, string json)
        {

            File.WriteAllText(path, json);

        }

        public  string ReadJsonlist(string path)
        {

            return File.ReadAllText(path);
           

        }
    }
    
}