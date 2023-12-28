using System;
using System.Collections.Generic;

namespace Assignment14.Models
{
    public partial class Category
    {
        public Category()
        {
            Cources = new HashSet<Cource>();
        }

        public int Id { get; set; }
        public string CourceCategory { get; set; } = null!;

        public virtual ICollection<Cource> Cources { get; set; }
    }
}
