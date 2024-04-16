using BikeRental;

namespace BikeRental.ViewModels;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System;


public class ShowAllPageViewModel : PageViewModelBase
{
    
    
        

   
    public override bool CanNavigateNext
    
        {
        get => true;
        protected set => throw new NotSupportedException();
        }
    }
