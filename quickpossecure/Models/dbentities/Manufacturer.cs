using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
