using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Notification
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
    }
}
