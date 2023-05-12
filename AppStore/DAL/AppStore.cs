using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Xml;

namespace DAL
{
    public class AppStore : DbContext
    {
        public AppStore()
            : base("name=AppSto")
        {
        }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

    }
}