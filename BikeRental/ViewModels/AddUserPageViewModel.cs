using System;
using System.Windows.Input;

namespace BikeRental.ViewModels;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

public partial class AddUserPageViewModel : PageViewModelBase
{
    

    private void Home()
    {
        
    }
   
        public static string? Name { get; set; }
        public static string? Surname { get; set; }
        public static string? Pesel { get; set; }
        public static string? City { get; set; }
        public static string? Street { get; set; }
        
   
       

       

        [RelayCommand]
        private void ButtonOnClick()
        {
        
            if (Name != null && Surname != null && Pesel != null && City != null && Street != null)
            {

                SqlUsage.AddUserToDatabase(Name, Surname, Pesel, City, Street);
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
