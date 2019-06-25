using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class ProductTransaction
    {
        public int Id { get; set; }
        public float? Price { get; set; }
        public float? Quantity { get; set; }
        public float? Total { get; set; }
        public int? ProductBatchId { get; set; }
        public int? FkProductId { get; set; }
        public int? FkFinanceTransactionId { get; set; }

        public FinanceTransaction FkFinanceTransaction { get; set; }
        public Product FkProduct { get; set; }
    }
}
