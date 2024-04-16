using System;

namespace BikeRental.ViewModels;

public class FirstPageViewModel : PageViewModelBase
{
    public FirstPageViewModel()
    {
        
    }

    /// <summary>
    /// The Title of this page
    /// </summary>
    public string Title => "Welcome to BikeRental";

    /// <summary>
    /// The content of this page
    /// </summary>
    public string Message => "Press \"Next\" to rent a bike";

    // This is our first page, so we can navigate to the next page in any case
    public override bool CanNavigateNext
    {
        get => true;
        protected set => throw new NotSupportedException();
    }

}




