using Shopping.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Domain.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> Get();
    }
}
