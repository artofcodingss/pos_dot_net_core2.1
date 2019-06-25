using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Category
    {
        public Category()
        {
            InverseFkParent = new HashSet<Category>();
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? FkParentId { get; set; }

        public Category FkParent { get; set; }
        public ICollection<Category> InverseFkParent { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
