using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class DealProduct
    {
        public int Id { get; set; }
        public int? FkDealId { get; set; }
        public int? FkProductId { get; set; }
        public float? Quantity { get; set; }

        public Product FkDeal { get; set; }
        public Product FkProduct { get; set; }
    }
}
