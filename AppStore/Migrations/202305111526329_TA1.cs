namespace AppStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TA1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        Flag = c.Boolean(nullable: false),
                        PhoneNumber = c.String(),
                        FullName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.AccountID);
            
            CreateTable(
                "dbo.Invoice",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        Flag = c.Boolean(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false),
                        TotalAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceID)
                .ForeignKey("dbo.Account", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Flag = c.Boolean(nullable: false),
                        PhoneNumber = c.String(),
                        FullName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.InvoiceDetail",
                c => new
                    {
                        InvoiceDetailID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        InvoiceID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Flag = c.Boolean(nullable: false),
                        SalePrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceDetailID)
                .ForeignKey("dbo.Invoice", t => t.InvoiceID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.InvoiceID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        ManufacturerID = c.Int(nullable: false),
                        ProductName = c.String(),
                        CostPrice = c.Int(nullable: false),
                        Flag = c.Boolean(nullable: false),
                        SalePrice = c.Int(nullable: false),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Manufacturer", t => t.ManufacturerID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.ManufacturerID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Flag = c.Boolean(nullable: false),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Manufacturer",
                c => new
                    {
                        ManufacturerID = c.Int(nullable: false, identity: true),
                        Flag = c.Boolean(nullable: false),
                        ManufacturerName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ManufacturerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "ManufacturerID", "dbo.Manufacturer");
            DropForeignKey("dbo.InvoiceDetail", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Product", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.InvoiceDetail", "InvoiceID", "dbo.Invoice");
            DropForeignKey("dbo.Invoice", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Invoice", "EmployeeID", "dbo.Account");
            DropIndex("dbo.Product", new[] { "ManufacturerID" });
            DropIndex("dbo.Product", new[] { "CategoryID" });
            DropIndex("dbo.InvoiceDetail", new[] { "InvoiceID" });
            DropIndex("dbo.InvoiceDetail", new[] { "ProductID" });
            DropIndex("dbo.Invoice", new[] { "CustomerID" });
            DropIndex("dbo.Invoice", new[] { "EmployeeID" });
            DropTable("dbo.Manufacturer");
            DropTable("dbo.Category");
            DropTable("dbo.Product");
            DropTable("dbo.InvoiceDetail");
            DropTable("dbo.Customers");
            DropTable("dbo.Invoice");
            DropTable("dbo.Account");
        }
    }
}
