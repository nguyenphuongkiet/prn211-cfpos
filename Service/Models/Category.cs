using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
