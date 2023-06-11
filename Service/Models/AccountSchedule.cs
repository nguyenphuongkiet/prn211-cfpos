using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class AccountSchedule
    {
        public int AccountId { get; set; }
        public int ScheduleId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
