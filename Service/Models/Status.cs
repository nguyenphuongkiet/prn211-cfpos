using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Status1 { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
