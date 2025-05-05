namespace Project.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedLoanModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "UnitPrice", c => c.String(nullable: false));
        }
    }
}
