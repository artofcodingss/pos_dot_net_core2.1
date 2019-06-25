using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Product
    {
        public Product()
        {
            DealproductorreciperawFkMain = new HashSet<Dealproductorreciperaw>();
            DealproductorreciperawFkSub = new HashSet<Dealproductorreciperaw>();
            ProductBatch = new HashSet<ProductBatch>();
            ProductTransaction = new HashSet<ProductTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public float? PurchasePrice { get; set; }
        public float? SalePrice { get; set; }
        public float? Discount { get; set; }
        public string Description { get; set; }
        public float? Quantity { get; set; }
        public string Type { get; set; }
        public bool? ActiveOnSale { get; set; }
        public bool? ActiveOnPurchase { get; set; }
        public int? Sku { get; set; }
        public int? FkVendorId { get; set; }
        public int? FkManufacturerId { get; set; }
        public int? FkCategoryId { get; set; }
        public int? FkRackId { get; set; }
        public float? LowInventoryNotification { get; set; }

        public Category FkCategory { get; set; }
        public Manufacturer FkManufacturer { get; set; }
        public Rack FkRack { get; set; }
        public Vendor FkVendor { get; set; }
        public ICollection<Dealproductorreciperaw> DealproductorreciperawFkMain { get; set; }
        public ICollection<Dealproductorreciperaw> DealproductorreciperawFkSub { get; set; }
        public ICollection<ProductBatch> ProductBatch { get; set; }
        public ICollection<ProductTransaction> ProductTransaction { get; set; }
    }
}
