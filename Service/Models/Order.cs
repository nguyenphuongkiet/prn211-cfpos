using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? StatusId { get; set; }
        public int? TableId { get; set; }
        public decimal? TotalMoney { get; set; }
        public DateTime? Date { get; set; }

        public virtual Account Employee { get; set; }
        public virtual Status Status { get; set; }
        public virtual Table Table { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
