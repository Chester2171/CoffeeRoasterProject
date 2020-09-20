using System;
using System.Collections.Generic;

namespace NightSightsCoffee.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Cart = new HashSet<Cart>();
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
