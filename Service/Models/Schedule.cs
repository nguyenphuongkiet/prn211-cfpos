using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            AccountSchedules = new HashSet<AccountSchedule>();
        }

        public int Id { get; set; }
        public int? TimeStart { get; set; }
        public int? TimeEnd { get; set; }
        public string Date { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<AccountSchedule> AccountSchedules { get; set; }
    }
}
