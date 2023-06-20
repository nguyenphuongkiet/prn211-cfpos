using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
