using System;
using System.Windows.Input;
using ReactiveUI;

namespace BikeRental.ViewModels;

public class SecondPageViewModel : PageViewModelBase
{
    public SecondPageViewModel()
    {
        //ShowDialog = new Interaction<MainWindowViewModel, DataFormViewModel?>();

        Submit_Clickedd = ReactiveCommand.CreateFromTask(async () =>
        {
            
            //var store = new MainWindowViewModel();
            Console.WriteLine("Otwieranie neego okna poprzez cnacisniecie ");
            Console.WriteLine("to jest wpisane w okienku" + TxtName);

            // var result = await ShowDialog.Handle(store);
        });
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

    // This is our first page, so we can navigate to the next page in any case
    public override bool CanNavigateNext
    {
        get => false;
        protected set => throw new NotSupportedException();
    }
}
    






