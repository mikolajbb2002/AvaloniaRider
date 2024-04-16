namespace BikeRental;

public class UserModel
{
    public  int IDuser { get; set; }
    public  string? Name { get; set; }
    public  string? Surname { get; set; }
    public  string? Pesel { get; set; }
    public  string? City { get; set; }
    public string? Street { get; set; }
  

    public UserModel(int iduser, string? name, string? surname, string? pesel, string? city, string? street)
    {
        IDuser = iduser;
        Name = name;
        Surname = surname;
        Pesel = pesel;
        City = city;
        Street = street;
       


    }
}