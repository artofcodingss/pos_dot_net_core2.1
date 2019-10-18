using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace quickpossecure.Models.dbentities
{
    public partial class MyDbContext : DbContext
    {
        public virtual DbSet<Aspnetroleclaims> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetroles> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserroles> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusers> Aspnetusers { get; set; }
        public virtual DbSet<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Closing> Closing { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Dealproductorreciperaw> Dealproductorreciperaw { get; set; }
        public virtual DbSet<FinanceAccount> FinanceAccount { get; set; }
        public virtual DbSet<FinanceTransaction> FinanceTransaction { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductBatch> ProductBatch { get; set; }
        public virtual DbSet<ProductTransaction> ProductTransaction { get; set; }
        public virtual DbSet<Rack> Rack { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3306;database=quickpos;user=root;password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aspnetroleclaims>(entity =>
            {
                entity.ToTable("aspnetroleclaims");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetroles>(entity =>
            {
                entity.ToTable("aspnetroles");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<Aspnetuserclaims>(entity =>
            {
                entity.ToTable("aspnetuserclaims");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.ToTable("aspnetuserlogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserroles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("aspnetuserroles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserRoles_UserId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusers>(entity =>
            {
                entity.ToTable("aspnetusers");

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmailConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.LockoutEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PhoneNumberConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.TwoFactorEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Aspnetusertokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("aspnetusertokens");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.HasIndex(e => e.FkParentId)
                    .HasName("FK_Parent_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FkParentId)
                    .HasColumnName("FK_Parent_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.FkParent)
                    .WithMany(p => p.InverseFkParent)
                    .HasForeignKey(d => d.FkParentId)
                    .HasConstraintName("category_ibfk_1");
            });

            modelBuilder.Entity<Closing>(entity =>
            {
                entity.ToTable("closing");

                entity.HasIndex(e => e.FkAspnetusersId)
                    .HasName("FK_aspnetusers_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.FkAspnetusersId)
                    .HasColumnName("FK_aspnetusers_Id")
                    .HasMaxLength(200);

                entity.Property(e => e.Note1).HasColumnType("int(11)");

                entity.Property(e => e.Note2).HasColumnType("int(11)");

                entity.Property(e => e.Note3).HasColumnType("int(11)");

                entity.Property(e => e.Note4).HasColumnType("int(11)");

                entity.Property(e => e.Note5).HasColumnType("int(11)");

                entity.Property(e => e.Note6).HasColumnType("int(11)");

                entity.Property(e => e.Note7).HasColumnType("int(11)");

                entity.Property(e => e.Note8).HasColumnType("int(11)");

                entity.Property(e => e.Note9).HasColumnType("int(11)");

                entity.HasOne(d => d.FkAspnetusers)
                    .WithMany(p => p.Closing)
                    .HasForeignKey(d => d.FkAspnetusersId)
                    .HasConstraintName("closing_ibfk_1");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Dealproductorreciperaw>(entity =>
            {
                entity.ToTable("dealproductorreciperaw");

                entity.HasIndex(e => e.FkMainId)
                    .HasName("FK_Main_Id");

                entity.HasIndex(e => e.FkSubId)
                    .HasName("FK_Sub_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FkMainId)
                    .HasColumnName("FK_Main_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkSubId)
                    .HasColumnName("FK_Sub_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkMain)
                    .WithMany(p => p.DealproductorreciperawFkMain)
                    .HasForeignKey(d => d.FkMainId)
                    .HasConstraintName("dealproductorreciperaw_ibfk_1");

                entity.HasOne(d => d.FkSub)
                    .WithMany(p => p.DealproductorreciperawFkSub)
                    .HasForeignKey(d => d.FkSubId)
                    .HasConstraintName("dealproductorreciperaw_ibfk_2");
            });

            modelBuilder.Entity<FinanceAccount>(entity =>
            {
                entity.ToTable("finance_account");

                entity.HasIndex(e => e.FkParentId)
                    .HasName("FK_Parent_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FinanceAccountType)
                    .HasColumnName("Finance_Account_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.FkParentId)
                    .HasColumnName("FK_Parent_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.HasOne(d => d.FkParent)
                    .WithMany(p => p.InverseFkParent)
                    .HasForeignKey(d => d.FkParentId)
                    .HasConstraintName("finance_account_ibfk_1");
            });

            modelBuilder.Entity<FinanceTransaction>(entity =>
            {
                entity.ToTable("finance_transaction");

                entity.HasIndex(e => e.FkAspnetusersId)
                    .HasName("FK_aspnetusers_Id");

                entity.HasIndex(e => e.FkFinanceAccountId)
                    .HasName("FK_Finance_Account_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.Branch).HasMaxLength(100);

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ChildOf).HasColumnType("int(11)");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.FkAspnetusersId)
                    .HasColumnName("FK_aspnetusers_Id")
                    .HasMaxLength(200);

                entity.Property(e => e.FkFinanceAccountId)
                    .HasColumnName("FK_Finance_Account_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("Group_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OherDetails2).HasMaxLength(200);

                entity.Property(e => e.OtherDetail).HasMaxLength(200);

                entity.Property(e => e.PaymentMethod).HasMaxLength(30);

                entity.Property(e => e.ReferenceNumber).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserType)
                    .HasColumnName("User_Type")
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkAspnetusers)
                    .WithMany(p => p.FinanceTransaction)
                    .HasForeignKey(d => d.FkAspnetusersId)
                    .HasConstraintName("finance_transaction_ibfk_2");

                entity.HasOne(d => d.FkFinanceAccount)
                    .WithMany(p => p.FinanceTransaction)
                    .HasForeignKey(d => d.FkFinanceAccountId)
                    .HasConstraintName("finance_transaction_ibfk_1");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("image");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.RelatedId)
                    .HasColumnName("Related_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Scope).HasMaxLength(50);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("manufacturer");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notification");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Text).HasColumnType("text");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.HasIndex(e => e.FkCategoryId)
                    .HasName("FK_Category_Id");

                entity.HasIndex(e => e.FkManufacturerId)
                    .HasName("FK_Manufacturer_Id");

                entity.HasIndex(e => e.FkRackId)
                    .HasName("FK_Rack_Id");

                entity.HasIndex(e => e.FkVendorId)
                    .HasName("FK_Vendor_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ActiveOnPurchase).HasColumnType("bit(1)");

                entity.Property(e => e.ActiveOnSale).HasColumnType("bit(1)");

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FkCategoryId)
                    .HasColumnName("FK_Category_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkManufacturerId)
                    .HasColumnName("FK_Manufacturer_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkRackId)
                    .HasColumnName("FK_Rack_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkVendorId)
                    .HasColumnName("FK_Vendor_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PurchasePrice).HasColumnName("Purchase_Price");

                entity.Property(e => e.SalePrice).HasColumnName("Sale_Price");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type).HasMaxLength(15);

                entity.HasOne(d => d.FkCategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.FkCategoryId)
                    .HasConstraintName("product_ibfk_3");

                entity.HasOne(d => d.FkManufacturer)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.FkManufacturerId)
                    .HasConstraintName("product_ibfk_2");

                entity.HasOne(d => d.FkRack)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.FkRackId)
                    .HasConstraintName("product_ibfk_4");

                entity.HasOne(d => d.FkVendor)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.FkVendorId)
                    .HasConstraintName("product_ibfk_1");
            });

            modelBuilder.Entity<ProductBatch>(entity =>
            {
                entity.ToTable("product_batch");

                entity.HasIndex(e => e.FkProductId)
                    .HasName("FK_Product_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Batch).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Expiry).HasColumnType("datetime");

                entity.Property(e => e.FkProductId)
                    .HasColumnName("FK_Product_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkProduct)
                    .WithMany(p => p.ProductBatch)
                    .HasForeignKey(d => d.FkProductId)
                    .HasConstraintName("product_batch_ibfk_1");
            });

            modelBuilder.Entity<ProductTransaction>(entity =>
            {
                entity.ToTable("product_transaction");

                entity.HasIndex(e => e.FkFinanceTransactionId)
                    .HasName("FK_Finance_Transaction_Id");

                entity.HasIndex(e => e.FkProductId)
                    .HasName("FK_Product_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FkFinanceTransactionId)
                    .HasColumnName("FK_Finance_Transaction_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkProductId)
                    .HasColumnName("FK_Product_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductBatchId)
                    .HasColumnName("Product_Batch_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkFinanceTransaction)
                    .WithMany(p => p.ProductTransaction)
                    .HasForeignKey(d => d.FkFinanceTransactionId)
                    .HasConstraintName("product_transaction_ibfk_2");

                entity.HasOne(d => d.FkProduct)
                    .WithMany(p => p.ProductTransaction)
                    .HasForeignKey(d => d.FkProductId)
                    .HasConstraintName("product_transaction_ibfk_1");
            });

            modelBuilder.Entity<Rack>(entity =>
            {
                entity.ToTable("rack");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.ToTable("settings");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Boolvalue).HasColumnType("tinyint(1)");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Scope).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.UserType).HasMaxLength(50);

                entity.Property(e => e.VarcharValue).HasMaxLength(200);

                entity.Property(e => e.VarcharValue2).HasMaxLength(200);

                entity.Property(e => e.VarcharValue3).HasMaxLength(200);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("vendor");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });
        }
    }
}
