using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class ProductBatch
    {
        public int Id { get; set; }
        public string Batch { get; set; }
        public string Description { get; set; }
        public float? Quantity { get; set; }
        public DateTime? Expiry { get; set; }
        public int? FkProductId { get; set; }

        public Product FkProduct { get; set; }
    }
}
