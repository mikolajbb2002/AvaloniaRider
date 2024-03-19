using System;

namespace BikeRental.ViewModels;

public class SecondPageViewModel : PageViewModelBase
{
    /// <summary>
    /// The Title of this page
    /// </summary>
    public string Title => "Welcome to our Wizard-Sample.";

    /// <summary>
    /// The content of this page
    /// </summary>
    public string Message => "Press \"Next\" to register yourself.";

    // This is our first page, so we can navigate to the next page in any case
    public override bool CanNavigateNext
    {
        get => false;
        protected set => throw new NotSupportedException();
    }
    
}



