using Shopping.ViewModels;
using System.IO;
using System.Windows.Input;

namespace ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private readonly INavigationService navigationService;

        public ICommand ShowCustomersCommand { get; private set; }

        public ShellViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            ShowCustomersCommand = new RelayCommand(ShowCustomers);
        }

        public void ShowCustomers()
        {
            navigationService.Navigate("Customers");
        }
    }
}
