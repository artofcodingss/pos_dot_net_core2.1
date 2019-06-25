using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class FinanceTransactionDetail
    {
        public int Id { get; set; }
        public int? FkFinanceTransactionId { get; set; }
        public string KeyName { get; set; }
        public string Value { get; set; }

        public FinanceTransaction FkFinanceTransaction { get; set; }
    }
}
