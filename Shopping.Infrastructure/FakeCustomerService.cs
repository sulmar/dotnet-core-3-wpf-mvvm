using Bogus;
using Microsoft.Extensions.Options;
using Shopping.Domain.Models;
using Shopping.Domain.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Shopping.Inftrastructure
{
    public class FakeCustomerServiceOptions
    {
        public int Count { get; set; }
    }

    public class FakeCustomerService : ICustomerService
    {
        private readonly ICollection<Customer> customers;   

        public FakeCustomerService(Faker<Customer> faker, IOptions<FakeCustomerServiceOptions> options)
        {
            customers = faker.Generate(options.Value.Count);
        }  

        public IEnumerable<Customer> Get()
        {
            return customers;
        }
    }
}
