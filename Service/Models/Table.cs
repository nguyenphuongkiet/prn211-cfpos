using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Table
    {
        public Table()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? TableId { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
