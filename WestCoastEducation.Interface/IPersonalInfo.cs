namespace WestCoastEducation.Interface;

public class IPersonalInfo
{
    string firstName { get; set; }
    string LastName { get; set; }
    string PhoneNumber { get; set; }
    int PersonNummer { get; set; }
    string Adress { get; set; }
    int ZipCode { get; set; }
    string City { get; set; }

    string ToString();

}
