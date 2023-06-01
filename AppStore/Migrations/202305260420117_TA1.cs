namespace AppStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TA1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoice", "TotalAmount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Invoice", "TotalAmount", c => c.Int(nullable: false));
        }
    }
}
