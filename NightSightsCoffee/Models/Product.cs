using System;
using System.Collections.Generic;

namespace NightSightsCoffee.Models
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string Coffee { get; set; }
        public string Description { get; set; }
        public string RoastType { get; set; }
        public int? Price { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
    }
}
