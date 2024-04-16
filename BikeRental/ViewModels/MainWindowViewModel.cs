using DynamicData;
using ReactiveUI;
using System.Windows.Input;

namespace BikeRental.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            // Set current page to first on start up
            _CurrentPage = Pages[0];

            // Create Observables which will activate to deactivate our commands based on CurrentPage state
            var canNavNext = this.WhenAnyValue(x => x.CurrentPage.CanNavigateNext);
            

            NavigateNextCommand = ReactiveCommand.Create(NavigateNext);
            
        }

        // A read.only array of possible pages
        private readonly PageViewModelBase[] Pages = 
        {
            new FirstPageViewModel(),
            new AddUserPageViewModel(),
            new SecondPageViewModel(),
            new ShowAllPageViewModel(),
        };

        // The default is the first page
        private PageViewModelBase _CurrentPage;

        /// <summary>
        /// Gets the current page. The property is read-only
        /// </summary>
        public PageViewModelBase CurrentPage
        {
            get { return _CurrentPage; }
            private set { this.RaiseAndSetIfChanged(ref _CurrentPage, value); }
        }

        /// <summary>
        /// Gets a command that navigates to the next page
        /// </summary>
        public ICommand NavigateNextCommand { get; }

        private void NavigateNext()
        {
            // get the current index and add 1
            var index = Pages.IndexOf(CurrentPage) + 1;

            //  /!\ Be aware that we have no check if the index is valid. You may want to add it on your own. /!\
            CurrentPage = Pages[index];
        }
        
        
        
    }
}
