using System;
using System.Collections.Generic;

namespace MyFinances.WebApi.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Operations = new HashSet<Operations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Operations> Operations { get; set; }
    }
}
