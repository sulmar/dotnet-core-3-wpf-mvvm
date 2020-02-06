using System;

namespace Shopping.Domain.Models
{

    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
