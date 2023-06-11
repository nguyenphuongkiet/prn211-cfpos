using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountSchedules = new HashSet<AccountSchedule>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Description { get; set; }
        public int? Salary { get; set; }
        public int? HourlyWage { get; set; }
        public int? RoleId { get; set; }
        public bool? Status { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<AccountSchedule> AccountSchedules { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
