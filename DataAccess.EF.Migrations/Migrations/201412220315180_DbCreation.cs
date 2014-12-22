namespace DataAccess.EF.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Domain = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        Title = c.String(),
                        PermaLink = c.String(),
                        AuthorName = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Author", t => t.AuthorName, cascadeDelete: true)
                .Index(t => t.AuthorName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "AuthorName", "dbo.Author");
            DropIndex("dbo.Item", new[] { "AuthorName" });
            DropTable("dbo.Item");
            DropTable("dbo.Author");
        }
    }
}
