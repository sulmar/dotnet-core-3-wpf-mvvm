using Bogus;
using Shopping.Domain.Models;
using Shopping.Domain.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Shopping.Inftrastructure
{
    public class FakeCustomerService : ICustomerService
    {
        private readonly ICollection<Customer> customers;

        public FakeCustomerService(Faker<Customer> faker)
        {
            customers = faker.Generate(100);
        }  

        public IEnumerable<Customer> Get()
        {
            return customers;
        }
    }
}
