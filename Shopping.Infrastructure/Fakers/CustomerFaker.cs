using Bogus;
using Shopping.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Inftrastructure.Fakers
{
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker()
        {
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
        }
    }
}
