namespace BikeRental;

public class RentalModel
{
    public  int ID_rental { get; set; }
    public  string? FrameSize { get; set; }
    public  string? WheelSize { get; set; }
    public string? Date { get; set; }
    
   
    
    public RentalModel( int idRental, string? frameSize, string? wheelSize, string? date )
    {
      
        ID_rental = idRental;
        FrameSize = frameSize;
        WheelSize = wheelSize;
        Date = date;



    }
}