using System;
using System.Windows.Input;
using ReactiveUI;

namespace BikeRental.ViewModels;

public class SecondPageViewModel : PageViewModelBase
{
    
    public SecondPageViewModel()
    {
       

        
    }

    public ICommand Submit_Clickedd { get; }
    public string TxtName { get; set; }

    /// <summary>
    /// The Title of this page
    /// </summary>
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
    






