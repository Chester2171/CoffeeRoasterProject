using System;
using System.Collections.Generic;

namespace NightSightsCoffee.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public string Description { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
