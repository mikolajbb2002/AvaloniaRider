namespace BikeRental;

public class UserModel
{
    public  int IDuser { get; set; }
    public  string? Name { get; set; }
    public  string? Surname { get; set; }
    public  string? Pesel { get; set; }
    public  string? City { get; set; }
    public string? Street { get; set; }
    
    public  int ID_rental { get; set; }
    public  string? FrameSize { get; set; }
    public  string? WheelSize { get; set; }
    public string? Date { get; set; }

  

    public UserModel(int iduser, string? name, string? surname, string? pesel, string? city, string? street, int idRental, string? frameSize, string? wheelSize, string? date )
    {
        IDuser = iduser;
        Name = name;
        Surname = surname;
        Pesel = pesel;
        City = city;
        Street = street;
        ID_rental = idRental;
        FrameSize = frameSize;
        WheelSize = wheelSize;
        Date = date;



    }
}