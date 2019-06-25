using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Image
    {
        public int Id { get; set; }
        public string Scope { get; set; }
        public string Name { get; set; }
        public int? RelatedId { get; set; }
        public string Path { get; set; }
    }
}
