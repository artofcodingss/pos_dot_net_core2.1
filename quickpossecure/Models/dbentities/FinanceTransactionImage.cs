using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class FinanceTransactionImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int? FkFinanceTransactionId { get; set; }

        public FinanceTransaction FkFinanceTransaction { get; set; }
    }
}
