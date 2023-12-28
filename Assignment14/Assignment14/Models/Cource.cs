using System;
using System.Collections.Generic;

namespace Assignment14.Models
{
    public partial class Cource
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Fee { get; set; }
        public DateTime? Sdate { get; set; }
        public int? CourceCategory { get; set; }

        public virtual Category? CourceCategoryNavigation { get; set; }
    }
}
