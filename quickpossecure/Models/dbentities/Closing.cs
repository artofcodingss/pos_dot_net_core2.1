using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Closing
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public float? Expence { get; set; }
        public float? Income { get; set; }
        public float? ClosingBalance { get; set; }
        public string Comment { get; set; }
        public int? Note1 { get; set; }
        public int? Note2 { get; set; }
        public int? Note3 { get; set; }
        public int? Note4 { get; set; }
        public int? Note5 { get; set; }
        public int? Note6 { get; set; }
        public int? Note7 { get; set; }
        public int? Note8 { get; set; }
        public int? Note9 { get; set; }
        public string FkAspnetusersId { get; set; }

        public Aspnetusers FkAspnetusers { get; set; }
    }
}
