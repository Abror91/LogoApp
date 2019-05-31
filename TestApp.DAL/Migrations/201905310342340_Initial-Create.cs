namespace TestApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        ImagePath = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.TagLogoes",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        Logo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.Logo_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id)
                .ForeignKey("dbo.Logoes", t => t.Logo_Id)
                .Index(t => t.Tag_Id)
                .Index(t => t.Logo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagLogoes", "Logo_Id", "dbo.Logoes");
            DropForeignKey("dbo.TagLogoes", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.Tags", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Logoes", "CategoryId", "dbo.Categories");
            DropIndex("dbo.TagLogoes", new[] { "Logo_Id" });
            DropIndex("dbo.TagLogoes", new[] { "Tag_Id" });
            DropIndex("dbo.Tags", new[] { "CategoryId" });
            DropIndex("dbo.Logoes", new[] { "CategoryId" });
            DropTable("dbo.TagLogoes");
            DropTable("dbo.Tags");
            DropTable("dbo.Logoes");
            DropTable("dbo.Categories");
        }
    }
}
