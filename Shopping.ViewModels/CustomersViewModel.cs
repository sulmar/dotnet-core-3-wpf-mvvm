
using Shopping.Domain.Models;
using Shopping.Domain.Services;
using System.Collections.Generic;

namespace ViewModels
{

    public class CustomersViewModel : BaseViewModel
    {
        private readonly ICustomerService customerService;

        public IEnumerable<Customer> Customers { get; set; }

        public CustomersViewModel(ICustomerService customerService)
        {
            this.customerService = customerService;

            Load();
        }

        public void Load()
        {
            Customers = customerService.Get();
        }
    }
}
