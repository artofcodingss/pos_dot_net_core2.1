using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Rack
    {
        public Rack()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
