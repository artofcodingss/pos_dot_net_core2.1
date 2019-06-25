using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Dealproductorreciperaw
    {
        public int Id { get; set; }
        public float? Quantity { get; set; }
        public int? FkMainId { get; set; }
        public int? FkSubId { get; set; }

        public Product FkMain { get; set; }
        public Product FkSub { get; set; }
    }
}
