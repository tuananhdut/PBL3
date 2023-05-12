namespace AppStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TA2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InvoiceDetail", "Fag", c => c.Boolean(nullable: false));
            DropColumn("dbo.InvoiceDetail", "Flag");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InvoiceDetail", "Flag", c => c.Boolean(nullable: false));
            DropColumn("dbo.InvoiceDetail", "Fag");
        }
    }
}
