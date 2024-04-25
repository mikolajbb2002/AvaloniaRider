using System;
using System.Windows.Input;

namespace BikeRental.ViewModels;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

public partial class SecondPageViewModel : PageViewModelBase
{
    
   
    public static string? FrameSize { get; set; }
    public static string? WheelSize { get; set; }
    public static string? Date { get; set; }
 
        
    

    [RelayCommand]
    private void ButtonOnClick()
    {
        
        if (FrameSize != null && WheelSize != null && Date != null)
        {

            SqlUsage.AddRentalToDatabase(FrameSize, WheelSize, Date);
            Console.WriteLine("Dodano dane do bazy danych ");

        }
        else
        {
            Console.WriteLine("Cos jest nie tak, sprobuj ponownie");
        }
            


    }

        
    public string Title => "Welcome to our Wizard-Sample.";

    /// <summary>
    /// The content of this page
    /// </summary>
    public string Message => "Press \"Next\" to register yourself.";

    public ICommand NavigateNextCommand { get; }
    public override bool CanNavigateNext
    
    {
        get => true;
        protected set => throw new NotSupportedException();
    }
}