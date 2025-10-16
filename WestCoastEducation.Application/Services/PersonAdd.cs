
using WestCoastEducation.Application.Interfaces;
using WestCoastEducation.Domain.Models;

namespace WestCoastEducation.Application.Services
{
    public class CreatePersonConsole
    {

        public Student CreatePerson()
        {
            string firstName = ReadString("Förnamn");
            string lastName = ReadString("Efternamn");
            string phoneNumber = ReadString("Telefonnummer");
            int personNumber = ReadInt("Personnummer (ÅÅÅÅMMDD)");
            Address address = CreateAddress();



            return new Student(firstName, lastName, phoneNumber, personNumber, address);
        }

        private string ReadString(string question)
        {
            Console.Write($"{question}: ");
            string? input = Console.ReadLine();
            return string.IsNullOrWhiteSpace(input) ? "Felaktig inmatning" : input;
        }

        private int ReadInt(string question)
        {
            while (true)
            {
                Console.Write($"{question}: ");
                string? input = Console.ReadLine();

                input = input?.Replace(" ", "");
                if (int.TryParse(input, out int resultat))
                return resultat;

                Console.WriteLine("Ogiltig inmatning, försök igen.");
            }
        }
        private Address CreateAddress()
        {
            string street = ReadString("Adress");
            int zipCode = ReadInt("Postnummer");
            string city = ReadString("Stad");

            return new Address(street, zipCode, city);
        }
    

}
}