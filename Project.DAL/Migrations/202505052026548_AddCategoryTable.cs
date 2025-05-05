namespace Project.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryTable : DbMigration
    {
        public override void Up()
        {
            // Category tablosunu oluştur
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    CategoryName = c.String(),
                })
                .PrimaryKey(t => t.ID);

            // Kategorileri ekle
            Sql("INSERT INTO dbo.Categories (CategoryName) VALUES ('Fiction')");
            Sql("INSERT INTO dbo.Categories (CategoryName) VALUES ('Science')");
            Sql("INSERT INTO dbo.Categories (CategoryName) VALUES ('Technology')");
            Sql("INSERT INTO dbo.Categories (CategoryName) VALUES ('Philosophy')");
            Sql("INSERT INTO dbo.Categories (CategoryName) VALUES ('History')");
        }
        
        public override void Down()
        {
            // Kategori tablosunu sil
            DropTable("dbo.Categories");
        }
    }
}
